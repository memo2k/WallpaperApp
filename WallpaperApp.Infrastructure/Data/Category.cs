using System.ComponentModel.DataAnnotations;

namespace WallpaperApp.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Wallpapers = new List<Wallpaper>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        public List<Wallpaper> Wallpapers { get; set; }
    }
}
