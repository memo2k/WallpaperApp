using Microsoft.AspNetCore.Mvc;
using WallpaperApp.Core.Constants;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Core.Services;
using WallpaperApp.Extensions;
using WallpaperApp.Infrastructure.Data.Common;

namespace WallpaperApp.Controllers
{
    public class LikeController : Controller
    {
        private readonly ILikeService likeService;
        private readonly IRepository repo;

        public LikeController(ILikeService _likeService, IRepository _repo)
        {
            likeService = _likeService;
            repo = _repo;
        }

        [HttpPost]
        public async Task<IActionResult> Like(WallpaperServiceModel model)
        {
            var userId = User.Id();

            if (await likeService.IsInLikes(userId, model.Id))
            {
                await likeService.Unlike(userId, model.Id);
                TempData[MessageConstant.SuccessMessage] = "Wallpaper unliked";
                return RedirectToAction("All", "Wallpaper");
            }

            TempData[MessageConstant.SuccessMessage] = "Wallpaper liked";
            await likeService.Like(model, userId);
            return RedirectToAction("AllLiked", "Like");
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
            TempData[MessageConstant.SuccessMessage] = "Wallpaper unliked";
            return RedirectToAction("AllLiked", "Like");
        }
    }
}
