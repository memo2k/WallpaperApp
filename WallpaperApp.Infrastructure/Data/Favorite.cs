using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Infrastructure.Data
{
    public class Favorite
    {
        public Favorite()
        {
            Wallpapers = new List<Wallpaper>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public List<Wallpaper> Wallpapers { get; set; }
    }
}
