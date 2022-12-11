using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class seeddbFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "3a08c941-54df-4330-9b0e-c18d0db60155", "wauser2@mail.com", "AQAAAAEAACcQAAAAEN48ytZPZimHXSEOI92F2wzOwsTKK6IlUH6weWUmyfFELFYU45PW7nXVEnCzfe+xnQ==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "1e8257ef-9ee2-4c1f-99ba-87c706711c02", "wauser2mail.com", "AQAAAAEAACcQAAAAEJtqMZHcSuO7sKz3Ugwci00D5FT+ztpbEkIyUXEe9Xi3s4lEeCGBBUtOHEWU8VBZLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e2e7c3b-9014-46a6-b03e-aef0512035ab", "AQAAAAEAACcQAAAAEI4/VahM8BY9+NTDSexy8N9sWieVZI1/87QL7dhxL7dB0kqOPilUiZioOJog/sHkMw==" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 8, 19, 24, 3, 287, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 8, 19, 24, 3, 287, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 8, 19, 24, 3, 287, DateTimeKind.Local).AddTicks(687));
        }
    }
}
