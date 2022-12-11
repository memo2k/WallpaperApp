using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Models;

namespace WallpaperApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWallpaperService wallpaperService;

        public HomeController(IWallpaperService _wallpaperService)
        {
            wallpaperService = _wallpaperService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await wallpaperService.AllWallpapers();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}