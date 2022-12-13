using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Models.Wallpaper;

namespace WallpaperApp.Core.Contracts
{
    public interface IWallpaperService
    {
        Task<IEnumerable<WallpaperIndexModel>> AllWallpapers();
        Task<IEnumerable<WallpaperCategoryModel>> AllCategories();
        Task<IEnumerable<WallpaperResolutionModel>> AllResolutions();

        Task<bool> CategoryExists(int categoryId);

        Task<bool> ResolutionExists(int resolutionId);

        Task<int> Create(WallpaperModel model, string userId);
    }
}
