using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class UpdatingApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "798014f5-15f7-4297-b20f-29cf8216d682", "AQAAAAEAACcQAAAAECin7+fLhcJJfMchc3L/TtDSGCTwCsVzpvJe7Xl+DPCfzrTlmB7zkEWoVpFw/tjIwA==", "6a1f1cc1-0f39-4edb-8e83-b543f1447591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6343353d-5a53-4931-8d7a-1bab67cbee05", "AQAAAAEAACcQAAAAEF1FB/+zhkNb0axeT49F9onMYy8NB7+uBuTDXr5qo47cnpBMs6cquKnF5Yz0yE/fEQ==", "be80aa02-9603-4fc1-bffb-8d802b6dd6cc" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 7, 17, 473, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 7, 17, 473, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 7, 17, 473, DateTimeKind.Local).AddTicks(9023));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "985ee7ea-614e-40dc-bf90-c493eb317018", "AQAAAAEAACcQAAAAEJpq9d+1dSdNg/d2is/cy1+1RUDolEFHuU7MRHxmihuIBrWW/iouamml7f0PtJz20A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e53f8e0d-1cf9-45a8-a391-733e24054b6d", "AQAAAAEAACcQAAAAEE0vvkX112kGEPkY4WmvLL8GUkQqPTKNPZ40Xk6kWRL71MA/6nN4t0ktXjxeCfgHoQ==", null });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 6, 3, 751, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 6, 3, 751, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 15, 21, 6, 3, 751, DateTimeKind.Local).AddTicks(1589));
        }
    }
}
