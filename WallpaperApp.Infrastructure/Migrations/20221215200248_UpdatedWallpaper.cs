using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class UpdatedWallpaper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6b7cd92-c4c2-43a4-9284-5c7fa65331d3", "AQAAAAEAACcQAAAAEJrioeeaWj8jbvApWdliKCKd6HOKiqhmboGCWHq/2eodXkr7kWsOUYAjrr/gjyb9+g==", "7764263d-40af-4edc-b91b-58d05c08dbdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1886d3e-6e57-458c-b508-1ca21be05db4", "AQAAAAEAACcQAAAAEEjR84XO2Ntp5lzhCp6yFen+GllubfreXHKbdjbq0dRHQ2d7/6Vy/6OvLXyOQHf4sQ==", "c41d9cb3-8050-4aed-97e6-a426e99ac362" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 15, 22, 2, 47, 620, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 15, 22, 2, 47, 620, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 15, 22, 2, 47, 620, DateTimeKind.Local).AddTicks(795));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
