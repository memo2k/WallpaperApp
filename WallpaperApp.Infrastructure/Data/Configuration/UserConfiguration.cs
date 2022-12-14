using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(SeedUsers());
        }

        private List<ApplicationUser> SeedUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "wauser",
                NormalizedUserName = "wauser",
                Email = "wauser@mail.com",
                NormalizedEmail = "wauser@mail.com"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "Wauser1");

            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "wauser2",
                NormalizedUserName = "wauser2",
                Email = "wauser2@mail.com",
                NormalizedEmail = "wauser2@mail.com"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "Wauser2");

            users.Add(user);

            return users;
        }
    }
}
