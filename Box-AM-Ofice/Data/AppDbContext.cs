using Box_AM_Ofice.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boxAmOffice.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }


        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                        new Movie
                        {
                            Id = 1,
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Documentary
                        },
                      new Movie
                      {
                          Id = 2,
                          Name = "Minions: The Rise of Gru",
                          Description = "The untold story of one twelve-year-old's dream to become the world's greatest supervillain.",
                          Price = 25.99,
                          ImageURL = "https://sultan.blob.core.windows.net/attac/Minions.jpg",
                          StartDate = DateTime.Now.AddDays(-10),
                          EndDate = DateTime.Now.AddDays(10),
                          CinemaId = 2,
                          ProducerId = 1,
                          MovieCategory = MovieCategory.Comedy
                      },
                      new Movie
                      {
                          Id = 3,
                          Name = "Infiltration",
                          Description = "Ivan sets off on a dangerous mission into Syria to save his ex-commander Grey after his capture by ISIS. With the help of U.S. military patrols, he succeeds in freeing Grey and attempts to escape the country while being hunted by terrorists.",
                          Price = 29.99,
                          ImageURL = "https://sultan.blob.core.windows.net/attac/Infiltration.png",
                          StartDate = DateTime.Now.AddDays(-10),
                          EndDate = DateTime.Now.AddDays(10),
                          CinemaId = 3,
                          ProducerId = 2,
                          MovieCategory = MovieCategory.Action
                      },
                      new Movie
                      {
                          Id = 4,
                          Name = "Around the World in 80 Days",
                          Description = "A bookish marmoset embarks on a wild adventure to travel around the planet in 80 days after accepting a challenge from a greedy frog.",
                          Price = 22.99,
                          ImageURL = "https://sultan.blob.core.windows.net/attac/Around-the-World-in-80-Days.jpg",
                          StartDate = DateTime.Now.AddDays(-10),
                          EndDate = DateTime.Now.AddDays(10),
                          CinemaId = 3,
                          ProducerId = 2,
                          MovieCategory = MovieCategory.Action
                      }

                        );

            modelBuilder.Entity<Producer>().HasData(
                new Producer
                {
                    Id = 1,
                    FullName = "Kyle Balda",
                    Bio = "Kyle Balda is a BAFTA nominated feature animation director working in the industry for 30 years",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Kyle_Balda.jpg"

                },
                 new Producer
                 {
                     Id = 2,
                     FullName = "Aleksey Chadov",
                     Bio = "Aleksey Aleksandrovich Chadov was born on September 2, 1981, in Solntsevo, Moscow region, RSFSR, USSR, now a suburb of Moscow, Russia.",
                     ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Chadov_Aleksey.jpg"

                 }

                        );

            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    FullName = "Steven John",
                    Bio = "Is an American actor and comedian",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/StevenJohn.jpg"

                },
                new Actor
                {
                    Id = 2,
                    FullName = "Van Damme",
                    Bio = "Is an Belgian actor",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Van_Damme.jpg"

                },
                new Actor
                {
                    Id = 3,
                    FullName = "Taraji Penda Henson",
                    Bio = "Is an American actress and singer",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Taraji_Henson.jpg"

                },
                new Actor
                {
                    Id = 4,
                    FullName = "Kristina Asmus",
                    Bio = "Kristina Asmus was born Kristina Igorevna Myasnikova on April 14, 1988, in Kaliningrad",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Kristina_Asmus.jpg"

                },
                new Actor
                {
                    Id = 5,
                    FullName = "Jalil Asretov",
                    Bio = "alil Asretov was born on February 26, 1994 in Makhachkala, Republic of Dagestan, Russia.",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Jalil_Asretov.png"

                },
                new Actor
                {
                    Id = 6,
                    FullName = "Sergey Borisov",
                    Bio = "Sergey Borisov was born on April 4, 1975 in the USSR. He is an actor",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Sergey_Borisov.png"

                }
                );
            modelBuilder.Entity<Cinema>().HasData(
              new Cinema
              {
                  Id = 1,
                  Name = "Taj Cinemas",
                  Logo = "https://sultan.blob.core.windows.net/attac/Taj.png",
                  Description = "TAJ Cinemas is the first to introduce the latest in high-tech services to movie-goers such as an online ticketing function to avoid queues"

              },
              new Cinema
              {
                  Id = 2,
                  Name = "Prime Cinemas Abdali",
                  Logo = "https://sultan.blob.core.windows.net/attac/Prime.png",
                  Description = "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!"

              },
              new Cinema
              {
                  Id = 3,
                  Name = "Prime Cinemas Irbid",
                  Logo = "https://sultan.blob.core.windows.net/attac/Prime.png",
                  Description = "The focus of Prime Cinemas is all about our guests and the convenience for local people – this is YOUR local neighborhood cinema!"

              }


              );
            modelBuilder.Entity<Actor_Movie>().HasData(
                new Actor_Movie()
                {
                    ActorId = 1,
                    MovieId = 1
                },
                new Actor_Movie()
                {
                    ActorId = 2,
                    MovieId = 1
                }, new Actor_Movie()
                {
                    ActorId = 3,
                    MovieId = 1
                },
                 new Actor_Movie()
                 {
                     ActorId = 4,
                     MovieId = 2
                 },
                 new Actor_Movie()
                 {
                     ActorId = 5,
                     MovieId = 2
                 },
                 new Actor_Movie()
                 {
                     ActorId = 6,
                     MovieId = 2
                 }

                );
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
            // any unique string id
            const string ADMIN_ID = "a18be9c0";
            const string ADMIN_ROLE_ID = "ad376a8f";


            // create an Admin role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ADMIN_ROLE_ID,
                Name = "Administrator",
                NormalizedName = "Administrator"
            });

            // create a User
            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "Administrator",
                NormalizedUserName = "Administrator",
                Email = "Administrator@gmail.com",
                NormalizedEmail = "Administrator@gmail.com",
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword(null, "Admin123#"),
                SecurityStamp = string.Empty
            });

            // assign that user to the admin role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });
        
        //        //any unique string id
        //        const string ADMIN_ID = "abcbe9c0";
        //        const string ADMIN_ROLE_ID = "ad376a8ff";

        //        // create an Admin role
        //        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        //        {
        //            Id = ADMIN_ROLE_ID,
        //            Name = "Administrator",
        //            NormalizedName = "Admin"
        //        });

        //        //create a User
        //       var hasher = new PasswordHasher<ApplicationUser>();
        //        modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
        //        {
        //            Id = ADMIN_ID,
        //            UserName = "admin",
        //            NormalizedUserName = "admin",
        //            Email = "admin@gmail.com",
        //            NormalizedEmail = "admin@gmail.com",
        //            EmailConfirmed = false,
        //            PasswordHash = hasher.HashPassword(null, "@dmin123"),
        //            SecurityStamp = string.Empty
        //        });

        //        //assign that user to the admin role
        //        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        //        {
        //            RoleId = ADMIN_ROLE_ID,
        //            UserId = ADMIN_ID
        //        });

        //        SeedRoles(modelBuilder, "Administrator");

        //    }

        //    private void SeedRoles(ModelBuilder modelBuilder, string roleName)
        //    {
        //        var role = new IdentityRole
        //        {
        //            Id = roleName.ToLower(),
        //            Name = roleName,
        //            NormalizedName = roleName.ToUpper(),
        //            ConcurrencyStamp = Guid.Empty.ToString()
        //        };
        //        modelBuilder.Entity<IdentityRole>().HasData(role);

        //}

    }
    }

}
