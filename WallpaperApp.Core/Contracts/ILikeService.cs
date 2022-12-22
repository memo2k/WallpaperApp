using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Models.Wallpaper;

namespace WallpaperApp.Core.Contracts
{
    public interface ILikeService
    {
        Task Like(WallpaperServiceModel model, string userId);
        Task<IEnumerable<WallpaperServiceModel>> LikedByUserId(string userId);
        Task Unlike(string userId, int wallpaperId);
        Task<bool> IsInLikes(string userId, int wallpaperId);
    }
}
