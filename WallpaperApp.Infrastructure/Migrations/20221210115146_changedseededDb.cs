using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class changedseededDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f5800a5-1e4e-47f6-acff-242e91bbc8ed", "AQAAAAEAACcQAAAAEDBt64Py9b7eR6qhNOupIwvMqfQJVUhCj4zNZpQ5IjZBbzof6WjPbAji8kIghXTvdw==", "44de85b1-2652-4bd5-b65d-97ad0011ba99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eee6b121-7d17-4159-9dc6-d7219eb1d461", "AQAAAAEAACcQAAAAEP2neVqUo/v9tMik6MyFQeI5TKG3DQfkXmPyQMliSe4kWnZCVU3H3nucrCjTvT1gVQ==", "54360bba-2862-425e-b6bb-1b63d4de6846" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 10, 13, 51, 45, 579, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 10, 13, 51, 45, 579, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 10, 13, 51, 45, 579, DateTimeKind.Local).AddTicks(185));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a6a127d-f7f3-46d9-9d15-e9e1a68f8c69", "AQAAAAEAACcQAAAAEIUPYCwByjc3Xz8ezT86oMowEng8Z4wXHoA2cuPqZiuuVpEDhozOTzBaofzSQQt8xQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dbaa79c-7676-4413-9e61-767fe3e45b0e", "AQAAAAEAACcQAAAAEIWB4YMJaSM8JSTpjDvCgBxNYnQNY8F5jbWFO+6UdE3LFwmQtBwHzkX7szQmK7+qUg==", null });

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
    }
}
