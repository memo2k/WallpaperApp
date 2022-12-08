using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WallpaperApp.Infrastructure.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string Text { get; set; } = null!;

        public DateTime Date { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        public int WallpaperId { get; set; }

        [ForeignKey(nameof(WallpaperId))]
        public Wallpaper Wallpaper { get; set; }
    }
}
