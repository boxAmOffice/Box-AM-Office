using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class AddAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad376a8ff", "abcbe9c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcbe9c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad376a8f", "b0f091c9-ad7d-4851-b3d5-dc94025416f1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0", 0, "3eb4c1cb-e457-4194-a10e-0daa458a2b16", "admin@gmail.com", false, null, false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEKotMXGTDFdLD6v8+GSvUiejB21hbsIvVim11qXdPRJAetBRxjsJdJnHGxBvxSssGg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 9, 22, 909, DateTimeKind.Local).AddTicks(7935), new DateTime(2022, 7, 9, 1, 9, 22, 907, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 9, 22, 909, DateTimeKind.Local).AddTicks(9481), new DateTime(2022, 7, 9, 1, 9, 22, 909, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 9, 22, 909, DateTimeKind.Local).AddTicks(9489), new DateTime(2022, 7, 9, 1, 9, 22, 909, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad376a8f", "a18be9c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad376a8f", "a18be9c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad376a8ff", "add6e118-7824-449d-837c-d0b38ed33805", "Administrator", "Admin" },
                    { "administrator", "00000000-0000-0000-0000-000000000000", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abcbe9c0", 0, "223e0f22-bc1e-466c-9e5f-74745394d8a4", "admin@gmail.com", false, null, false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAENooQ8xUorA5VOiPgRV/xz/jjrmwxntSUNt7cbnT3bAPEm6LaCRQ5mqSIu7dY7xbyw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 7, 14, 72, DateTimeKind.Local).AddTicks(2522), new DateTime(2022, 7, 9, 1, 7, 14, 69, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 7, 14, 72, DateTimeKind.Local).AddTicks(3812), new DateTime(2022, 7, 9, 1, 7, 14, 72, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 7, 14, 72, DateTimeKind.Local).AddTicks(3820), new DateTime(2022, 7, 9, 1, 7, 14, 72, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad376a8ff", "abcbe9c0" });
        }
    }
}
