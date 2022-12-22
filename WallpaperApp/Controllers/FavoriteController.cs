using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WallpaperApp.Core.Constants;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Core.Services;
using WallpaperApp.Extensions;

namespace WallpaperApp.Controllers
{
    [Authorize]
    public class FavoriteController : Controller
    {
        private readonly IWallpaperService wallpaperService;
        private readonly IApplicationUserService applicationUserService;
        private readonly IFavoriteService favoriteService;

        public FavoriteController(IWallpaperService _wallpaperService,
            IApplicationUserService _applicationUserService,
            IFavoriteService _favoriteService)
        {
            wallpaperService = _wallpaperService;
            applicationUserService = _applicationUserService;
            favoriteService = _favoriteService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(WallpaperServiceModel model)
        {
            var userId = User.Id();

            if (await favoriteService.IsInFavorites(userId, model.Id))
            {
                await favoriteService.RemoveFromFavorite(userId, model.Id);
                TempData[MessageConstant.SuccessMessage] = "Wallpaper removed from favorites";
                return RedirectToAction("All", "Wallpaper");
            }

            await favoriteService.AddToFavorites(model, userId);
            TempData[MessageConstant.SuccessMessage] = "Wallpaper added to favorites";
            return RedirectToAction("MyFavorites", "Favorite");
        }

        public async Task<IActionResult> MyFavorites()
        {
            var userId = User.Id();
            var model = await favoriteService.FavoritesByUserId(userId);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Remove(WallpaperServiceModel model)
        {
            var userId = User.Id();
            await favoriteService.RemoveFromFavorite(userId, model.Id);
            TempData[MessageConstant.SuccessMessage] = "Wallpaper removed from favorites";
            return RedirectToAction("MyFavorites", "Favorite");
        }
    }
}
