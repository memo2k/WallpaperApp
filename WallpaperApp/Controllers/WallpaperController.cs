using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

        public WallpaperController(IWallpaperService _wallpaperService,
            IApplicationUserService _applicationUserService)
        {
            wallpaperService = _wallpaperService;
            applicationUserService = _applicationUserService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllWallpapersQueryModel query)
        {
            var result = await wallpaperService.All(
                query.Category,
                query.Resolution,
                query.SearchTerm,
                query.Sorting);

            query.Categories = await wallpaperService.AllCategoriesNames();
            query.Resolutions = await wallpaperService.AllResolutionsSizes();
            query.Wallpapers = result.Wallpapers;

            return View(query);
        }

        public async Task<IActionResult> Mine()
        {
            IEnumerable<WallpaperServiceModel> wallpapers;

            var userId = User.Id();

            wallpapers = await wallpaperService.AllWallpapersByUserId(userId);
            return View(wallpapers);
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

            return RedirectToAction("Index", "Home");
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
                return RedirectToAction("/Account/AccessDenied", new { area = "Identity" });
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
                return RedirectToAction("/Account/AccessDenied", new { area = "Identity" });
            }

            //if (!ModelState.IsValid)
            //{
            //    model.WallpaperCategories = await wallpaperService.AllCategories();
            //    model.WallpaperResolutions = await wallpaperService.AllResolutions();

            //    return View(model);
            //}

            await wallpaperService.Edit(model);

            return RedirectToAction(nameof(Details), new { model.Id });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await wallpaperService.Delete(id);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Like(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
