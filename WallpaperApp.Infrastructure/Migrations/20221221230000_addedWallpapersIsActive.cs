using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class addedWallpapersIsActive : Migration
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
            //    values: new object[] { "bbde95c2-e3a2-4313-a5ce-5a5b99012288", "AQAAAAEAACcQAAAAEP1lSwkYVt21STJzZ3JDdEwyyKRWmEGR/peRjj25QSso82S2se886BzxeK2UWeQMbA==", "3dbd1a89-1001-4bba-90b1-fa4ecd476ec3" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "d96e1102-e109-4c09-9b70-c242f1a5cc0f", "AQAAAAEAACcQAAAAEPR1K731xdYW+svqjd6pTSY1k1SVItXeypNZttNc9gVmkbcf/Zo/hNmlWKggGjrEsw==", "8d71b6f9-fc17-4343-a8e0-fa09aa0d083b" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 22, 0, 59, 59, 900, DateTimeKind.Local).AddTicks(2110), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 22, 0, 59, 59, 900, DateTimeKind.Local).AddTicks(2152), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 22, 0, 59, 59, 900, DateTimeKind.Local).AddTicks(2156), true });
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
                values: new object[] { "078c5b67-00a8-41d0-975e-66e8cd430671", "AQAAAAEAACcQAAAAEPySunQKTWhIXSz7ph2aU8P1afq+1w+I3q23G0d2ay0xoiY2JNH7TPh+zmz/jcx3RQ==", "5dddffc3-2dcf-4d39-921b-42f6e25c40b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a7a6952-7f69-4e78-8b65-0e01ef48bd2f", "AQAAAAEAACcQAAAAEEdC1kDtK1SyPjs5JFLL5fMj//6VET594xWqeAyOTSj+lBLA4AOC0EO7t96MAsdCQw==", "37be4047-92ef-4770-acf0-84e4b05c1fcc" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 52, 44, 718, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 52, 44, 718, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 21, 8, 52, 44, 718, DateTimeKind.Local).AddTicks(8094));
        }
    }
}
