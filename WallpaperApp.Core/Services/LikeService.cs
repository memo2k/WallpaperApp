﻿using Microsoft.EntityFrameworkCore;
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
    public class LikeService : ILikeService
    {
        private readonly IRepository repo;

        public LikeService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Like(WallpaperServiceModel model, string userId)
        {
            var user = await repo.GetByIdAsync<ApplicationUser>(userId);
            var wallpaper = await repo.GetByIdAsync<Wallpaper>(model.Id);

            user.Likes.Add(new Like()
            {
                User = user,
                Wallpaper = wallpaper
            });

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<WallpaperServiceModel>> LikedByUserId(string userId)
        {
            return await repo.AllReadonly<Like>()
                .Where(f => f.UserId == userId)
                .Where(f => f.IsActive)
                .Select(f => new WallpaperServiceModel()
                {
                    Id = f.WallpaperId,
                    Title = f.Wallpaper.Title,
                    Camera = f.Wallpaper.Camera,
                    ImageUrl = f.Wallpaper.ImageUrl,
                    User = new Models.ApplicationUser.ApplicationUserServiceModel()
                    {
                        UserName = f.User.UserName
                    }
                })
                .ToListAsync();
        }

        public async Task Unlike(string userId, int wallpaperId)
        {
            var like = await repo.GetByIdsAsync<Like>(new object[] { userId, wallpaperId });
            like.IsActive = false;

            await repo.SaveChangesAsync();
        }
    }
}