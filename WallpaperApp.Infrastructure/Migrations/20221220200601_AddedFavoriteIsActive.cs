using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class AddedFavoriteIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Favorites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "74dc4ba8-ec0d-49d0-84ad-cf290ad4d927", "AQAAAAEAACcQAAAAEG+961E2AdOtb7Q3ajIOVx0iwzDZgPNO4noF/wg+bHMSOjqZeFcetBiBmyevU2W5DQ==", "e13ff240-474b-4b04-88a7-29787af7af88" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "5a866910-2b2c-4f88-b75e-fbb9d4ad7e59", "AQAAAAEAACcQAAAAEGX43yfSZt3qL2lOq5TZhL7nFfRd/NM1lsiwzb/+J/LpFE2OYusQ6ZKFUmF5kazvUg==", "e1a0e589-f25b-4b9a-a6d9-5c6d7c496513" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 22, 6, 0, 723, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 20, 22, 6, 0, 723, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 20, 22, 6, 0, 723, DateTimeKind.Local).AddTicks(8473));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Favorites");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39b00973-7aa6-437a-b5a7-7b56b2c140bd", "AQAAAAEAACcQAAAAEJYd+oA+BcLjJqv+iuOZW94ZsUgD0pfVLIkPnR05vi48U1iVAa5/fIaZ/qQuAqvGgg==", "c3e8edb9-fb07-48bf-be6b-2c0c89a4eb90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5465eb6d-7ee2-4a6e-8a78-9e12467b8bfb", "AQAAAAEAACcQAAAAEJxu/8W1wOdNfSOtsHOo0bU1yqKFOb+kA2aqIcdJ7yPHnPH14j2Cbj7inWFumpR34g==", "ef1fa568-89e8-4959-b658-4f6fa7205b04" });

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
        }
    }
}
