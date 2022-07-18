using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class ChangeAdminToAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58a4c974-e61b-4e8b-ab8a-fa769ede1ef3", "Administrator", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "148dbce7-0913-4db4-9d7e-1660c2c0c59b", "AQAAAAEAACcQAAAAENdBHPdLSPoOBflYPaGnjWd997MMgJiRVOKMI6LYtKCpfuFfZKlePXzdfsZvs2Uxwg==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 19, 0, 50, DateTimeKind.Local).AddTicks(227), new DateTime(2022, 7, 9, 1, 19, 0, 47, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 19, 0, 50, DateTimeKind.Local).AddTicks(1800), new DateTime(2022, 7, 9, 1, 19, 0, 50, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 19, 0, 50, DateTimeKind.Local).AddTicks(1812), new DateTime(2022, 7, 9, 1, 19, 0, 50, DateTimeKind.Local).AddTicks(1805) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0f091c9-ad7d-4851-b3d5-dc94025416f1", "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eb4c1cb-e457-4194-a10e-0daa458a2b16", "AQAAAAEAACcQAAAAEKotMXGTDFdLD6v8+GSvUiejB21hbsIvVim11qXdPRJAetBRxjsJdJnHGxBvxSssGg==" });

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
        }
    }
}
