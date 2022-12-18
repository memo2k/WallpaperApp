using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WallpaperApp.Core.Models.Wallpaper
{
    public class WallpaperServiceModel
    {
        public int Id { get; init; }

        public string Title { get; init; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = null!;

        public int Likes { get; set; }
    }
}
