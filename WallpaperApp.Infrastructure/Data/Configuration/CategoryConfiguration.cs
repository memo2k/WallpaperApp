﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(SeedCategories());
        }

        private List<Category> SeedCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Nature"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Animals"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Minimalist"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Cars"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Design"
                },

                new Category()
                {
                    Id = 6,
                    Name = "Food"
                },
            };

            return categories;
        }
    }
}
