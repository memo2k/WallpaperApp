using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class EditedFavorite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallpapers_Favorites_FavoriteId",
                table: "Wallpapers");

            migrationBuilder.DropIndex(
                name: "IX_Wallpapers_FavoriteId",
                table: "Wallpapers");

            migrationBuilder.DropColumn(
                name: "FavoriteId",
                table: "Wallpapers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Wallpapers");

            migrationBuilder.AddColumn<int>(
                name: "WallpaperId",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "39b00973-7aa6-437a-b5a7-7b56b2c140bd", "AQAAAAEAACcQAAAAEJYd+oA+BcLjJqv+iuOZW94ZsUgD0pfVLIkPnR05vi48U1iVAa5/fIaZ/qQuAqvGgg==", "c3e8edb9-fb07-48bf-be6b-2c0c89a4eb90" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "5465eb6d-7ee2-4a6e-8a78-9e12467b8bfb", "AQAAAAEAACcQAAAAEJxu/8W1wOdNfSOtsHOo0bU1yqKFOb+kA2aqIcdJ7yPHnPH14j2Cbj7inWFumpR34g==", "ef1fa568-89e8-4959-b658-4f6fa7205b04" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 14, 0, 32, 176, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 20, 14, 0, 32, 176, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 20, 14, 0, 32, 176, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_WallpaperId",
                table: "Favorites",
                column: "WallpaperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Wallpapers_WallpaperId",
                table: "Favorites",
                column: "WallpaperId",
                principalTable: "Wallpapers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Wallpapers_WallpaperId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_WallpaperId",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "WallpaperId",
                table: "Favorites");

            migrationBuilder.AddColumn<int>(
                name: "FavoriteId",
                table: "Wallpapers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Wallpapers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af1655fc-d628-46ba-b9c8-932074f05919", "AQAAAAEAACcQAAAAEAEQtMijQ7NRcvqSHEN4UszQsVz7xfJdCuU2lU54tuzgd/6WVWlB3wcV4b2p9cS4HA==", "417f6a27-60f6-4f2f-8022-c03fd8ff3e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a356d901-f1f0-4ff3-89b1-3088b7d4594a", "AQAAAAEAACcQAAAAEG6OdUYsHzA8CCfV8lK4dwAgSaCbIf8YqwM8FER2b80Ihiseg0B4WK+ITkVcKdT9Zg==", "ecf4a277-2899-44b8-aeac-af44784e92af" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 40, 40, 285, DateTimeKind.Local).AddTicks(7344), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 40, 40, 285, DateTimeKind.Local).AddTicks(7381), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 40, 40, 285, DateTimeKind.Local).AddTicks(7384), true });

            migrationBuilder.CreateIndex(
                name: "IX_Wallpapers_FavoriteId",
                table: "Wallpapers",
                column: "FavoriteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallpapers_Favorites_FavoriteId",
                table: "Wallpapers",
                column: "FavoriteId",
                principalTable: "Favorites",
                principalColumn: "Id");
        }
    }
}
