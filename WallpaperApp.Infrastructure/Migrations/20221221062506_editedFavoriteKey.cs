using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class editedFavoriteKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Favorites");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites",
                columns: new[] { "UserId", "WallpaperId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57324e74-b8bd-462a-8e52-c98fe07186e6", "AQAAAAEAACcQAAAAEFTdiRWzZDyG9tc6HfpMSs7yYxgUfO8JCWGBenQCPv1JMczS5UJJyksYPTkq95D+QQ==", "7eacfc83-ee6a-45e5-b66a-65b5c0531e7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "278bc878-6003-4672-a367-927e569ce63c", "AQAAAAEAACcQAAAAEKfJ+5bSyvu91acidBjR3AtO2uw+q2OBig9xc2BXwSu49J4Bl2azOhhe+9qxKzrfdg==", "3edc7e8e-1379-4850-a30c-f6c405f5e347" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 25, 5, 902, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 25, 5, 902, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 25, 5, 902, DateTimeKind.Local).AddTicks(6495));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9be9eef1-f8e5-4194-83cc-327dd345da33", "AQAAAAEAACcQAAAAEEMcYVDs+iczXy+EbH/hkT0q3ylv9RkNLC84Inyv15+jXT4p1aUh7gEVX7THJxaJ1g==", "11c29ad5-ff9b-4f89-8102-6fa59cf41bb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f8158bc-4de4-4b6e-a5fe-f0566a1fcc78", "AQAAAAEAACcQAAAAEPhXi0BBGg16yASgwT0BZ1nwiUUyi5jCoZ3xYFp3U+laNlEGS85sb4aBwlgbeLPF2Q==", "0eaa1305-2bcc-4e4e-ba7d-86f9ce382352" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 23, 51, 59, 815, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 20, 23, 51, 59, 815, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 20, 23, 51, 59, 815, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");
        }
    }
}
