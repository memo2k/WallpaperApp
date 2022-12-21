using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class addedLikeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Wallpapers");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WallpaperId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.UserId, x.WallpaperId });
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likes_Wallpapers_WallpaperId",
                        column: x => x.WallpaperId,
                        principalTable: "Wallpapers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "078c5b67-00a8-41d0-975e-66e8cd430671", "AQAAAAEAACcQAAAAEPySunQKTWhIXSz7ph2aU8P1afq+1w+I3q23G0d2ay0xoiY2JNH7TPh+zmz/jcx3RQ==", "5dddffc3-2dcf-4d39-921b-42f6e25c40b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a7a6952-7f69-4e78-8b65-0e01ef48bd2f", "AQAAAAEAACcQAAAAEEdC1kDtK1SyPjs5JFLL5fMj//6VET594xWqeAyOTSj+lBLA4AOC0EO7t96MAsdCQw==", "37be4047-92ef-4770-acf0-84e4b05c1fcc" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 52, 44, 718, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 52, 44, 718, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 52, 44, 718, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.CreateIndex(
                name: "IX_Likes_WallpaperId",
                table: "Likes",
                column: "WallpaperId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Wallpapers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Date", "Likes" },
                values: new object[] { new DateTime(2022, 12, 21, 8, 25, 5, 902, DateTimeKind.Local).AddTicks(6449), 2 });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Likes" },
                values: new object[] { new DateTime(2022, 12, 21, 8, 25, 5, 902, DateTimeKind.Local).AddTicks(6491), 4 });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Likes" },
                values: new object[] { new DateTime(2022, 12, 21, 8, 25, 5, 902, DateTimeKind.Local).AddTicks(6495), 1 });
        }
    }
}
