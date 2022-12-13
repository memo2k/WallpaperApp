using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Infrastructure.Data;
using WallpaperApp.Infrastructure.Data.Common;

namespace WallpaperApp.Core.Services
{
    public class WallpaperService : IWallpaperService
    {
        private readonly IRepository repo;

        public WallpaperService(IRepository _repo)
        {
            repo = _repo;
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
                .Select(x => new WallpaperIndexModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl,
                    Likes = x.Likes
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> Create(WallpaperModel model, string userId)
        {
            var wallpaper = new Wallpaper()
            {
                Title = model.Title,
                Camera = model.Camera,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                ResolutionId = model.ResolutionId,
                UserId = userId
            };

            await repo.AddAsync(wallpaper);
            await repo.SaveChangesAsync();

            return wallpaper.Id;
        }

        public async Task<bool> ResolutionExists(int resolutionId)
        {
            return await repo.AllReadonly<Resolution>()
                .AnyAsync(r => r.Id == resolutionId);
        }
    }
}
