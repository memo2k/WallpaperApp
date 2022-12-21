using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WallpaperApp.Core.Models.Wallpaper
{
    public class WallpaperEditModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Camera { get; set; } = null!;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<WallpaperCategoryModel> WallpaperCategories { get; set; } = new List<WallpaperCategoryModel>();

        [Display(Name = "Resolution")]
        public int ResolutionId { get; set; }

        public IEnumerable<WallpaperResolutionModel> WallpaperResolutions { get; set; } = new List<WallpaperResolutionModel>();

        public string UserId { get; set; } = null!;
    }
}
