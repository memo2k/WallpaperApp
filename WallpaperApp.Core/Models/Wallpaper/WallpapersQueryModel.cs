namespace WallpaperApp.Core.Models.Wallpaper
{
    public class WallpapersQueryModel
    {
        public int TotalWallpapersCount { get; set; }

        public IEnumerable<WallpaperServiceModel> Wallpapers { get; set; } = new List<WallpaperServiceModel>();
    }
}
