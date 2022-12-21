using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Infrastructure.Data.Configuration
{
    internal class WallpaperConfiguration : IEntityTypeConfiguration<Wallpaper>
    {
        public void Configure(EntityTypeBuilder<Wallpaper> builder)
        {
            builder.HasData(SeedWallpapers());
        }

        private List<Wallpaper> SeedWallpapers()
        {
            var wallpapers = new List<Wallpaper>()
            {
                new Wallpaper()
                {
                    Id = 1,
                    Title = "City",
                    Camera = "Samsung S20",
                    ImageUrl = "https://images5.alphacoders.com/438/438463.png",
                    Date = DateTime.Now,
                    CategoryId = 3,
                    ResolutionId = 3,
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082",
                },

                new Wallpaper()
                {
                    Id = 2,
                    Title = "Mountains",
                    Camera = "IPhone 12",
                    ImageUrl = "https://images.hdqwalls.com/download/nature-background-2560x1440.jpg",
                    Date = DateTime.Now,
                    CategoryId = 1,
                    ResolutionId = 4,
                    UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                },

                new Wallpaper()
                {
                    Id = 3,
                    Title = "Koenigsegg",
                    Camera = "SONY FDR-AX43",
                    ImageUrl = "https://wallpaperaccess.com/full/42412.jpg",
                    Date = DateTime.Now,
                    CategoryId = 4,
                    ResolutionId = 5,
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082",
                }
            };

            return wallpapers;
        }
    }
}
