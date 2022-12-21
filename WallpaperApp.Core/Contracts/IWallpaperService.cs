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
        Task Create(WallpaperModel model);
        Task<WallpapersQueryModel> All(
            string? category = null,
            string? resolution = null,
            string? searchTerm = null,
            WallpaperSorting sorting = WallpaperSorting.Latest
        );
        Task<IEnumerable<string>> AllCategoriesNames();
        Task<IEnumerable<string>> AllResolutionsSizes();
        Task<IEnumerable<WallpaperServiceModel>> AllWallpapersByUserId(string userId);
        Task<WallpaperDetailsModel> WallpaperDetailsById(int id);
        Task<bool> Exists(int id);
        Task Edit(WallpaperEditModel model);
        Task<int> WallpaperCategoryId(int id);
        Task<int> WallpaperResolutionId(int id);
        Task<bool> isAuthor(int wallpaperId, string userId);
        Task Delete(int wallpaperId);
        Task<bool> IsLikedByUser(int wallpaperId, string userId);
        Task Like(int wallpaperId, string userId);
    }
}
