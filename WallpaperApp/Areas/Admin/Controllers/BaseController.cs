using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static WallpaperApp.Areas.Admin.Constants.AdminConstants;

namespace WallpaperApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Route(RouteName)]
    [Authorize(AdminRoleName)]
    public class BaseController : Controller
    {
    }
}
