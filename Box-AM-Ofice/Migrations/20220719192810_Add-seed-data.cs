using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class Addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 7, "Thomas Cruise Mapother IV(born July 3, 1962) is an American actor and producer.One of the world's highest-paid actors,[1] he has received various accolades.", "Thomas Cruise", "https://sultan.blob.core.windows.net/attac/Tom-Cruise.jpg" },
                    { 16, "Christopher Hemsworth AM is an Australian actor. He rose to prominence playing Kim Hyde in the Australian television series Home and Away before beginning a film career in Hollywood.", "Chris Hemsworth", "https://sultan.blob.core.windows.net/attac/Chris-Hemsworth.jpg" },
                    { 15, "Tony Leung Chiu-wai (Chinese: 梁朝偉, born 27 June 1962) is a Hong Kong actor and singer. He is one of Asia's most successful and internationally recognized actors, and was named as Small Tiger among the Five Tiger Generals of TVB.", "Tony Leung Chiu-wai", "https://sultan.blob.core.windows.net/attac/Tony-Leung-Chiu-wai.jpg" },
                    { 14, "Simu Liu (/ˈsimu ˈlijuː/ SEE-moo LEE-ew;[2] Chinese: 刘思慕; born 19 April 1989) is a Canadian actor, author, and stuntman. He is known for portraying Shang-Chi in the 2021 Marvel Cinematic Universe film Shang-Chi and the Legend of the Ten Rings..", "Simu iu", "https://sultan.blob.core.windows.net/attac/Simu-iu.jpg" },
                    { 13, "Timothy Allen Dick was born on June 13, 1953, in Denver, Colorado, to Martha Katherine (Fox) and Gerald M. Dick. ", "Tim Allen (I)", "https://sultan.blob.core.windows.net/attac/Tim-Allen.jpg" },
                    { 17, "Taika David Cohen ONZM, known professionally as Taika Waititi, is a New Zealand filmmaker, actor, and comedian. He is a recipient of an Academy Award, a BAFTA Award, and a Grammy Award, and has received two nominations at the Primetime Emmy Awards.", "Taika Waititi", "https://sultan.blob.core.windows.net/attac/Taika-Waititi.jpg" },
                    { 11, "Steven Allan Spielberg (/ˈspiːlbɜːrɡ/; born December 18, 1946) is an American film director, producer, and screenwriter.[1] A figure of the New Hollywood era, he is the most commercially successful director of all time. ", "Steven Spielberg", "https://sultan.blob.core.windows.net/attac/Steven-Spielberg.jpg" },
                    { 10, "Sam Neill was born in Omagh, Co. Tyrone, Northern Ireland, to army parents, an English-born mother, Priscilla Beatrice (Ingham), and a New Zealand-born father, Dermot Neill.", "Sam Neill", "https://sultan.blob.core.windows.net/attac/Sam-Neill.jpg" },
                    { 9, "Jeffrey Lynn Goldblum (/ˈɡoʊldbluːm/; born October 22, 1952) is an American actor and musician. He has starred in some of the highest-grossing films of his era, such as Jurassic Park (1993) and Independence Day (1996), as well as their sequels.", "Jeff Goldblum", "https://sultan.blob.core.windows.net/attac/Jeff-Goldblum.jpg" },
                    { 8, "Irving Rameses Ving Rhames is an American actor. He is best known for his starring role as IMF Agent Luther Stickell in the Mission: Impossible film series and his supporting role as gang kingpin Marsellus Wallace in Pulp Fiction", "Irving Rameses", "https://sultan.blob.core.windows.net/attac/Irving-Rameses.jpg" },
                    { 12, "Thomas Jeffrey Hanks was born in Concord, California, to Janet Marylyn (Frager), a hospital worker, and Amos Mefford Hanks, an itinerant cook. His mother's family, originally surnamed Fraga, was entirely Portuguese, while his father was of mostly English ancestry.", "Tom Hanks", "https://sultan.blob.core.windows.net/attac/Tom-Hanks.jpg" }
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
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(4875), new DateTime(2022, 7, 9, 22, 28, 9, 895, DateTimeKind.Local).AddTicks(47) });

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

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 3, "Wagner was born Paula Sue Kauffman in Youngstown, Ohio. Her mother, Sue Anna (née Shofstall), was a news magazine editor from Oklahoma, and her father, Edmund Jamison Ned Kauffman, Jr., was a business owner.", "Paula Wagner", "https://sultan.blob.core.windows.net/attac/Paula-Wagner-Deauville.png" },
                    { 4, "Frank Wilton Marshall (born September 13, 1946) is an American film producer and director. He often collaborates with his wife, film producer Kathleen Kennedy. ", "Frank Marshall", "https://sultan.blob.core.windows.net/attac/Frank-Marshall.jpg" },
                    { 5, "Larry Joseph Franco (born April 5, 1949) is an American film producer. He has also served as an actor, second unit director and assistant director.", "Larry Franco", "https://sultan.blob.core.windows.net/attac/Larry-Franco.jpg" },
                    { 6, "Ralph Guggenheim is an American video graphics designer and film producer. He won a Producers Guild of America Award in 1995 for his contributions to the film Toy Story..", "Ralph Guggenheim", "https://sultan.blob.core.windows.net/attac/Ralph-Guggenheim.jpg" },
                    { 7, "Kevin Feige is an American film and television producer who has been the president of Marvel Studios and the primary producer of the Marvel Cinematic Universe franchise since 2007.", "Kevin Feige", "https://sultan.blob.core.windows.net/attac/Kevin-Feige.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 5, 3, "An American agent, under false suspicion of disloyalty, must discover and expose the real spy without the help of his organization.", new DateTime(2022, 7, 24, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6123), "https://sultan.blob.core.windows.net/attac/Mission-Impossible.png", 1, "Mission: Impossible", 26.989999999999998, 3, new DateTime(2022, 7, 14, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6119) },
                    { 6, 3, "Four years after the destruction of Isla Nublar, dinosaurs now live--and hunt--alongside humans all over the world.", new DateTime(2022, 7, 27, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6129), "https://sultan.blob.core.windows.net/attac/Jurassic-World-Dominion.jpg", 1, "Jurassic World Dominion", 10.99, 4, new DateTime(2022, 7, 12, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6127) },
                    { 7, 2, "A decidedly odd couple with ulterior motives convince Dr. Grant to go to Isla Sorna for a holiday, but their unexpected landing startles the island's new inhabitants..", new DateTime(2022, 7, 26, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6135), "https://sultan.blob.core.windows.net/attac/Jurassic-Park-III.jpg", 1, "Jurassic Park III", 30.989999999999998, 5, new DateTime(2022, 7, 17, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6133) },
                    { 8, 1, "A cowboy doll is profoundly threatened and jealous when a new spaceman action figure supplants him as top toy in a boy's bedroom.", new DateTime(2022, 8, 2, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6141), "https://sultan.blob.core.windows.net/attac/Toy-Story.jpg", 2, "Toy Story", 10.99, 6, new DateTime(2022, 7, 5, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6139) },
                    { 9, 1, "Shang-Chi, the master of weaponry-based Kung Fu, is forced to confront his past after being drawn into the Ten Rings organization..", new DateTime(2022, 8, 1, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6147), "https://sultan.blob.core.windows.net/attac/Shang-Chi.jpg", 1, "Shang-Chi and the Legend of the Ten Rings", 25.989999999999998, 7, new DateTime(2022, 7, 6, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6145) },
                    { 10, 2, "A bookish marmoset embarks on a wild adventure to travel around the planet in 80 days after accepting a challenge from a greedy frog.", new DateTime(2022, 8, 7, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6153), "https://sultan.blob.core.windows.net/attac/Thor-Ragnarok.jpg", 1, "Thor: Ragnarok", 25.989999999999998, 7, new DateTime(2022, 6, 30, 22, 28, 9, 897, DateTimeKind.Local).AddTicks(6150) }
                });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 7, 5 },
                    { 8, 5 },
                    { 9, 6 },
                    { 10, 6 },
                    { 10, 7 },
                    { 11, 7 },
                    { 12, 8 },
                    { 13, 8 },
                    { 14, 9 },
                    { 15, 9 },
                    { 16, 10 },
                    { 17, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "a621b7bb-faed-4d37-b47c-30b65d5484d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3158ee9-368e-416a-80b2-0d68e0013bb4", "AQAAAAEAACcQAAAAEJqNfpcg0W87iA9lo5v/HP18T5Eu6Zrf531ZN+0jEMxADhlnlhYFpoW9PBcd/AjsCw==" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 21, 0, 52, 855, DateTimeKind.Local).AddTicks(8996), new DateTime(2022, 7, 9, 21, 0, 52, 853, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(251), new DateTime(2022, 7, 9, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(259), new DateTime(2022, 7, 9, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 7, 29, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(265), new DateTime(2022, 7, 9, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(262) });
        }
    }
}
