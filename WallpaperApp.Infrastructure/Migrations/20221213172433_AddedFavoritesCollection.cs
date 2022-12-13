using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class AddedFavoritesCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf4871f-9477-4d86-a7e9-a83fef9c0f00", "AQAAAAEAACcQAAAAENaDd2KOv8xTeK3eANDSmrsAu1Hup/kGQxdEI8B8eT6y0W3zNEqZ8ILmhD9iBbY+4g==", "e9e6dc79-ccbd-49f9-93cb-ecfef960ab26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d2f353-c940-4576-925f-bbe471185cdc", "AQAAAAEAACcQAAAAEEZopzq6e1YRRsVlTVp4hgX5p35S5ZWT6X26lUKpxrN2qG3Y2vXbP5TJnfroJpS6qQ==", "99fdd4de-0fca-46c8-83fd-694208724090" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 13, 19, 24, 33, 180, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 13, 19, 24, 33, 180, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 13, 19, 24, 33, 180, DateTimeKind.Local).AddTicks(274));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
