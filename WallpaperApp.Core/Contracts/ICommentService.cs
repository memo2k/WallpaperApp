using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Models.Comment;
using WallpaperApp.Infrastructure.Data;

namespace WallpaperApp.Core.Contracts
{
    public interface ICommentService
    {
        Task AddComment(AddCommentViewModel model);
        Task<IEnumerable<CommentViewModel>> GetAllComments(int wallpaperId);
        Task DeleteComment(int id);
    }
}
