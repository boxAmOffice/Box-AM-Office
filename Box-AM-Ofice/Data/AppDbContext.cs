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
                            ImageURL = "https://sultan.blob.core.windows.net/attac/life.jpg",
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
                            },
                            new Movie
                            {
                                Id = 11,
                                Name = "عمهم",
                                Description = "سلطان ملاكم يجري ورا حلمه رغم الصعوبات تقوده الصدفه لتغيير حياته .",
                                Price = 20.99,
                                ImageURL = "https://sultan.blob.core.windows.net/attac/3amhom.jpg",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(10),
                                CinemaId = 3,
                                ProducerId = 8,
                                MovieCategory = MovieCategory.Comedy
                            },
                            new Movie
                            {
                                Id = 12,
                                Name = "بحبك",
                                Description = "علي شاب عصامي من الطبقة المتوسطة يجد نفسه مجزأ بين حبيبته التي ينوي الزواج بها وخطيبته القديمة التي ظهرت في حياته من جديد. فماذا يملي عليه قلبه؟",
                                Price = 21.99,
                                ImageURL = "https://sultan.blob.core.windows.net/attac/بحبك.jpg",
                                StartDate = DateTime.Now.AddDays(-10),
                                EndDate = DateTime.Now.AddDays(10),
                                CinemaId = 2,
                                ProducerId = 9,
                                MovieCategory = MovieCategory.Drama
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
                     Bio = "Paula Kauffman Wagner (born Paula Sue Kauffman) is an American film producer and film executive",
                     ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Paula_Wagner.jpg"

                 },
                  new Producer
                  {
                      Id = 4,
                      FullName = "Frank Marshall",
                      Bio = "Frank Wilton Marshall (born September 13, 1946) is an American film producer and director",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Frank-Marshall.jpg"

                  },
                  new Producer
                  {
                      Id = 5,
                      FullName = "Larry Franco",
                      Bio = "Larry Joseph Franco (born April 5, 1949) is an American film producer",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Larry.jfif"

                  },
                  new Producer
                  {
                      Id = 6,
                      FullName = "Ralph Guggenheim",
                      Bio = "Ralph Guggenheim is an American video graphics designer and film producer",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Ralph.jpg"

                  },
                  new Producer
                  {
                      Id = 7,
                      FullName = "Kevin Feige",
                      Bio = "Kevin Feige is an American film and television producer",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Kevin_Feige.jpg"

                  },
                  new Producer
                  {
                      Id = 8,
                      FullName = "حسين المنباوي",
                      Bio = "حسين المنباوي هو مخرج أفلام ومسلسلات مصري",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/حسينالمنباوي.jpg"

                  },
                  new Producer
                  {
                      Id = 9,
                      FullName = "Tamer Hosny",
                      Bio = " تامر حسني هو مغني، وكاتب أغاني، وملحن، وممثل، وكاتب سيناريو، ومخرج",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/TamerHosny.jpg"

                  }
                 );

            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    FullName = "Steven John",
                    Bio = "Is an American actor and comedian (born August 16, 1962, Concord, Massachusetts, U.S.)",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/StevenJohn.jpg"

                },
                new Actor
                {
                    Id = 2,
                    FullName = "Van Damme",
                    Bio = "Is an Belgian actor ( born 18 October 1960  in Brussels, Belgium)",
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
                    Bio = "Kristina Asmus was born on April 14, 1988, in Kaliningrad",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Kristina_Asmus.jpg"

                },
                new Actor
                {
                    Id = 5,
                    FullName = "Jalil Asretov",
                    Bio = "alil Asretov was born on February 26, 1994 in Makhachkala , Russia",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Jalil-Asretov.jpg"

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
                      Bio = "Thomas Cruise Mapother IV(born July 3, 1962) is an American actor and producer",
                      ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/ThomasCruise.jpg"
                  },
                    new Actor
                    {
                        Id = 8,
                        FullName = "Irving Rameses",
                        Bio = "Irving Rameses Ving Rhames is an American actor.",
                        ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Irving-Rameses.jpg"
                    },
                     new Actor
                     {
                         Id = 9,
                         FullName = "Jeff Goldblum",
                         Bio = "Jeffrey Lynn Goldblum (born October 22, 1952) is an American actor and musician.",
                         ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/JeffGoldblum.jfif"
                     },
                      new Actor
                      {
                          Id = 10,
                          FullName = "Sam Neill",
                          Bio = "Sam Neill was born in Omagh, Co. Tyrone, Northern Ireland, to army parents, an English-born mother, Priscilla Beatrice (Ingham)",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/SamNeill.jpg"
                      },
                      new Actor
                      {
                          Id = 11,
                          FullName = "Steven Spielberg",
                          Bio = "Steven Allan Spielberg (born December 18, 1946) is an American film director, producer, and screenwriter",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Steven_Spielberg.jpg"
                      },

                      new Actor
                      {
                          Id = 12,
                          FullName = "Tom Hanks",
                          Bio = "Thomas Jeffrey Hanks (born July 9, 1956) is an American actor and filmmaker",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/TomHanks.jpg"
                      },

                      new Actor
                      {
                          Id = 13,
                          FullName = "Tim Allen",
                          Bio = "Timothy Alan Dick (born June 13, 1953), known professionally as Tim Allen, is an American actor and comedian",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/TimAllen.jpg"
                      },
                      new Actor
                      {
                          Id = 14,
                          FullName = "Simu iu",
                          Bio = "Simu Liu is a Canadian actor, author, and stuntman",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/SimuLiu.jpg"
                      },
                      new Actor
                      {
                          Id = 15,
                          FullName = "Tony Leung Chiu-wai",
                          Bio = "Tony Leung Chiu-wai (born 27 June 1962) is a Hong Kong actor and singer. He is one of Asia's most successful and internationally recognized actors",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/TonyLeung.jpg"
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
                          Bio = "Taika David Cohen , known professionally as Taika Waititi, is a New Zealand filmmaker, actor, and comedian",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/TaikaWaititi.jfif"
                      }, new Actor
                      {
                          Id = 18,
                          FullName = "محمد امام",
                          Bio = "ممثل مصري. وهو نجل الفنان عادل إمام وشقيق المخرج رامي إمام",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/MEmam.jpg"
                      }, new Actor
                      {
                          Id = 19,
                          FullName = "محمد سلام",
                          Bio = "ممثل مصري له العديد من الأعمال الكوميدية",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/MTharwat.jpg"
                      }, 
                      new Actor
                      {
                          Id = 20,
                          FullName = "أيتن عامر",
                          Bio = "أيتن عامر (22 نوفمبر 1986-)، ممثلة مصرية",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Aiten.jpeg"
                      },
                      new Actor
                      {
                          Id = 21,
                          FullName = "Tamer Hosny",
                          Bio = " تامر حسني هو مغني، وكاتب أغاني، وملحن، وممثل، وكاتب سيناريو، ومخرج",
                          ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/TamerHosny.jpg"
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
                    MovieId = 2
                },
                new Actor_Movie()
                {
                    ActorId = 2,
                    MovieId = 2
                }, new Actor_Movie()
                {
                    ActorId = 3,
                    MovieId = 2
                },
                 new Actor_Movie()
                 {
                     ActorId = 4,
                     MovieId = 3
                 },
                 new Actor_Movie()
                 {
                     ActorId = 5,
                     MovieId = 3
                 },
                 new Actor_Movie()
                 {
                     ActorId = 6,
                     MovieId = 3
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
                  }, new Actor_Movie()
                  {
                      ActorId = 18,
                      MovieId = 11
                  }, new Actor_Movie()
                  {
                      ActorId = 19,
                      MovieId = 11
                  }, new Actor_Movie()
                  {
                      ActorId = 20,
                      MovieId = 11
                  }, new Actor_Movie()
                  {
                      ActorId = 21,
                      MovieId = 12
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



        }
    }

}
