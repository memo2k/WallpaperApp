using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Wallpaper;
using WallpaperApp.Infrastructure.Data;
using WallpaperApp.Infrastructure.Data.Common;

namespace WallpaperApp.Core.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IRepository repo;
        private readonly ApplicationDbContext context;
        private readonly IWallpaperService wallpaperService;

        public FavoriteService(IRepository _repo, ApplicationDbContext _context, IWallpaperService _wallpaperService)
        {
            repo = _repo;
            context = _context;
            wallpaperService = _wallpaperService;
        }

        public async Task<IEnumerable<WallpaperServiceModel>> FavoritesByUserId(string userId)
        {
            return await repo.AllReadonly<Favorite>()
                .Where(f => f.UserId == userId)
                .Where(f => f.IsActive)
                .Where(f => f.Wallpaper.IsActive)
                .Select(f => new WallpaperServiceModel()
                {
                    Id = f.WallpaperId,
                    Title = f.Wallpaper.Title,
                    Camera = f.Wallpaper.Camera,
                    ImageUrl = f.Wallpaper.ImageUrl,
                    User = new Models.ApplicationUser.ApplicationUserServiceModel()
                    {
                        UserName = f.User.UserName
                    }
                })
                .ToListAsync();
        }

        public async Task AddToFavorites(WallpaperServiceModel model, string userId)
        {
            var user = await repo.GetByIdAsync<ApplicationUser>(userId);
            var wallpaper = await repo.GetByIdAsync<Wallpaper>(model.Id);

            if (user == null || wallpaper == null)
            {
                throw new Exception();
            }

            var favorite = await repo.GetByIdsAsync<Favorite>(new object[] { userId, model.Id });

            if (favorite != null)
            {
                favorite.IsActive = true;
            }
            else
            {
                user.Favorites.Add(new Favorite()
                {
                    User = user,
                    Wallpaper = wallpaper
                });
            }

            await repo.SaveChangesAsync();
        }

        public async Task RemoveFromFavorite(string userId, int wallpaperId)
        {
            var favorite = await repo.GetByIdsAsync<Favorite>(new object[] { userId, wallpaperId });

            if (favorite == null)
            {
                throw new Exception();
            }

            favorite.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> IsInFavorites(string userId, int wallpaperId)
        {
            var favorite = await repo.GetByIdsAsync<Favorite>(new object[] { userId, wallpaperId });

            if (favorite == null)
            {
                return false;
            }

            if (favorite.IsActive == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
