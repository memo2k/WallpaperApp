using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WallpaperApp.Core.Models.ApplicationUser;
using WallpaperApp.Infrastructure.Data;

namespace WallpaperApp.Core.Models.Wallpaper
{
    public class WallpaperServiceModel
    {
        public int Id { get; init; }

        public string Title { get; init; } = null!;

        public string Camera { get; init; } = null!;


        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = null!;

        public ApplicationUserServiceModel User { get; set; } = null!;
    }
}
