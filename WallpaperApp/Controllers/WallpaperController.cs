using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WallpaperApp.Core.Constants;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Extensions;
using WallpaperApp.Models;

namespace WallpaperApp.Controllers
{
    [Authorize]
    public class WallpaperController : Controller
    {
        private readonly IWallpaperService wallpaperService;
        private readonly IApplicationUserService applicationUserService;
        private readonly ICommentService commentService;

        public WallpaperController(IWallpaperService _wallpaperService,
            IApplicationUserService _applicationUserService,
            ICommentService _commentService)
        {
            wallpaperService = _wallpaperService;
            applicationUserService = _applicationUserService;
            commentService = _commentService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllWallpapersQueryModel query)
        {
            var result = await wallpaperService.All(
                query.Category,
                query.Resolution,
                query.SearchTerm);

            query.Categories = await wallpaperService.AllCategoriesNames();
            query.Resolutions = await wallpaperService.AllResolutionsSizes();
            query.Wallpapers = result.Wallpapers;

            return View(query);
        }

        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            var model = await wallpaperService.AllWallpapersByUserId(userId);
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if (!await wallpaperService.Exists(id))
            {
                return RedirectToAction(nameof(All));
            }

            var model = await wallpaperService.WallpaperDetailsById(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var userId = User.Id();

            var model = new WallpaperModel()
            {
                UserId = userId,
                WallpaperCategories = await wallpaperService.AllCategories(),
                WallpaperResolutions = await wallpaperService.AllResolutions()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(WallpaperModel model)
        {
            model.Date = DateTime.Now;

            if (!ModelState.IsValid)
            {
                model.WallpaperCategories = await wallpaperService.AllCategories();
                model.WallpaperResolutions = await wallpaperService.AllResolutions();

                return View(model);
            }

            await wallpaperService.Create(model);
            TempData[MessageConstant.SuccessMessage] = "Wallpaper created successfully";
            return RedirectToAction("All", "Wallpaper");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!await wallpaperService.Exists(id))
            {
                return RedirectToAction(nameof(All));
            }

            if (!await wallpaperService.isAuthor(id, User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "You cannot access this page.";
                return RedirectToAction(nameof(All));
            }

            var wallpaper = await wallpaperService.WallpaperDetailsById(id);
            var categoryId = await wallpaperService.WallpaperCategoryId(id);
            var resolutionId = await wallpaperService.WallpaperResolutionId(id);

            var model = new WallpaperEditModel()
            {
                Id = id,
                Title = wallpaper.Title,
                Camera = wallpaper.Camera,
                CategoryId = categoryId,
                ResolutionId = resolutionId,
                WallpaperCategories = await wallpaperService.AllCategories(),
                WallpaperResolutions = await wallpaperService.AllResolutions()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(WallpaperEditModel model)
        {
            if (!await wallpaperService.Exists(model.Id))
            {
                ModelState.AddModelError("", "Post does not exist.");
                model.WallpaperCategories = await wallpaperService.AllCategories();
                model.WallpaperResolutions = await wallpaperService.AllResolutions();

                return View(model);
            }

            if (!await wallpaperService.isAuthor(model.Id, User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "You cannot access this page.";
                return RedirectToAction(nameof(Details), new { model.Id });
            }

            await wallpaperService.Edit(model);
            TempData[MessageConstant.SuccessMessage] = "Wallpaper updated successfully";
            return RedirectToAction(nameof(Details), new { model.Id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (!await wallpaperService.isAuthor(id, User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "You cannot access this page.";
                return RedirectToAction(nameof(All));
            }

            await wallpaperService.Delete(id);
            TempData[MessageConstant.SuccessMessage] = "Wallpaper was deleted successfully";
            return RedirectToAction("All", "Wallpaper");
        }

        [AllowAnonymous]
        public async Task<IActionResult> AllComments(int wallpaperId)
        {
            var comments = await commentService.GetAllComments(wallpaperId);

            return View(comments);
        }
    }
}
