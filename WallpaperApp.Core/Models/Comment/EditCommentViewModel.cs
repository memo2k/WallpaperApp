using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Core.Models.Comment
{
    public class EditCommentViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 1)]
        public string Text { get; set; } = null!;

    }
}
