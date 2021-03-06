// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using boxAmOffice.Models;

namespace Box_AM_Ofice.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220719180053_Add-Tables")]
    partial class AddTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Box_AM_Ofice.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b3158ee9-368e-416a-80b2-0d68e0013bb4",
                            Email = "Administrator@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "Administrator@gmail.com",
                            NormalizedUserName = "Administrator",
                            PasswordHash = "AQAAAAEAACcQAAAAEJqNfpcg0W87iA9lo5v/HP18T5Eu6Zrf531ZN+0jEMxADhlnlhYFpoW9PBcd/AjsCw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ad376a8f",
                            ConcurrencyStamp = "a621b7bb-faed-4d37-b47c-30b65d5484d3",
                            Name = "Administrator",
                            NormalizedName = "Administrator"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "a18be9c0",
                            RoleId = "ad376a8f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("boxAmOffice.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Is an American actor and comedian",
                            FullName = "Steven John",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/StevenJohn.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Is an Belgian actor",
                            FullName = "Van Damme",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Van_Damme.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Is an American actress and singer",
                            FullName = "Taraji Penda Henson",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Taraji_Henson.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Kristina Asmus was born Kristina Igorevna Myasnikova on April 14, 1988, in Kaliningrad",
                            FullName = "Kristina Asmus",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Kristina_Asmus.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "alil Asretov was born on February 26, 1994 in Makhachkala, Republic of Dagestan, Russia.",
                            FullName = "Jalil Asretov",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Jalil_Asretov.png"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "Sergey Borisov was born on April 4, 1975 in the USSR. He is an actor",
                            FullName = "Sergey Borisov",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Sergey_Borisov.png"
                        });
                });

            modelBuilder.Entity("boxAmOffice.Models.Actor_Movie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors_Movies");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 5,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 6,
                            MovieId = 2
                        });
                });

            modelBuilder.Entity("boxAmOffice.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "TAJ Cinemas is the first to introduce the latest in high-tech services to movie-goers such as an online ticketing function to avoid queues",
                            Logo = "https://sultan.blob.core.windows.net/attac/Taj.png",
                            Name = "Taj Cinemas"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!",
                            Logo = "https://sultan.blob.core.windows.net/attac/Prime.png",
                            Name = "Prime Cinemas Abdali"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!",
                            Logo = "https://sultan.blob.core.windows.net/attac/Prime.png",
                            Name = "Prime Cinemas Irbid"
                        });
                });

            modelBuilder.Entity("boxAmOffice.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 1,
                            Description = "This is the Life movie description",
                            EndDate = new DateTime(2022, 7, 29, 21, 0, 52, 855, DateTimeKind.Local).AddTicks(8996),
                            ImageURL = "",
                            MovieCategory = 4,
                            Name = "Life",
                            Price = 39.5,
                            ProducerId = 1,
                            StartDate = new DateTime(2022, 7, 9, 21, 0, 52, 853, DateTimeKind.Local).AddTicks(4117)
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 2,
                            Description = "The untold story of one twelve-year-old's dream to become the world's greatest supervillain.",
                            EndDate = new DateTime(2022, 7, 29, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(251),
                            ImageURL = "https://sultan.blob.core.windows.net/attac/Minions.jpg",
                            MovieCategory = 2,
                            Name = "Minions: The Rise of Gru",
                            Price = 25.989999999999998,
                            ProducerId = 1,
                            StartDate = new DateTime(2022, 7, 9, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(237)
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 3,
                            Description = "Ivan sets off on a dangerous mission into Syria to save his ex-commander Grey after his capture by ISIS. With the help of U.S. military patrols, he succeeds in freeing Grey and attempts to escape the country while being hunted by terrorists.",
                            EndDate = new DateTime(2022, 7, 29, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(259),
                            ImageURL = "https://sultan.blob.core.windows.net/attac/Infiltration.png",
                            MovieCategory = 1,
                            Name = "Infiltration",
                            Price = 29.989999999999998,
                            ProducerId = 2,
                            StartDate = new DateTime(2022, 7, 9, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(256)
                        },
                        new
                        {
                            Id = 4,
                            CinemaId = 3,
                            Description = "A bookish marmoset embarks on a wild adventure to travel around the planet in 80 days after accepting a challenge from a greedy frog.",
                            EndDate = new DateTime(2022, 7, 29, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(265),
                            ImageURL = "https://sultan.blob.core.windows.net/attac/Around-the-World-in-80-Days.jpg",
                            MovieCategory = 1,
                            Name = "Around the World in 80 Days",
                            Price = 22.989999999999998,
                            ProducerId = 2,
                            StartDate = new DateTime(2022, 7, 9, 21, 0, 52, 856, DateTimeKind.Local).AddTicks(262)
                        });
                });

            modelBuilder.Entity("boxAmOffice.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("boxAmOffice.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("boxAmOffice.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Kyle Balda is a BAFTA nominated feature animation director working in the industry for 30 years",
                            FullName = "Kyle Balda",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Kyle_Balda.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Aleksey Aleksandrovich Chadov was born on September 2, 1981, in Solntsevo, Moscow region, RSFSR, USSR, now a suburb of Moscow, Russia.",
                            FullName = "Aleksey Chadov",
                            ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Chadov_Aleksey.jpg"
                        });
                });

            modelBuilder.Entity("boxAmOffice.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Box_AM_Ofice.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Box_AM_Ofice.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Box_AM_Ofice.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Box_AM_Ofice.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("boxAmOffice.Models.Actor_Movie", b =>
                {
                    b.HasOne("boxAmOffice.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("boxAmOffice.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("boxAmOffice.Models.Movie", b =>
                {
                    b.HasOne("boxAmOffice.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("boxAmOffice.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("boxAmOffice.Models.Order", b =>
                {
                    b.HasOne("Box_AM_Ofice.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("boxAmOffice.Models.OrderItem", b =>
                {
                    b.HasOne("boxAmOffice.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("boxAmOffice.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("boxAmOffice.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("boxAmOffice.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("boxAmOffice.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("boxAmOffice.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("boxAmOffice.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("boxAmOffice.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("boxAmOffice.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
