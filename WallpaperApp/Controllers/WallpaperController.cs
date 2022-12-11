using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WallpaperApp.Core.Models.Wallpaper;

namespace WallpaperApp.Controllers
{
    [Authorize]
    public class WallpaperController : Controller
    {
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
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(WallpaperModel model)
        {
            int id = 1;

            return RedirectToAction(nameof(Details), new { id });
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
