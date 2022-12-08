using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallpapers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Camera = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ResolutionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FavoriteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallpapers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallpapers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wallpapers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wallpapers_Favorites_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorites",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Wallpapers_Resolutions_ResolutionId",
                        column: x => x.ResolutionId,
                        principalTable: "Resolutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WallpaperId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Wallpapers_WallpaperId",
                        column: x => x.WallpaperId,
                        principalTable: "Wallpapers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "1e8257ef-9ee2-4c1f-99ba-87c706711c02", "wauser2@mail.com", false, "Dimitar", "Petrov", false, null, "wauser2mail.com", "wauser2", "AQAAAAEAACcQAAAAEJtqMZHcSuO7sKz3Ugwci00D5FT+ztpbEkIyUXEe9Xi3s4lEeCGBBUtOHEWU8VBZLQ==", null, false, null, false, "wauser2" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "5e2e7c3b-9014-46a6-b03e-aef0512035ab", "wauser@mail.com", false, "Georgi", "Ivanov", false, null, "wauser@mail.com", "wauser", "AQAAAAEAACcQAAAAEI4/VahM8BY9+NTDSexy8N9sWieVZI1/87QL7dhxL7dB0kqOPilUiZioOJog/sHkMw==", null, false, null, false, "wauser" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nature" },
                    { 2, "Animals" },
                    { 3, "Minimalist" },
                    { 4, "Cars" },
                    { 5, "Design" },
                    { 6, "Food" }
                });

            migrationBuilder.InsertData(
                table: "Resolutions",
                columns: new[] { "Id", "Size" },
                values: new object[,]
                {
                    { 1, "1280x720" },
                    { 2, "1600x900" },
                    { 3, "1920x1080" },
                    { 4, "2560x1440" },
                    { 5, "3840x2160" }
                });

            migrationBuilder.InsertData(
                table: "Wallpapers",
                columns: new[] { "Id", "Camera", "CategoryId", "Date", "FavoriteId", "ImageUrl", "Likes", "ResolutionId", "Title", "UserId" },
                values: new object[] { 1, "Samsung S20", 3, new DateTime(2022, 12, 8, 19, 24, 3, 287, DateTimeKind.Local).AddTicks(634), null, "https://images5.alphacoders.com/438/438463.png", 2, 3, "City", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Wallpapers",
                columns: new[] { "Id", "Camera", "CategoryId", "Date", "FavoriteId", "ImageUrl", "Likes", "ResolutionId", "Title", "UserId" },
                values: new object[] { 2, "IPhone 12", 1, new DateTime(2022, 12, 8, 19, 24, 3, 287, DateTimeKind.Local).AddTicks(683), null, "https://images.hdqwalls.com/download/nature-background-2560x1440.jpg", 4, 4, "Mountains", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Wallpapers",
                columns: new[] { "Id", "Camera", "CategoryId", "Date", "FavoriteId", "ImageUrl", "Likes", "ResolutionId", "Title", "UserId" },
                values: new object[] { 3, "SONY FDR-AX43", 4, new DateTime(2022, 12, 8, 19, 24, 3, 287, DateTimeKind.Local).AddTicks(687), null, "https://wallpaperaccess.com/full/42412.jpg", 1, 5, "Koenigsegg", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WallpaperId",
                table: "Comments",
                column: "WallpaperId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallpapers_CategoryId",
                table: "Wallpapers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallpapers_FavoriteId",
                table: "Wallpapers",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallpapers_ResolutionId",
                table: "Wallpapers",
                column: "ResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallpapers_UserId",
                table: "Wallpapers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Wallpapers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Resolutions");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
