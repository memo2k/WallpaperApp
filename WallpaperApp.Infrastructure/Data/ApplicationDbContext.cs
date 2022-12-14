using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WallpaperApp.Infrastructure.Data.Configuration;

namespace WallpaperApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ResolutionConfiguration());
            builder.ApplyConfiguration(new WallpaperConfiguration());

            builder.Entity<Wallpaper>(w =>
            {
                w.HasOne(c => c.Category)
                .WithMany(w => w.Wallpapers)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

                w.HasOne(r => r.Resolution)
                .WithMany(w => w.Wallpapers)
                .HasForeignKey(r => r.ResolutionId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Comment>(c =>
            {
                c.HasOne(u => u.User)
                .WithMany(c => c.Comments)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

                c.HasOne(w => w.Wallpaper)
                .WithMany(c => c.Comments)
                .HasForeignKey(u => u.WallpaperId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<Favorite> Favorites { get; set; } = null!;
        public DbSet<Resolution> Resolutions { get; set; } = null!;
        public DbSet<Wallpaper> Wallpapers { get; set; } = null!;
        public DbSet<VerifiedUser> VerifiedUsers { get; set; } = null!;
    }
}