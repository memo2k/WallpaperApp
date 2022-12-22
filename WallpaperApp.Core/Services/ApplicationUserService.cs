using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.ApplicationUser;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Infrastructure.Data;
using WallpaperApp.Infrastructure.Data.Common;

namespace WallpaperApp.Core.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IRepository repo;
        private readonly ApplicationDbContext context;

        public ApplicationUserService(IRepository _repo, ApplicationDbContext _context)
        {
            repo = _repo;
            context = _context;
        }

        public async Task<ApplicationUserProfileModel> GetUserById(string userId)
        {
            return await repo.AllReadonly<ApplicationUser>()
                .Where(a => a.Id == userId)
                .Select(a => new ApplicationUserProfileModel()
                {
                    Id = a.Id,
                    UserName = a.UserName,
                    Email = a.Email,
                })
                .FirstAsync();
        }

        public async Task<ApplicationUserEditModel> GetUser(string userId)
        {
            var user = await GetUserById(userId);

            if (user == null)
            {
                throw new NullReferenceException();
            }

            return new ApplicationUserEditModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email
            };
        }

        public async Task UpdateUser(ApplicationUserEditModel model)
        {
            var user = await repo.GetByIdAsync<ApplicationUser>(model.Id);

            user.UserName = model.UserName;
            user.Email = model.Email;

            await repo.SaveChangesAsync();
        }
    }
}
