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
    public class WallpaperService : IWallpaperService
    {
        private readonly IRepository repo;

        public WallpaperService(IRepository _repo)
        {
            repo = _repo;
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
    }
}
