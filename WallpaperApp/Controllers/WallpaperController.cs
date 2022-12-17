using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;

namespace WallpaperApp.Controllers
{
    [Authorize]
    public class WallpaperController : Controller
    {
        private readonly IWallpaperService wallpaperService;
        private readonly IApplicationUserService applicationUserService;

        public WallpaperController(IWallpaperService _wallpaperService,
            IApplicationUserService _applicationUserService)
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
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var model = new WallpaperModel()
            {
                UserId = UserId,
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

            return RedirectToAction("Index", "Home");
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
