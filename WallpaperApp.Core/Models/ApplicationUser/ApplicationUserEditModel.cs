using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallpaperApp.Core.Models.ApplicationUser
{
    public class ApplicationUserEditModel
    {
        public string Id { get; set; } = null!;

        [Required]
        [MinLength(3, ErrorMessage = "Username should be at least 3 characters long")]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MinLength(10, ErrorMessage = "Email should be at least 10 characters long")]
        public string Email { get; set; } = null!;
    }
}
