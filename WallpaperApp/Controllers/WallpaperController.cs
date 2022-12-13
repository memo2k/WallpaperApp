using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Extensions;

namespace WallpaperApp.Controllers
{
    [Authorize]
    public class WallpaperController : Controller
    {
        private readonly IWallpaperService wallpaperService;
        private readonly IApplicationUserService applicationUserService;

        public WallpaperController(IWallpaperService _wallpaperService, IApplicationUserService _applicationUserService)
        {
            wallpaperService = _wallpaperService;
            applicationUserService = _applicationUserService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = new WallpapersQueryModel();

            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var model = new WallpapersQueryModel();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = new WallpaperDetailsModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new WallpaperModel()
            {
                WallpaperCategories = await wallpaperService.AllCategories(),
                WallpaperResolutions = await wallpaperService.AllResolutions()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(WallpaperModel model)
        {
            if ((await wallpaperService.CategoryExists(model.CategoryId)) == false) 
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist.");
            }

            if ((await wallpaperService.ResolutionExists(model.ResolutionId)) == false)
            {
                ModelState.AddModelError(nameof(model.ResolutionId), "Resolution does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.WallpaperCategories = await wallpaperService.AllCategories();
                model.WallpaperResolutions = await wallpaperService.AllResolutions();

                return View(model);
            }

            var userId = await applicationUserService.GetApplicationUserId(User.Id());
            int id = await wallpaperService.Create(model, userId);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new WallpaperModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, WallpaperModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Like(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
