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
                      },
                       new Movie
                       {
                           Id = 5,
                           Name = "Mission: Impossible",
                           Description = "An American agent, under false suspicion of disloyalty, must discover and expose the real spy without the help of his organization.",
                           Price = 26.99,
                           ImageURL = "https://sultan.blob.core.windows.net/attac/Mission-Impossible.png",
                           StartDate = DateTime.Now.AddDays(-5),
                           EndDate = DateTime.Now.AddDays(5),
                           CinemaId = 3,
                           ProducerId = 3,
                           MovieCategory = MovieCategory.Action
                       },
                        new Movie
                        {
                            Id = 6,
                            Name = "Jurassic World Dominion",
                            Description = "Four years after the destruction of Isla Nublar, dinosaurs now live--and hunt--alongside humans all over the world.",
                            Price = 10.99,
                            ImageURL = "https://sultan.blob.core.windows.net/attac/Jurassic-World-Dominion.jpg",
                            StartDate = DateTime.Now.AddDays(-7),
                            EndDate = DateTime.Now.AddDays(8),
                            CinemaId = 3,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        },
                         new Movie
                         {
                             Id = 7,
                             Name = "Jurassic Park III",
                             Description = "A decidedly odd couple with ulterior motives convince Dr. Grant to go to Isla Sorna for a holiday, but their unexpected landing startles the island's new inhabitants..",
                             Price = 30.99,
                             ImageURL = "https://sultan.blob.core.windows.net/attac/Jurassic-Park-III.jpg",
                             StartDate = DateTime.Now.AddDays(-2),
                             EndDate = DateTime.Now.AddDays(7),
                             CinemaId = 2,
                             ProducerId = 5,
                             MovieCategory = MovieCategory.Action
                         },
                          new Movie
                          {
                              Id = 8,
                              Name = "Toy Story",
                              Description = "A cowboy doll is profoundly threatened and jealous when a new spaceman action figure supplants him as top toy in a boy's bedroom.",
                              Price = 10.99,
                              ImageURL = "https://sultan.blob.core.windows.net/attac/Toy-Story.jpg",
                              StartDate = DateTime.Now.AddDays(-14),
                              EndDate = DateTime.Now.AddDays(14),
                              CinemaId = 1,
                              ProducerId = 6,
                              MovieCategory = MovieCategory.Comedy
                          },
                           new Movie
                           {
                               Id = 9,
                               Name = "Shang-Chi and the Legend of the Ten Rings",
                               Description = "Shang-Chi, the master of weaponry-based Kung Fu, is forced to confront his past after being drawn into the Ten Rings organization..",
                               Price = 25.99,
                               ImageURL = "https://sultan.blob.core.windows.net/attac/Shang-Chi.jpg",
                               StartDate = DateTime.Now.AddDays(-13),
                               EndDate = DateTime.Now.AddDays(13),
                               CinemaId = 1,
                               ProducerId = 7,
                               MovieCategory = MovieCategory.Action
                           },
                            new Movie
                            {
                                Id = 10,
                                Name = "Thor: Ragnarok",
                                Description = "A bookish marmoset embarks on a wild adventure to travel around the planet in 80 days after accepting a challenge from a greedy frog.",
                                Price = 25.99,
                                ImageURL = "https://sultan.blob.core.windows.net/attac/Thor-Ragnarok.jpg",
                                StartDate = DateTime.Now.AddDays(-19),
                                EndDate = DateTime.Now.AddDays(19),
                                CinemaId = 2,
                                ProducerId = 7,
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

                 },
                 new Producer
                 {
                     Id = 3,
                     FullName = "Paula Wagner",
                     Bio = "Wagner was born Paula Sue Kauffman in Youngstown, Ohio. Her mother, Sue Anna (née Shofstall), was a news magazine editor from Oklahoma, and her father, Edmund Jamison Ned Kauffman, Jr., was a business owner.",
                     ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Paula-Wagner-Deauville.png"

                 },
                  new Producer
                  {
                      Id = 4,
                      FullName = "Frank Marshall",
                      Bio = "Frank Wilton Marshall (born September 13, 1946) is an American film producer and director. He often collaborates with his wife, film producer Kathleen Kennedy. ",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Frank-Marshall.jpg"

                  },
                  new Producer
                  {
                      Id = 5,
                      FullName = "Larry Franco",
                      Bio = "Larry Joseph Franco (born April 5, 1949) is an American film producer. He has also served as an actor, second unit director and assistant director.",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Larry-Franco.jpg"

                  },
                  new Producer
                  {
                      Id = 6,
                      FullName = "Ralph Guggenheim",
                      Bio = "Ralph Guggenheim is an American video graphics designer and film producer. He won a Producers Guild of America Award in 1995 for his contributions to the film Toy Story..",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Ralph-Guggenheim.jpg"

                  }
                  ,
                  new Producer
                  {
                      Id = 7,
                      FullName = "Kevin Feige",
                      Bio = "Kevin Feige is an American film and television producer who has been the president of Marvel Studios and the primary producer of the Marvel Cinematic Universe franchise since 2007.",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Kevin-Feige.jpg"

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

                },
                  new Actor
                  {
                      Id = 7,
                      FullName = "Thomas Cruise",
                      Bio = "Thomas Cruise Mapother IV(born July 3, 1962) is an American actor and producer.One of the world's highest-paid actors,[1] he has received various accolades.",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Tom-Cruise.jpg"
                  },
                    new Actor
                    {
                        Id = 8,
                        FullName = "Irving Rameses",
                        Bio = "Irving Rameses Ving Rhames is an American actor. He is best known for his starring role as IMF Agent Luther Stickell in the Mission: Impossible film series and his supporting role as gang kingpin Marsellus Wallace in Pulp Fiction",
                        ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Irving-Rameses.jpg"
                    },
                     new Actor
                     {
                         Id = 9,
                         FullName = "Jeff Goldblum",
                         Bio = "Jeffrey Lynn Goldblum (/ˈɡoʊldbluːm/; born October 22, 1952) is an American actor and musician. He has starred in some of the highest-grossing films of his era, such as Jurassic Park (1993) and Independence Day (1996), as well as their sequels.",
                         ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Jeff-Goldblum.jpg"
                     },
                      new Actor
                      {
                          Id = 10,
                          FullName = "Sam Neill",
                          Bio = "Sam Neill was born in Omagh, Co. Tyrone, Northern Ireland, to army parents, an English-born mother, Priscilla Beatrice (Ingham), and a New Zealand-born father, Dermot Neill.",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Sam-Neill.jpg"
                      },
                      new Actor
                      {
                          Id = 11,
                          FullName = "Steven Spielberg",
                          Bio = "Steven Allan Spielberg (/ˈspiːlbɜːrɡ/; born December 18, 1946) is an American film director, producer, and screenwriter.[1] A figure of the New Hollywood era, he is the most commercially successful director of all time. ",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Steven-Spielberg.jpg"
                      },
                      
                      new Actor
                      {
                          Id = 12,
                          FullName = "Tom Hanks",
                          Bio = "Thomas Jeffrey Hanks was born in Concord, California, to Janet Marylyn (Frager), a hospital worker, and Amos Mefford Hanks, an itinerant cook. His mother's family, originally surnamed Fraga, was entirely Portuguese, while his father was of mostly English ancestry.",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Tom-Hanks.jpg"
                      },
                      
                      new Actor
                      {
                          Id = 13,
                          FullName = "Tim Allen (I)",
                          Bio = "Timothy Allen Dick was born on June 13, 1953, in Denver, Colorado, to Martha Katherine (Fox) and Gerald M. Dick. ",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Tim-Allen.jpg"
                      },
                      new Actor
                      {
                          Id = 14,
                          FullName = "Simu iu",
                          Bio = "Simu Liu (/ˈsimu ˈlijuː/ SEE-moo LEE-ew;[2] Chinese: 刘思慕; born 19 April 1989) is a Canadian actor, author, and stuntman. He is known for portraying Shang-Chi in the 2021 Marvel Cinematic Universe film Shang-Chi and the Legend of the Ten Rings..",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Simu-iu.jpg"
                      },
                      new Actor
                      {
                          Id = 15,
                          FullName = "Tony Leung Chiu-wai",
                          Bio = "Tony Leung Chiu-wai (Chinese: 梁朝偉, born 27 June 1962) is a Hong Kong actor and singer. He is one of Asia's most successful and internationally recognized actors, and was named as Small Tiger among the Five Tiger Generals of TVB.",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Tony-Leung-Chiu-wai.jpg"
                      }
                      ,
                      new Actor
                      {
                          Id = 16,
                          FullName = "Chris Hemsworth",
                          Bio = "Christopher Hemsworth AM is an Australian actor. He rose to prominence playing Kim Hyde in the Australian television series Home and Away before beginning a film career in Hollywood.",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Chris-Hemsworth.jpg"
                      }
                      ,
                      new Actor
                      {
                          Id = 17,
                          FullName = "Taika Waititi",
                          Bio = "Taika David Cohen ONZM, known professionally as Taika Waititi, is a New Zealand filmmaker, actor, and comedian. He is a recipient of an Academy Award, a BAFTA Award, and a Grammy Award, and has received two nominations at the Primetime Emmy Awards.",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Taika-Waititi.jpg"
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
                 },
                 new Actor_Movie()
                 {
                     ActorId = 7,
                     MovieId = 5
                 },
                  new Actor_Movie()
                  {
                      ActorId = 8,
                      MovieId = 5
                  }
                  ,
                  new Actor_Movie()
                  {
                      ActorId = 9,
                      MovieId = 6
                  }
                  ,
                  new Actor_Movie()
                  {
                      ActorId = 10,
                      MovieId = 6
                  }
                  ,
                  new Actor_Movie()
                  {
                      ActorId = 10,
                      MovieId = 7

                  }
                   ,
                  new Actor_Movie()
                  {
                      ActorId = 11,
                      MovieId = 7
                  }
                     ,
                  new Actor_Movie()
                  {
                      ActorId = 12,
                      MovieId = 8
                  }
                     ,
                  new Actor_Movie()
                  {
                      ActorId = 13,
                      MovieId = 8
                  }
                      ,
                  new Actor_Movie()
                  {
                      ActorId = 14,
                      MovieId = 9
                  }
                      ,
                  new Actor_Movie()
                  {
                      ActorId = 15,
                      MovieId = 9
                  }
                        ,
                  new Actor_Movie()
                  {
                      ActorId = 16,
                      MovieId = 10
                  }
                        ,
                  new Actor_Movie()
                  {
                      ActorId = 17,
                      MovieId = 10
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
