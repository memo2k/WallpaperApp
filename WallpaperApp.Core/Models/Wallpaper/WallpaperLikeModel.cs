using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Infrastructure.Data;

namespace WallpaperApp.Core.Models.Wallpaper
{
    public class WallpaperLikeModel
    {
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public Like LikeId { get; set; }

        public bool IsActive { get; set; }
    }
}
