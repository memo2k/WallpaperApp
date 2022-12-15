using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e692eeb1-82eb-4e4d-9148-3fa4d61d7cdc", "AQAAAAEAACcQAAAAEIwi8o3F8RhZ4OsceqySGcHQ3fXIkPF1opFDyDHGKs1eheRmyK+wICIJ/bFmtxhUIA==", "8f4ed150-31f1-421d-8b90-82888eb8c310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb60f6bc-ee63-463b-add7-f92a28b6f047", "AQAAAAEAACcQAAAAEJ9cUcZb3GuLlpJn3mVT94XX1x8Q6/otzkSwW8t8NEStXBDs0LcYDXh6oHHcZyuHXQ==", "d242e6f1-e49d-44d7-ba2d-a9c53c080aa5" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 4, 21, 366, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 4, 21, 366, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 4, 21, 366, DateTimeKind.Local).AddTicks(9206));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "557b81e2-8b1e-4ccb-87d0-525364dd292d", "AQAAAAEAACcQAAAAEMLT5ZUUCnMnVBsgxP1810HcHQdsCmjhVBzo4Ra+doeQck198zISIpcz10Mh29EcOQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88c1cfba-22aa-4ab4-a767-ceae60e0edad", "AQAAAAEAACcQAAAAEJCbniLSKrkhLYD0lZaTZmn+t3UEJvUL4tFFXkguOmy5F7oTIIpyvUDcgBtjZUYxsA==", null });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 15, 20, 32, 18, 865, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 15, 20, 32, 18, 865, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 15, 20, 32, 18, 865, DateTimeKind.Local).AddTicks(6740));
        }
    }
}
