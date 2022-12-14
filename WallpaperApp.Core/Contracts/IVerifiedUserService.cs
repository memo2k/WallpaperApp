using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Core.Contracts
{
    public interface IVerifiedUserService
    {
        Task<bool> ExistsById(Guid userId);
    }
}
