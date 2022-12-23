using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Models.Comment;
using WallpaperApp.Infrastructure.Data.Common;
using WallpaperApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WallpaperApp.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository repo;

        public CommentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddComment(AddCommentViewModel model)
        {
            var user = await repo.GetByIdAsync<ApplicationUser>(model.UserId);
            var wallpaper = await repo.GetByIdAsync<Wallpaper>(model.WallpaperId);

            if (user == null || wallpaper == null)
            {
                throw new Exception();
            }

            Comment comment = new Comment()
            {
                Text = model.Text,
                Date = model.Date,
                UserId = model.UserId,
                WallpaperId = model.WallpaperId
            };

            await repo.AddAsync(comment);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteComment(int id)
        {
            await repo.DeleteAsync<Comment>(id);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<CommentViewModel>> GetAllComments(int wallpaperId)
        {
            return await repo.AllReadonly<Comment>()
                .Where(c => c.WallpaperId == wallpaperId)
                .Select(c => new CommentViewModel()
                {
                    Id = c.Id,
                    Text = c.Text,
                    Date = c.Date,
                    WallpaperId = c.WallpaperId,
                    UserId = c.UserId,
                    User = new Models.ApplicationUser.ApplicationUserServiceModel()
                    {
                        UserName = c.User.UserName
                    }
                })
                .ToListAsync();
        }
    }
}
