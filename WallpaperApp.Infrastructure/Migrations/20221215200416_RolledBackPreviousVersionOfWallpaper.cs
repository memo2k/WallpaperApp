using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class RolledBackPreviousVersionOfWallpaper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d316d9-7799-4ba6-a1f7-431aee141159", "AQAAAAEAACcQAAAAEF4b0hiwLVmD7LX0A/yab9fCZMmsYxcl8/oRSeBgUBhHhe5J8ugJo84U9ZE1qHrABg==", "0d574978-6af8-421d-8a82-78033d4a248b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e2d0df9-48dd-40de-b4c3-97f3e5c70447", "AQAAAAEAACcQAAAAEJf/9cmSPCdYqI4jn+6jXwHOzPNiWtXku4KJHDBwQnqqDbrllo6XHAzsInjdN/dcTQ==", "cc24236c-6834-441d-a338-77668bba32ae" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 15, 22, 4, 15, 668, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 15, 22, 4, 15, 668, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 15, 22, 4, 15, 668, DateTimeKind.Local).AddTicks(4626));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
