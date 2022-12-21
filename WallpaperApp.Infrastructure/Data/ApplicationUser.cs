using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WallpaperApp.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser
    {
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public List<Favorite> Favorites { get; set; } = new List<Favorite>();

        public List<Like> Likes { get; set; } = new List<Like>();
    }
}
