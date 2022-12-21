using AjaxControlToolkit.HtmlEditor.Sanitizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Comment;
using WallpaperApp.Core.Services;
using WallpaperApp.Extensions;

namespace WallpaperApp.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;
        private readonly IWallpaperService wallpaperService;

        public CommentController(ICommentService _commentService, IWallpaperService _wallpaperService)
        {
            commentService = _commentService;
            wallpaperService = _wallpaperService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(int wallpaperId)
        {
            if (!await wallpaperService.Exists(wallpaperId))
            {
                return RedirectToAction("Index", "Home");
            }

            var userId = User.Id();

            var model = new AddCommentViewModel()
            {
                UserId = userId,
                WallpaperId = wallpaperId,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCommentViewModel model)
        {
            model.Date = DateTime.Now;

            if (!ModelState.IsValid)
            {
                return this.View("Add", model);
            }

            await commentService.AddComment(model);

            return RedirectToAction("Details", "Wallpaper", new { wallpaperId = model.WallpaperId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await commentService.DeleteComment(id);

            return RedirectToAction("All", "Wallpaper");
        }
    }
}
