using Microsoft.AspNetCore.Mvc;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Core.Services;
using WallpaperApp.Extensions;

namespace WallpaperApp.Controllers
{
    public class LikeController : Controller
    {
        private readonly ILikeService likeService;

        public LikeController(ILikeService _likeService)
        {
            likeService = _likeService;
        }

        [HttpPost]
        public async Task<IActionResult> Like(WallpaperServiceModel model)
        {
            var userId = User.Id();
            await likeService.Like(model, userId);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AllLiked()
        {
            var userId = User.Id();
            var model = await likeService.LikedByUserId(userId);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Unlike(WallpaperServiceModel model)
        {
            var userId = User.Id();
            await likeService.Unlike(userId, model.Id);

            return RedirectToAction("Liked", "Like");
        }
    }
}
