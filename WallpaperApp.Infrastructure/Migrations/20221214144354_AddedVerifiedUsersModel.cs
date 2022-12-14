using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    public partial class AddedVerifiedUsersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VerifiedUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerifiedUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerifiedUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_VerifiedUsers_UserId",
                table: "VerifiedUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VerifiedUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3696a3e3-1e0d-4193-b257-de5454c3d7a7", "AQAAAAEAACcQAAAAEMaxGxs4o2raxSTCBfmBlFWk2g42yFvyC1tyNghyWGBqbLVfvbDJj8BXGdRpH+Y1Fw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37ab0eb2-313b-4955-9be0-cc1565a9099f", "AQAAAAEAACcQAAAAECbxlOu/yCOtaAfpdvid1l0nmUSQmflmpFC4B+EmEcnXnfpZ8w0CO9h2J5Pau4W4Mg==" });

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
    }
}
