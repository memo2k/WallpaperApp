﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Models.Wallpaper;

namespace WallpaperApp.Core.Contracts
{
    public interface IWallpaperService
    {
        Task<IEnumerable<WallpaperIndexModel>> AllWallpapers();
    }
}
