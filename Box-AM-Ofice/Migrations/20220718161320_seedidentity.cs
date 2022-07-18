using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class seedidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd586a8ff", "abcze710" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd586a8ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcze710");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8ff",
                column: "ConcurrencyStamp",
                value: "7a33ac2a-a550-464d-b4cb-0d89d5ffbf8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcbe9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fa7a8d0-c287-420b-b596-ef18497e686b", "AQAAAAEAACcQAAAAENZT64rBbjzvE20q3vuujJdeBuP3irKnN9mjOfhY4dOfSPxx7R9ehZGgx2opTI7bnQ==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 28, 19, 13, 19, 271, DateTimeKind.Local).AddTicks(2781), new DateTime(2022, 7, 8, 19, 13, 19, 260, DateTimeKind.Local).AddTicks(9598) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8ff",
                column: "ConcurrencyStamp",
                value: "d4b7c1de-56da-466c-b102-50390098242b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd586a8ff", "33b73b8b-31f4-40f3-bc27-f0b96405aa7f", "Editor", "EDITOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcbe9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f92c4338-4f86-4579-b2e9-416bdae1dd3f", "AQAAAAEAACcQAAAAEBOF4chYAt3046hUauUmWDQl5ys5MbIZB0UO3uptkR56HPMZVN1iX5mEjJgaxmO65w==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abcze710", 0, "572f6b75-fca1-4950-ac05-c7fe22f3ad1d", "editor@gmail.com", false, false, null, "editor@gmail.com", "editor", "AQAAAAEAACcQAAAAEKFqSRQ7J+XJZ6nCn1djBqpmD9B1ZjGzG8GkvsAth/Bhh988YBl+V6GFz3S2YE7isA==", null, false, "", false, "editor" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 28, 19, 9, 24, 79, DateTimeKind.Local).AddTicks(3818), new DateTime(2022, 7, 8, 19, 9, 24, 49, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd586a8ff", "abcze710" });
        }
    }
}
