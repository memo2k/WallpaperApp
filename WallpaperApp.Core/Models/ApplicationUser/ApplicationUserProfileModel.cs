using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WallpaperApp.Core.Models.ApplicationUser
{
    public class ApplicationUserProfileModel
    {
        public string Id { get; set; } = null!;

        public string UserName { get; set; }

        public string Email { get; set; }
    }
}
