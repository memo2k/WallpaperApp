using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Models.ApplicationUser;

namespace WallpaperApp.Core.Models.Wallpaper
{
    public class WallpaperDetailsModel : WallpaperServiceModel
    {
        public string Category { get; set; } = null!;

        public string Resolution { get; set; } = null!;

        public bool IsAuthor { get; set; }
    }
}
