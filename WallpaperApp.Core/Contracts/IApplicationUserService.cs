using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Infrastructure.Data;

namespace WallpaperApp.Core.Contracts
{
    public interface IApplicationUserService
    {
        Task<bool> ExistsById(string userId);

        Task<ApplicationUser> GetById(string userId);
    }
}
