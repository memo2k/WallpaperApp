using WallpaperApp.Core.Models.Wallpaper;

namespace WallpaperApp.Models
{
    public class AllWallpapersQueryModel
    {
        public string? Category { get; set; }

        public string? Resolution { get; set; }

        public string? SearchTerm { get; set; }

        public WallpaperSorting Sorting { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> Resolutions { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<WallpaperServiceModel> Wallpapers { get; set; } = Enumerable.Empty<WallpaperServiceModel>();
    }
}
