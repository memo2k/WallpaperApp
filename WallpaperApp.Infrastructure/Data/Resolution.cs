using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Infrastructure.Data
{
    public class Resolution
    {
        public Resolution()
        {
            Wallpapers = new List<Wallpaper>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Size { get; set; } = null!;

        public List<Wallpaper> Wallpapers { get; set; }
    }
}
