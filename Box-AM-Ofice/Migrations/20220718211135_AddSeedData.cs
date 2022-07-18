using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "FullName", "ProfilePictureURL" },
                values: new object[] { "Is an American actor and comedian", "Steven John", "https://sultan.blob.core.windows.net/attac/StevenJohn.jpg" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 2, "Is an Belgian actor", "Van Damme", "https://sultan.blob.core.windows.net/attac/Van_Damme.jpg" },
                    { 3, "Is an American actress and singer", "Taraji Penda Henson", "https://sultan.blob.core.windows.net/attac/Taraji_Henson.jpg" },
                    { 4, "Kristina Asmus was born Kristina Igorevna Myasnikova on April 14, 1988, in Kaliningrad", "Kristina Asmus", "https://sultan.blob.core.windows.net/attac/Kristina_Asmus.jpg" },
                    { 5, "alil Asretov was born on February 26, 1994 in Makhachkala, Republic of Dagestan, Russia.", "Jalil Asretov", "https://sultan.blob.core.windows.net/attac/Jalil_Asretov.png" },
                    { 6, "Sergey Borisov was born on April 4, 1975 in the USSR. He is an actor", "Sergey Borisov", "https://sultan.blob.core.windows.net/attac/Sergey_Borisov.png" }
                });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Logo", "Name" },
                values: new object[] { "TAJ Cinemas is the first to introduce the latest in high-tech services to movie-goers such as an online ticketing function to avoid queues", "https://sultan.blob.core.windows.net/attac/Taj.png", "Taj Cinemas" });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 2, "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!", "https://sultan.blob.core.windows.net/attac/Prime.png", "Prime Cinemas Abdali" },
                    { 3, "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!", "https://sultan.blob.core.windows.net/attac/Prime.png", "Prime Cinemas Irbid" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 0, 11, 34, 329, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 7, 9, 0, 11, 34, 320, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "FullName", "ProfilePictureURL" },
                values: new object[] { "Kyle Balda is a BAFTA nominated feature animation director working in the industry for 30 years", "Kyle Balda", "https://sultan.blob.core.windows.net/attac/Kyle_Balda.jpg" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[] { 2, "Aleksey Aleksandrovich Chadov was born on September 2, 1981, in Solntsevo, Moscow region, RSFSR, USSR, now a suburb of Moscow, Russia.", "Aleksey Chadov", "https://sultan.blob.core.windows.net/attac/Chadov_Aleksey.jpg" });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 2, 2, "The untold story of one twelve-year-old's dream to become the world's greatest supervillain.", new DateTime(2022, 7, 29, 0, 11, 34, 329, DateTimeKind.Local).AddTicks(4373), "https://sultan.blob.core.windows.net/attac/Minions.jpg", 2, "Minions: The Rise of Gru", 25.989999999999998, 1, new DateTime(2022, 7, 9, 0, 11, 34, 329, DateTimeKind.Local).AddTicks(4338) },
                    { 3, 3, "Ivan sets off on a dangerous mission into Syria to save his ex-commander Grey after his capture by ISIS. With the help of U.S. military patrols, he succeeds in freeing Grey and attempts to escape the country while being hunted by terrorists.", new DateTime(2022, 7, 29, 0, 11, 34, 329, DateTimeKind.Local).AddTicks(4394), "https://sultan.blob.core.windows.net/attac/Infiltration.png", 1, "Infiltration", 29.989999999999998, 2, new DateTime(2022, 7, 9, 0, 11, 34, 329, DateTimeKind.Local).AddTicks(4388) }
                });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 5, 2 });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 6, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "FullName", "ProfilePictureURL" },
                values: new object[] { "This is the Bio of the first actor", "Actor 1", "" });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Logo", "Name" },
                values: new object[] { "This is the description of the first cinema", "", "Cinema 1" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 28, 11, 49, 13, 475, DateTimeKind.Local).AddTicks(8754), new DateTime(2022, 7, 8, 11, 49, 13, 469, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "FullName", "ProfilePictureURL" },
                values: new object[] { "This is the Bio of the first actor", "Producer 1", "" });
        }
    }
}
