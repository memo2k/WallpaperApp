using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class AddedVerifiedUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3696a3e3-1e0d-4193-b257-de5454c3d7a7", "AQAAAAEAACcQAAAAEMaxGxs4o2raxSTCBfmBlFWk2g42yFvyC1tyNghyWGBqbLVfvbDJj8BXGdRpH+Y1Fw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37ab0eb2-313b-4955-9be0-cc1565a9099f", "AQAAAAEAACcQAAAAECbxlOu/yCOtaAfpdvid1l0nmUSQmflmpFC4B+EmEcnXnfpZ8w0CO9h2J5Pau4W4Mg==", null });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 41, 54, 517, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 41, 54, 517, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 41, 54, 517, DateTimeKind.Local).AddTicks(215));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf4871f-9477-4d86-a7e9-a83fef9c0f00", "Dimitar", "Petrov", "AQAAAAEAACcQAAAAENaDd2KOv8xTeK3eANDSmrsAu1Hup/kGQxdEI8B8eT6y0W3zNEqZ8ILmhD9iBbY+4g==", "e9e6dc79-ccbd-49f9-93cb-ecfef960ab26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7d2f353-c940-4576-925f-bbe471185cdc", "Georgi", "Ivanov", "AQAAAAEAACcQAAAAEEZopzq6e1YRRsVlTVp4hgX5p35S5ZWT6X26lUKpxrN2qG3Y2vXbP5TJnfroJpS6qQ==", "99fdd4de-0fca-46c8-83fd-694208724090" });

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
    }
}
