using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WallpaperApp.Core.Constants;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.ApplicationUser;
using WallpaperApp.Extensions;
using WallpaperApp.Infrastructure.Data;

namespace WallpaperApp.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IApplicationUserService applicationUserService;

        public UserController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager,
            IApplicationUserService _applicationUserService)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            applicationUserService = _applicationUserService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new ApplicationUserLoginModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(ApplicationUserLoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    TempData[MessageConstant.SuccessMessage] = "Logged in successfully";
                    return RedirectToAction("Index", "Home");
                }
            }

            TempData[MessageConstant.ErrorMessage] = "Invalid email or password";
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new ApplicationUserRegisterModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(ApplicationUserRegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                EmailConfirmed = true
            };

            var userEmail = await userManager.FindByEmailAsync(model.Email);
            var userName = await userManager.FindByNameAsync(model.UserName);

            if (userEmail != null)
            {
                TempData[MessageConstant.ErrorMessage] = "Email already in use.";
                return View(model);
            }

            if (userName != null)
            {
                TempData[MessageConstant.ErrorMessage] = "Username already in use.";
                return View(model);
            }

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                TempData[MessageConstant.SuccessMessage] = "Regisered successfully";
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            TempData[MessageConstant.ErrorMessage] = "Password should have at least 1 capital letter and 1 digit.";
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var userId = User.Id();
            var model = await applicationUserService.GetUser(userId);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationUserEditModel model)
        {
            var userId = User.Id();
            model.Id = userId;

            if (model.Email == null)
            {
                TempData[MessageConstant.ErrorMessage] = "Please add an email.";
                return View(model);
            }

            if (model.UserName == null)
            {
                TempData[MessageConstant.ErrorMessage] = "Please add a username.";
                return View(model);
            }

            await applicationUserService.UpdateUser(model);
            TempData[MessageConstant.SuccessMessage] = "User updated successfully";
            return RedirectToAction("Profile", "User");
        }

        public async Task<IActionResult> Profile()
        {
            var userId = User.Id();

            var model = await applicationUserService.GetUserById(userId);

            return View(model);
        }
    }
}
