using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class RemovedWallpaperIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Wallpapers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9be9eef1-f8e5-4194-83cc-327dd345da33", "AQAAAAEAACcQAAAAEEMcYVDs+iczXy+EbH/hkT0q3ylv9RkNLC84Inyv15+jXT4p1aUh7gEVX7THJxaJ1g==", "11c29ad5-ff9b-4f89-8102-6fa59cf41bb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f8158bc-4de4-4b6e-a5fe-f0566a1fcc78", "AQAAAAEAACcQAAAAEPhXi0BBGg16yASgwT0BZ1nwiUUyi5jCoZ3xYFp3U+laNlEGS85sb4aBwlgbeLPF2Q==", "0eaa1305-2bcc-4e4e-ba7d-86f9ce382352" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 20, 23, 51, 59, 815, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 20, 23, 51, 59, 815, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 20, 23, 51, 59, 815, DateTimeKind.Local).AddTicks(3537));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Wallpapers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dafd275b-5a1d-4aef-a1e1-9924aabceb8e", "AQAAAAEAACcQAAAAENUclRBEVqoz2qRNI1pGbhwClV5M2MsiimNrMRjqZKKvwm1xKTu/7O/qv0F4xQLdnw==", "b3572599-6c68-4112-b5d2-5265da1ace95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "633a5834-a635-491a-9f7e-e17890c1c397", "AQAAAAEAACcQAAAAEEShNTvBlOaJZUfPkmccGK901UnMd19C571TySCXi4fxbcg4cdcKrb8nAbue6wkvHg==", "98d74002-d143-446a-ac8a-63b82dc8faa7" });

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
    }
}
