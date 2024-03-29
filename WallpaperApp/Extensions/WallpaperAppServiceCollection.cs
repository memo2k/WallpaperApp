﻿using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Services;
using WallpaperApp.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WallpaperAppServiceCollection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IWallpaperService, WallpaperService>();
            services.AddScoped<IApplicationUserService, ApplicationUserService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddScoped<ILikeService, LikeService>();
            services.AddScoped<ICommentService, CommentService>();

            return services;
        }
    }
}
