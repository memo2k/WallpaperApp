using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Infrastructure.Data;
using WallpaperApp.Infrastructure.Data.Common;

namespace WallpaperApp.Core.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly ApplicationDbContext repo;

        public ApplicationUserService(ApplicationDbContext _repo)
        {
            repo = _repo;
        }

        public async Task<ApplicationUser> GetApplicationUsertId(string userId)
        {
            return await repo.Users.FirstOrDefault(x => x.Id = userId);
        }
    }
}
