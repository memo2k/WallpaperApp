﻿using Microsoft.EntityFrameworkCore;
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
        private readonly IApplicationUserService applicationUserService;

        public WallpaperService(IRepository _repo, ApplicationDbContext _context, IApplicationUserService _applicationUserService)
        {
            repo = _repo;
            context = _context;
            applicationUserService = _applicationUserService;
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
                UserId = model.UserId
            };

            await repo.AddAsync(wallpaper);
            await repo.SaveChangesAsync();
        }

        public async Task<WallpapersQueryModel> All(string? category = null, string? searchTerm = null, WallpaperSorting sorting = WallpaperSorting.Latest)
        {
            var result = new WallpapersQueryModel();
            var wallpapers = repo.AllReadonly<Wallpaper>();

            if (string.IsNullOrEmpty(category) == false)
            {
                wallpapers = wallpapers
                    .Where(w => w.Category.Name == category);
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
                    .OrderBy(w => w.Likes),
                _ => wallpapers.OrderByDescending(w => w.Id)
            };

            result.Wallpapers = await wallpapers
                .Select(w => new WallpaperServiceModel()
                {
                    Title = w.Title,
                    Id = w.Id,
                    ImageUrl = w.ImageUrl,
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
    }
}
