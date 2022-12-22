using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Models.Wallpaper;

namespace WallpaperApp.Core.Contracts
{
    public interface IFavoriteService
    {
        Task AddToFavorites(WallpaperServiceModel model, string userId);
        Task<IEnumerable<WallpaperServiceModel>> FavoritesByUserId(string userId);
        Task RemoveFromFavorite(string userId, int wallpaperId);
        Task<bool> IsInFavorites(string userId, int wallpaperId);
    }
}
