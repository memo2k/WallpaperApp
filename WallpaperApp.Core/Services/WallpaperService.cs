using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Infrastructure.Data;
using WallpaperApp.Infrastructure.Data.Common;

namespace WallpaperApp.Core.Services
{
    public class WallpaperService : IWallpaperService
    {
        private readonly IRepository repo;
        private readonly ApplicationDbContext context;

        public WallpaperService(IRepository _repo, ApplicationDbContext _context)
        {
            repo = _repo;
            context = _context;
        }

        public async Task<IEnumerable<WallpaperCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .Select(x => new WallpaperCategoryModel()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<WallpaperResolutionModel>> AllResolutions()
        {
            return await repo.AllReadonly<Resolution>()
                .Select(x => new WallpaperResolutionModel()
                {
                    Id = x.Id,
                    Size = x.Size
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<WallpaperIndexModel>> AllWallpapers()
        {
            return await repo.AllReadonly<Wallpaper>()
                .Where(f => f.IsActive)
                .Select(x => new WallpaperIndexModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl,
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<bool> ResolutionExists(int resolutionId)
        {
            return await repo.AllReadonly<Resolution>()
                .AnyAsync(r => r.Id == resolutionId);
        }

        public async Task Create(WallpaperModel model)
        {
            Wallpaper wallpaper = new Wallpaper()
            {
                Title = model.Title,
                Camera = model.Camera,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                ResolutionId = model.ResolutionId,
                UserId = model.UserId,
                Date = model.Date,
            };

            try
            {
                await repo.AddAsync(wallpaper);
                await repo.SaveChangesAsync();
            } 
            catch (Exception)
            {
                throw null;
            }
            
        }

        public async Task<WallpapersQueryModel> All(string? category = null,
            string? resolution = null,
            string? searchTerm = null,
            WallpaperSorting sorting = WallpaperSorting.Latest)
        {
            var result = new WallpapersQueryModel();
            var wallpapers = repo.AllReadonly<Wallpaper>();

            if (string.IsNullOrEmpty(category) == false)
            {
                wallpapers = wallpapers
                    .Where(w => w.Category.Name == category);
            }

            if (string.IsNullOrEmpty(resolution) == false)
            {
                wallpapers = wallpapers
                    .Where(w => w.Resolution.Size == resolution);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                wallpapers = wallpapers
                    .Where(w => EF.Functions.Like(w.Title.ToLower(), searchTerm));
            }

            wallpapers = sorting switch
            {
                WallpaperSorting.Likes => wallpapers
                    .OrderByDescending(w => w.Likes.Count),
                _ => wallpapers.OrderByDescending(w => w.Id)
            };

            result.Wallpapers = await wallpapers
                .Where(f => f.IsActive)
                .Select(w => new WallpaperServiceModel()
                {
                    Title = w.Title,
                    Id = w.Id,
                    ImageUrl = w.ImageUrl,
                    User = new Models.ApplicationUser.ApplicationUserServiceModel()
                    {
                        UserName = w.User.UserName
                    }
                })
                .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<string>> AllCategoriesNames()
        {
            return await repo.AllReadonly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllResolutionsSizes()
        {
            return await repo.AllReadonly<Resolution>()
                .Select(r => r.Size)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<WallpaperServiceModel>> AllWallpapersByUserId(string userId)
        {
            return await repo.AllReadonly<Wallpaper>()
                .Where(w => w.UserId == userId)
                .Where(f => f.IsActive)
                .Select(w => new WallpaperServiceModel()
                {
                    Title = w.Title,
                    Id = w.Id,
                    ImageUrl = w.ImageUrl,
                    User = new Models.ApplicationUser.ApplicationUserServiceModel()
                    {
                        UserName = w.User.UserName
                    }
                })
                .ToListAsync();
        }

        public async Task<WallpaperDetailsModel> WallpaperDetailsById(int id)
        {
            return await repo.AllReadonly<Wallpaper>()
                .Where(w => w.Id == id)
                .Where(f => f.IsActive)
                .Select(w => new WallpaperDetailsModel()
                {
                    Title = w.Title,
                    Id = w.Id,
                    ImageUrl = w.ImageUrl,
                    Category = w.Category.Name,
                    Resolution = w.Resolution.Size,
                    Camera = w.Camera,
                    User = new Models.ApplicationUser.ApplicationUserServiceModel()
                    {
                        Id = w.User.Id,
                        UserName = w.User.UserName,
                        Email = w.User.Email
                    }
                })
                .FirstAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Wallpaper>()
                .AnyAsync(w => w.Id == id);
        }

        public async Task Edit(WallpaperEditModel model)
        {
            var wallpaper = await repo.GetByIdAsync<Wallpaper>(model.Id);

            wallpaper.Title = model.Title;
            wallpaper.Camera = model.Camera;
            wallpaper.CategoryId = model.CategoryId;
            wallpaper.ResolutionId = model.ResolutionId;

            await repo.SaveChangesAsync();
        }

        public async Task<int> WallpaperCategoryId(int id)
        {
            return (await repo.GetByIdAsync<Wallpaper>(id)).CategoryId;
        }

        public async Task<int> WallpaperResolutionId(int id)
        {
            return (await repo.GetByIdAsync<Wallpaper>(id)).ResolutionId;
        }

        public async Task<bool> isAuthor(int wallpaperId, string userId)
        {
            var result = false;

            var wallpaper = await repo.AllReadonly<Wallpaper>()
                .Where(w => w.Id == wallpaperId)
                .Include(w => w.User)
                .FirstOrDefaultAsync();

            if (wallpaper?.User != null && wallpaper.User.Id == userId)
            {
                result = true;
            }

            return result;
        }

        public async Task Delete(int wallpaperId)
        {
            var wallpaper = await repo.GetByIdAsync<Wallpaper>(wallpaperId);
            wallpaper.IsActive = false;

            await repo.SaveChangesAsync();
        }

    }
}
