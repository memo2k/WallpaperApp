using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Infrastructure.Data
{
    public class Like
    {
        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int WallpaperId { get; set; }

        [ForeignKey(nameof(WallpaperId))]
        public Wallpaper Wallpaper { get; set; } = null!;

        public bool IsActive { get; set; } = true;
    }
}
