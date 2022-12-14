using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WallpaperApp.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

        public ICollection<Favorite> Favorites { get; set; } = new HashSet<Favorite>();
    }
}
