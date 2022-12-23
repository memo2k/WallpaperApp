using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Models.ApplicationUser;
using WallpaperApp.Infrastructure.Data;

namespace WallpaperApp.Core.Contracts
{
    public interface IApplicationUserService
    {
        Task<ApplicationUserProfileModel> GetUserById(string userId);
        Task<ApplicationUserEditModel> GetUser(string userId);
        Task UpdateUser(ApplicationUserEditModel model);
    }
}
