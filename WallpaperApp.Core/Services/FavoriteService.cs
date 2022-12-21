using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Favorite;
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

            user.Favorites.Add(new Favorite()
            {
                User = user,
                Wallpaper = wallpaper
            });

            await repo.SaveChangesAsync();
        }

        public async Task RemoveFromFavorite(string userId, int wallpaperId)
        {
            var favorite = await repo.GetByIdsAsync<Favorite>(new object[] { userId, wallpaperId });
            favorite.IsActive = false;

            await repo.SaveChangesAsync();
        }
    }
}
