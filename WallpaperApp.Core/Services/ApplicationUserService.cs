using Microsoft.AspNetCore.Identity;
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
        private readonly IRepository repo;
        private readonly ApplicationDbContext context;

        public ApplicationUserService(IRepository _repo, ApplicationDbContext _context)
        {
            repo = _repo;
            context = _context;
        }

        public async Task<ApplicationUser> GetUserById(string userId)
        {
            return await repo.GetByIdAsync<ApplicationUser>(userId);
        }
    }
}
