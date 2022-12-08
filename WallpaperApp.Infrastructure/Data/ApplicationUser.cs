using Microsoft.AspNetCore.Identity;

namespace WallpaperApp.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
