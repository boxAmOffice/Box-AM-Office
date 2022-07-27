using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Box_AM_Ofice.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieCategory = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors_Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors_Movies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_Actors_Movies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actors_Movies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 15, "Tony Leung Chiu-wai (born 27 June 1962) is a Hong Kong actor and singer. He is one of Asia's most successful and internationally recognized actors", "Tony Leung Chiu-wai", "https://sultan.blob.core.windows.net/attac/TonyLeung.jpg" },
                    { 17, "Taika David Cohen , known professionally as Taika Waititi, is a New Zealand filmmaker, actor, and comedian", "Taika Waititi", "https://sultan.blob.core.windows.net/attac/TaikaWaititi.jfif" },
                    { 16, "Christopher Hemsworth AM is an Australian actor. He rose to prominence playing Kim Hyde in the Australian television series Home and Away before beginning a film career in Hollywood.", "Chris Hemsworth", "https://sultan.blob.core.windows.net/attac/Chris-Hemsworth.jpg" },
                    { 20, "أيتن عامر (22 نوفمبر 1986-)، ممثلة مصرية", "أيتن عامر", "https://sultan.blob.core.windows.net/attac/Aiten.jpeg" },
                    { 14, "Simu Liu is a Canadian actor, author, and stuntman", "Simu iu", "https://sultan.blob.core.windows.net/attac/SimuLiu.jpg" },
                    { 13, "Timothy Alan Dick (born June 13, 1953), known professionally as Tim Allen, is an American actor and comedian", "Tim Allen", "https://sultan.blob.core.windows.net/attac/TimAllen.jpg" },
                    { 12, "Thomas Jeffrey Hanks (born July 9, 1956) is an American actor and filmmaker", "Tom Hanks", "https://sultan.blob.core.windows.net/attac/TomHanks.jpg" },
                    { 11, "Steven Allan Spielberg (born December 18, 1946) is an American film director, producer, and screenwriter", "Steven Spielberg", "https://sultan.blob.core.windows.net/attac/Steven_Spielberg.jpg" },
                    { 10, "Sam Neill was born in Omagh, Co. Tyrone, Northern Ireland, to army parents, an English-born mother, Priscilla Beatrice (Ingham)", "Sam Neill", "https://sultan.blob.core.windows.net/attac/SamNeill.jpg" },
                    { 18, "ممثل مصري. وهو نجل الفنان عادل إمام وشقيق المخرج رامي إمام", "محمد امام", "https://sultan.blob.core.windows.net/attac/MEmam.jpg" },
                    { 9, "Jeffrey Lynn Goldblum (born October 22, 1952) is an American actor and musician.", "Jeff Goldblum", "https://sultan.blob.core.windows.net/attac/JeffGoldblum.jfif" },
                    { 7, "Thomas Cruise Mapother IV(born July 3, 1962) is an American actor and producer", "Thomas Cruise", "https://sultan.blob.core.windows.net/attac/ThomasCruise.jpg" },
                    { 6, "Sergey Borisov was born on April 4, 1975 in the USSR. He is an actor", "Sergey Borisov", "https://sultan.blob.core.windows.net/attac/Sergey_Borisov.png" },
                    { 5, "alil Asretov was born on February 26, 1994 in Makhachkala , Russia", "Jalil Asretov", "https://sultan.blob.core.windows.net/attac/Jalil-Asretov.jpg" },
                    { 4, "Kristina Asmus was born on April 14, 1988, in Kaliningrad", "Kristina Asmus", "https://sultan.blob.core.windows.net/attac/Kristina_Asmus.jpg" },
                    { 3, "Is an American actress and singer", "Taraji Penda Henson", "https://sultan.blob.core.windows.net/attac/Taraji_Henson.jpg" },
                    { 2, "Is an Belgian actor", "Van Damme", "https://sultan.blob.core.windows.net/attac/Van_Damme.jpg" },
                    { 1, "Is an American actor and comedian", "Steven John", "https://sultan.blob.core.windows.net/attac/StevenJohn.jpg" },
                    { 8, "Irving Rameses Ving Rhames is an American actor.", "Irving Rameses", "https://sultan.blob.core.windows.net/attac/Irving-Rameses.jpg" },
                    { 19, "ممثل مصري له العديد من الأعمال الكوميدية", "محمد سلام", "https://sultan.blob.core.windows.net/attac/MTharwat.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad376a8f", "88071775-5f3b-45b7-90ee-fe37b1c798a0", "Administrator", "Administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0", 0, "b1bda1fc-544a-4b8f-97b8-96d87a6c7562", "Administrator@gmail.com", false, null, false, null, "Administrator@gmail.com", "Administrator", "AQAAAAEAACcQAAAAEBxpDw8cQzV2ZnJIof6fJfD6oOUviyXGjtsBS5Gu1qty0WGq5kcflgzfu6Tcb2nY0Q==", null, false, "", false, "Administrator" });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "TAJ Cinemas is the first to introduce the latest in high-tech services to movie-goers such as an online ticketing function to avoid queues", "https://sultan.blob.core.windows.net/attac/Taj.png", "Taj Cinemas" },
                    { 2, "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!", "https://sultan.blob.core.windows.net/attac/Prime.png", "Prime Cinemas Abdali" },
                    { 3, "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!", "https://sultan.blob.core.windows.net/attac/Prime.png", "Prime Cinemas Irbid" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "Kyle Balda is a BAFTA nominated feature animation director working in the industry for 30 years", "Kyle Balda", "https://sultan.blob.core.windows.net/attac/Kyle_Balda.jpg" },
                    { 2, "Aleksey Aleksandrovich Chadov was born on September 2, 1981, in Solntsevo, Moscow region, RSFSR, USSR, now a suburb of Moscow, Russia.", "Aleksey Chadov", "https://sultan.blob.core.windows.net/attac/Chadov_Aleksey.jpg" },
                    { 3, "Paula Kauffman Wagner (born Paula Sue Kauffman) is an American film producer and film executive", "Paula Wagner", "https://sultan.blob.core.windows.net/attac/Paula_Wagner.jpg" },
                    { 4, "Frank Wilton Marshall (born September 13, 1946) is an American film producer and director", "Frank Marshall", "https://sultan.blob.core.windows.net/attac/Frank-Marshall.jpg" },
                    { 5, "Larry Joseph Franco (born April 5, 1949) is an American film producer", "Larry Franco", "https://sultan.blob.core.windows.net/attac/Larry.jfif" },
                    { 6, "Ralph Guggenheim is an American video graphics designer and film producer", "Ralph Guggenheim", "https://sultan.blob.core.windows.net/attac/Ralph.jpg" },
                    { 7, "Kevin Feige is an American film and television producer", "Kevin Feige", "https://sultan.blob.core.windows.net/attac/Kevin_Feige.jpg" },
                    { 8, "حسين المنباوي هو مخرج أفلام ومسلسلات مصري", "حسين المنباوي", "https://sultan.blob.core.windows.net/attac/حسينالمنباوي.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad376a8f", "a18be9c0" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CinemaId", "Description", "EndDate", "ImageURL", "MovieCategory", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, "This is the Life movie description", new DateTime(2022, 8, 6, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(6087), "https://sultan.blob.core.windows.net/attac/life.jpg", 4, "Life", 39.5, 1, new DateTime(2022, 7, 17, 10, 21, 19, 433, DateTimeKind.Local).AddTicks(6997) },
                    { 2, 2, "The untold story of one twelve-year-old's dream to become the world's greatest supervillain.", new DateTime(2022, 8, 6, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8838), "https://sultan.blob.core.windows.net/attac/Minions.jpg", 2, "Minions: The Rise of Gru", 25.989999999999998, 1, new DateTime(2022, 7, 17, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8805) },
                    { 3, 3, "Ivan sets off on a dangerous mission into Syria to save his ex-commander Grey after his capture by ISIS. With the help of U.S. military patrols, he succeeds in freeing Grey and attempts to escape the country while being hunted by terrorists.", new DateTime(2022, 8, 6, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8857), "https://sultan.blob.core.windows.net/attac/Infiltration.png", 1, "Infiltration", 29.989999999999998, 2, new DateTime(2022, 7, 17, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8850) },
                    { 4, 3, "A bookish marmoset embarks on a wild adventure to travel around the planet in 80 days after accepting a challenge from a greedy frog.", new DateTime(2022, 8, 6, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8874), "https://sultan.blob.core.windows.net/attac/Around-the-World-in-80-Days.jpg", 1, "Around the World in 80 Days", 22.989999999999998, 2, new DateTime(2022, 7, 17, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8867) },
                    { 5, 3, "An American agent, under false suspicion of disloyalty, must discover and expose the real spy without the help of his organization.", new DateTime(2022, 8, 1, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8891), "https://sultan.blob.core.windows.net/attac/Mission-Impossible.png", 1, "Mission: Impossible", 26.989999999999998, 3, new DateTime(2022, 7, 22, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8883) },
                    { 6, 3, "Four years after the destruction of Isla Nublar, dinosaurs now live--and hunt--alongside humans all over the world.", new DateTime(2022, 8, 4, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8907), "https://sultan.blob.core.windows.net/attac/Jurassic-World-Dominion.jpg", 1, "Jurassic World Dominion", 10.99, 4, new DateTime(2022, 7, 20, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8899) },
                    { 7, 2, "A decidedly odd couple with ulterior motives convince Dr. Grant to go to Isla Sorna for a holiday, but their unexpected landing startles the island's new inhabitants..", new DateTime(2022, 8, 3, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8924), "https://sultan.blob.core.windows.net/attac/Jurassic-Park-III.jpg", 1, "Jurassic Park III", 30.989999999999998, 5, new DateTime(2022, 7, 25, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8917) },
                    { 8, 1, "A cowboy doll is profoundly threatened and jealous when a new spaceman action figure supplants him as top toy in a boy's bedroom.", new DateTime(2022, 8, 10, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8941), "https://sultan.blob.core.windows.net/attac/Toy-Story.jpg", 2, "Toy Story", 10.99, 6, new DateTime(2022, 7, 13, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8932) },
                    { 9, 1, "Shang-Chi, the master of weaponry-based Kung Fu, is forced to confront his past after being drawn into the Ten Rings organization..", new DateTime(2022, 8, 9, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8954), "https://sultan.blob.core.windows.net/attac/Shang-Chi.jpg", 1, "Shang-Chi and the Legend of the Ten Rings", 25.989999999999998, 7, new DateTime(2022, 7, 14, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8948) },
                    { 10, 2, "A bookish marmoset embarks on a wild adventure to travel around the planet in 80 days after accepting a challenge from a greedy frog.", new DateTime(2022, 8, 15, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8968), "https://sultan.blob.core.windows.net/attac/Thor-Ragnarok.jpg", 1, "Thor: Ragnarok", 25.989999999999998, 7, new DateTime(2022, 7, 8, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8962) },
                    { 11, 3, "سلطان ملاكم يجري ورا حلمه رغم الصعوبات تقوده الصدفه لتغيير حياته .", new DateTime(2022, 8, 6, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8982), "https://sultan.blob.core.windows.net/attac/3amhom.jpg", 2, "عمهم", 20.989999999999998, 8, new DateTime(2022, 7, 17, 10, 21, 19, 440, DateTimeKind.Local).AddTicks(8976) }
                });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 18, 11 },
                    { 17, 10 },
                    { 16, 10 },
                    { 15, 9 },
                    { 14, 9 },
                    { 13, 8 },
                    { 12, 8 },
                    { 11, 7 },
                    { 19, 11 },
                    { 10, 7 },
                    { 9, 6 },
                    { 8, 5 },
                    { 7, 5 },
                    { 6, 3 },
                    { 5, 3 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 2 },
                    { 10, 6 },
                    { 20, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MovieId",
                table: "OrderItems",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_MovieId",
                table: "ShoppingCartItems",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors_Movies");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
