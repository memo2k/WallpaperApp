using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class AddedVerifiedUsersModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "VerifiedUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "VerifiedUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25fb9737-d1c7-4d67-aeca-fccc8c70515d", "AQAAAAEAACcQAAAAEPAA/IGJdyU9R76MO4J9/h2FC8B++CN57Fs+ISTP+yK7iSibtdaMvI7gWYMjCLVVrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "646ad4d0-747b-44fd-a866-43410eb28e0b", "AQAAAAEAACcQAAAAEAV6Wi5iAU1LW5WV1A0wVSawZvHfrfeyrhn/EnM+uBQRjhqQxc9IAeVPw6Dhwcdivg==" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 46, 30, 950, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 46, 30, 950, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 46, 30, 950, DateTimeKind.Local).AddTicks(8852));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "VerifiedUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "VerifiedUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "771d17d9-6eb6-4a86-97f9-560a7b5229ff", "AQAAAAEAACcQAAAAEJQ1pqED14UVCTRUosasbTLofRRpDuy4WJbiw9cMtQ+Dlp0x8IOcM4BeaZ8ze0fcNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75fdfd4a-af79-405f-9227-062c31efa4ab", "AQAAAAEAACcQAAAAEIkK7YonY0ZPZP9uBO2Lr6gaqvCzm1XKa1TkTWvK2TpJjeEndFkdXdDs2dp9SETHiw==" });

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 43, 53, 970, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 43, 53, 970, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Wallpapers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 12, 14, 16, 43, 53, 970, DateTimeKind.Local).AddTicks(2356));
        }
    }
}
