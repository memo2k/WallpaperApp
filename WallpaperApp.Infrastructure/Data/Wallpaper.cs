using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WallpaperApp.Infrastructure.Data
{
    public class Wallpaper
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Camera { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        public int Likes { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int ResolutionId { get; set; }

        [ForeignKey(nameof(ResolutionId))]
        public Resolution Resolution { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
