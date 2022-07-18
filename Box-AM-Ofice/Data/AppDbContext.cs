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
                        }

                        );

            modelBuilder.Entity<Producer>().HasData(
                new Producer
                {
                    Id = 1,
                    FullName = "Producer 1",
                    Bio = "This is the Bio of the first actor",
                    ProfilePictureURL = ""

                }

                        );

            modelBuilder.Entity<Actor>().HasData(
                new Actor
                {
                    Id = 1,
                    FullName = "Actor 1",
                    Bio = "This is the Bio of the first actor",
                    ProfilePictureURL = ""

                }
                );
            modelBuilder.Entity<Cinema>().HasData(
              new Cinema
              {
                  Id = 1,
                  Name = "Cinema 1",
                  Logo = "",
                  Description = "This is the description of the first cinema"

              }
              );
            modelBuilder.Entity<Actor_Movie>().HasData(
                new Actor_Movie()
                {
                    ActorId = 1,
                    MovieId = 1
                }
                );
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            //any unique string id
            const string ADMIN_ID = "abcbe9c0";
            const string ADMIN_ROLE_ID = "ad376a8ff";

            // create an Admin role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ADMIN_ROLE_ID,
                Name = "Administrator",
                NormalizedName = "Admin"
            });

            //create a User
           var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = false,
                PasswordHash = hasher.HashPassword(null, "@dmin123"),
                SecurityStamp = string.Empty
            });

            //assign that user to the admin role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });

            SeedRoles(modelBuilder, "Administrator");

        }

        private void SeedRoles(ModelBuilder modelBuilder, string roleName)
        {
            var role = new IdentityRole
            {
                Id = roleName.ToLower(),
                Name = roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString()
            };
            modelBuilder.Entity<IdentityRole>().HasData(role);
        
    }

       
    }

}
