using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperApp.Core.Contracts;
using WallpaperApp.Core.Services;
using WallpaperApp.Infrastructure.Data;
using WallpaperApp.Infrastructure.Data.Common;

namespace WallpaperApp.UnitTests
{
    [TestFixture]
    public class WallpaperServiceTest
    {
        private IRepository repo;
        private ApplicationDbContext context;
        private IWallpaperService wallpaperService;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("WallpaperDb")
                .Options;

            context = new ApplicationDbContext(contextOptions);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }

        [Test]
        public async Task Test_AddWallpaper()
        {
        }

        [TearDown]
        public void Teardown()
        {
            context.Dispose();
        }
    }
}
