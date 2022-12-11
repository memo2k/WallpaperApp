using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class seededdbchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a6a127d-f7f3-46d9-9d15-e9e1a68f8c69", "AQAAAAEAACcQAAAAEIUPYCwByjc3Xz8ezT86oMowEng8Z4wXHoA2cuPqZiuuVpEDhozOTzBaofzSQQt8xQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dbaa79c-7676-4413-9e61-767fe3e45b0e", "AQAAAAEAACcQAAAAEIWB4YMJaSM8JSTpjDvCgBxNYnQNY8F5jbWFO+6UdE3LFwmQtBwHzkX7szQmK7+qUg==" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 10, 12, 53, 4, 476, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 10, 12, 53, 4, 476, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 10, 12, 53, 4, 476, DateTimeKind.Local).AddTicks(4632));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a08c941-54df-4330-9b0e-c18d0db60155", "AQAAAAEAACcQAAAAEN48ytZPZimHXSEOI92F2wzOwsTKK6IlUH6weWUmyfFELFYU45PW7nXVEnCzfe+xnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "133e8d10-145b-4904-b94c-3bd270438306", "AQAAAAEAACcQAAAAELCJW8YYu/ZK2KxEXri8P9fCJ5MluL34nnBiyaXA/usQ2kkrVgQqU7PQoS6mFb4p1g==" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 10, 12, 31, 1, 665, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 10, 12, 31, 1, 665, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 10, 12, 31, 1, 665, DateTimeKind.Local).AddTicks(3065));
        }
    }
}
