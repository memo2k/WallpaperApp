using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class changedWallpaperData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "998d2d31-4b0e-4705-9a19-a3a54461c462", "AQAAAAEAACcQAAAAEFeqAFq8wE/A+LvMmxQbjiXvBtJ+tsVPRlxtXVG53MXYvqoZMWVwP08dMFZK2XZEiw==", "3dfdc703-e81a-452c-b05b-c8227a7ab4ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a7ab51c-fba0-449b-9184-82cd63ca37e7", "AQAAAAEAACcQAAAAEM6sfOmbSU+uRvEqu1hm1bnQRdY+mVVe9s4KIRnQXiGezt2KlWuQNnQTiqdDJCNejg==", "4617cb36-ae31-4d9d-b160-9cb26fd21992" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 13, 19, 15, 51, 156, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 13, 19, 15, 51, 156, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 13, 19, 15, 51, 156, DateTimeKind.Local).AddTicks(7896));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
