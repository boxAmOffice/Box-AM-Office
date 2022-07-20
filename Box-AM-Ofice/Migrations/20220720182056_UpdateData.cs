using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Movies_MovieId",
                table: "ShoppingCartItems");

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "0e30846f-5865-46ec-8dd1-539a46de6105");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2d658b8-7fd3-4107-a410-ef0793859200", "AQAAAAEAACcQAAAAEGMov0pI4ZIfjA6OLFa5DWk0tQwisIojeTEHQtDjIX78zRE/rytTQjXw+9katkeiJQ==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "ImageURL", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 30, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(1551), "https://sultan.blob.core.windows.net/attac/life.jpg", new DateTime(2022, 7, 10, 21, 20, 54, 557, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 30, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3605), new DateTime(2022, 7, 10, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 30, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3618), new DateTime(2022, 7, 10, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 30, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3628), new DateTime(2022, 7, 10, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 25, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3639), new DateTime(2022, 7, 15, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 28, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3649), new DateTime(2022, 7, 13, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 27, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 7, 18, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 3, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 7, 6, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 2, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3681), new DateTime(2022, 7, 7, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 8, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 7, 1, 21, 20, 54, 563, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Movies_MovieId",
                table: "ShoppingCartItems",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Movies_MovieId",
                table: "ShoppingCartItems");

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "ShoppingCartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "33975663-e588-40e9-b15b-fb9954da9d47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a05e6c48-5b75-4c70-a3b2-0a2bf1eddfd7", "AQAAAAEAACcQAAAAEIYrCVyZ26ZlJJJ9TAyMIAH8FmBfi8bzTkrXm5Xs9wyH+OTGCLiVzpjgpFdVCYznmw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "ImageURL", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(4875), "", new DateTime(2022, 7, 9, 22, 28, 9, 895, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6102), new DateTime(2022, 7, 9, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6110), new DateTime(2022, 7, 9, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 7, 9, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6123), new DateTime(2022, 7, 14, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 27, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 7, 12, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 26, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6135), new DateTime(2022, 7, 17, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 2, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6141), new DateTime(2022, 7, 5, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 1, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6147), new DateTime(2022, 7, 6, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 8, 7, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6153), new DateTime(2022, 6, 30, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Movies_MovieId",
                table: "ShoppingCartItems",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
