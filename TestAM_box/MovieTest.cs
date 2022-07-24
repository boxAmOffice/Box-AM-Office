using boxAmOffice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestAM_box
{
   public class MovieTest
    {
        [Fact]
        public void CanGetMovie()
        {
            //Arrange
            Movie movie = new Movie();
            movie.Name = "Life";

            //Assert
            Assert.Equal("Life", movie.Name);
        }
        [Fact]
        public void CanSetMovie()
        {
            //Arrange
            Movie movie = new Movie()
            {
                Name = "Life",
                ImageURL = "https://sultan.blob.core.windows.net/attac/life.jpg",
                Price = 19.99,
               
            };
            movie.Name = "Life 2";
            //Assert
            Assert.Equal("Life 2", movie.Name);
        }
        [Fact]
        public async void CrudMovieInDB()
        {
            //Arrange
            //setup our DB
            //set values

            DbContextOptions<AppDbContext> options =
            new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("DbCanSave").Options;

            //Act
            using (AppDbContext context = new AppDbContext(options))
            {
                Movie movie = new Movie();
                movie.Name = "Test Product";
                movie.Price = 23.99;
                movie.ImageURL = "https://sultan.blob.core.windows.net/attac/life.jpg";
              

                ////Act

                context.Movies.Add(movie);
                context.SaveChanges();

                var productName = await context.Movies.FirstOrDefaultAsync(x => x.Name == movie.Name);

                //Assert
                Assert.Equal("Test Product", productName.Name);

                //UPDATE
                movie.Name = "Update Product";
                context.Movies.Update(movie);
                context.SaveChanges();

                var updated = await context.Movies.FirstOrDefaultAsync(x => x.Name == movie.Name);

                Assert.Equal("Update Product", updated.Name);

                //DELETE
                context.Movies.Remove(movie);
                context.SaveChanges();

                var deletedProduct = await context.Movies.FirstOrDefaultAsync(x => x.Name == movie.Name);

                Assert.True(deletedProduct == null);
            }

        }
    }
}
