using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class AddedWallpaperIsActive : Migration
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
            //    values: new object[] { "dafd275b-5a1d-4aef-a1e1-9924aabceb8e", "AQAAAAEAACcQAAAAENUclRBEVqoz2qRNI1pGbhwClV5M2MsiimNrMRjqZKKvwm1xKTu/7O/qv0F4xQLdnw==", "b3572599-6c68-4112-b5d2-5265da1ace95" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "633a5834-a635-491a-9f7e-e17890c1c397", "AQAAAAEAACcQAAAAEEShNTvBlOaJZUfPkmccGK901UnMd19C571TySCXi4fxbcg4cdcKrb8nAbue6wkvHg==", "98d74002-d143-446a-ac8a-63b82dc8faa7" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 23, 11, 40, 109, DateTimeKind.Local).AddTicks(2866), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 23, 11, 40, 109, DateTimeKind.Local).AddTicks(2902), true });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsActive" },
                values: new object[] { new DateTime(2022, 12, 20, 23, 11, 40, 109, DateTimeKind.Local).AddTicks(2904), true });
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
                values: new object[] { "74dc4ba8-ec0d-49d0-84ad-cf290ad4d927", "AQAAAAEAACcQAAAAEG+961E2AdOtb7Q3ajIOVx0iwzDZgPNO4noF/wg+bHMSOjqZeFcetBiBmyevU2W5DQ==", "e13ff240-474b-4b04-88a7-29787af7af88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a866910-2b2c-4f88-b75e-fbb9d4ad7e59", "AQAAAAEAACcQAAAAEGX43yfSZt3qL2lOq5TZhL7nFfRd/NM1lsiwzb/+J/LpFE2OYusQ6ZKFUmF5kazvUg==", "e1a0e589-f25b-4b9a-a6d9-5c6d7c496513" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 22, 6, 0, 723, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 20, 22, 6, 0, 723, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 20, 22, 6, 0, 723, DateTimeKind.Local).AddTicks(8473));
        }
    }
}
