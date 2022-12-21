using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class WallpaperIsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Wallpapers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "af1655fc-d628-46ba-b9c8-932074f05919", "AQAAAAEAACcQAAAAEAEQtMijQ7NRcvqSHEN4UszQsVz7xfJdCuU2lU54tuzgd/6WVWlB3wcV4b2p9cS4HA==", "417f6a27-60f6-4f2f-8022-c03fd8ff3e69" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "a356d901-f1f0-4ff3-89b1-3088b7d4594a", "AQAAAAEAACcQAAAAEG6OdUYsHzA8CCfV8lK4dwAgSaCbIf8YqwM8FER2b80Ihiseg0B4WK+ITkVcKdT9Zg==", "ecf4a277-2899-44b8-aeac-af44784e92af" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 40, 40, 285, DateTimeKind.Local).AddTicks(7344), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 40, 40, 285, DateTimeKind.Local).AddTicks(7381), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 10, 40, 40, 285, DateTimeKind.Local).AddTicks(7384), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Wallpapers");

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
    }
}
