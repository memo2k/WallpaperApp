using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Infrastructure.Data.Configuration
{
    internal class ResolutionConfiguration : IEntityTypeConfiguration<Resolution>
    {
        public void Configure(EntityTypeBuilder<Resolution> builder)
        {
            builder.HasData(SeedResolutions());
        }

        private List<Resolution> SeedResolutions()
        {
            List<Resolution> resolutions = new List<Resolution>()
            {
                new Resolution()
                {
                    Id = 1,
                    Size = "1280x720"
                },

                new Resolution()
                {
                    Id = 2,
                    Size = "1600x900"
                },

                new Resolution()
                {
                    Id = 3,
                    Size = "1920x1080"
                },

                new Resolution()
                {
                    Id = 4,
                    Size = "2560x1440"
                },

                new Resolution()
                {
                    Id = 5,
                    Size = "3840x2160"
                },
            };

            return resolutions;
        }
    }
}
