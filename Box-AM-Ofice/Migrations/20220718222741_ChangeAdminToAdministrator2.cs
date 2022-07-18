using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class ChangeAdminToAdministrator2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "5188fbb1-6d15-4c60-82d6-9d53dc6fbe57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "5b826361-f477-4f1b-bd2e-52859de1ae4c", "Administrator@gmail.com", "Administrator@gmail.com", "Administrator", "AQAAAAEAACcQAAAAEIpK0NNYx0U9xm5c0tUr/IR2Vm1WONJllnLlx2q1YTcRmqRLRgBKqP6holAdh07dWQ==", "Administrator" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 27, 39, 927, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 7, 9, 1, 27, 39, 924, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 27, 39, 927, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 7, 9, 1, 27, 39, 927, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 1, 27, 39, 927, DateTimeKind.Local).AddTicks(3118), new DateTime(2022, 7, 9, 1, 27, 39, 927, DateTimeKind.Local).AddTicks(3115) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "58a4c974-e61b-4e8b-ab8a-fa769ede1ef3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "148dbce7-0913-4db4-9d7e-1660c2c0c59b", "admin@gmail.com", "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAENdBHPdLSPoOBflYPaGnjWd997MMgJiRVOKMI6LYtKCpfuFfZKlePXzdfsZvs2Uxwg==", "admin" });

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
    }
}
