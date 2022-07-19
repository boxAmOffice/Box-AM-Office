using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "dcf1f1f1-e34c-4642-b07b-36102711e643");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "646dfbd4-866e-4967-bca1-2b3d98b37729", "AQAAAAEAACcQAAAAEF4Bkex3hmXg9AGFRvCXXKegvihubkPc8ZNBXt8RgmBBbWoO3hicrmDFirQItqtGFw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 21, 20, 176, DateTimeKind.Local).AddTicks(5399), new DateTime(2022, 7, 9, 20, 21, 20, 171, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 21, 20, 176, DateTimeKind.Local).AddTicks(8331), new DateTime(2022, 7, 9, 20, 21, 20, 176, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 20, 21, 20, 176, DateTimeKind.Local).AddTicks(8345), new DateTime(2022, 7, 9, 20, 21, 20, 176, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[] { 4, 3, "A bookish marmoset embarks on a wild adventure to travel around the planet in 80 days after accepting a challenge from a greedy frog.", new DateTime(2022, 7, 29, 20, 21, 20, 176, DateTimeKind.Local).AddTicks(8355), "https://sultan.blob.core.windows.net/attac/Around-the-World-in-80-Days.jpg", 1, "Around the World in 80 Days", 22.989999999999998, 2, new DateTime(2022, 7, 9, 20, 21, 20, 176, DateTimeKind.Local).AddTicks(8351) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b826361-f477-4f1b-bd2e-52859de1ae4c", "AQAAAAEAACcQAAAAEIpK0NNYx0U9xm5c0tUr/IR2Vm1WONJllnLlx2q1YTcRmqRLRgBKqP6holAdh07dWQ==" });

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
    }
}
