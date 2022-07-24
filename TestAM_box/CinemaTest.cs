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
   public class CinemaTest
    {
        [Fact]
        public void CanGetCinema()
        {
            //Arrange
            Cinema cinema = new Cinema();
            cinema.Name = "Taj Cinemas";

            //Assert
            Assert.Equal("Taj Cinemas", cinema.Name);
        }
        [Fact]
        public void CanSetCinema()
        {
            //Arrange
            Cinema cinema = new Cinema()
            {
                Name = "Life",
                Logo = "https://sultan.blob.core.windows.net/attac/Taj.png",

            };
            cinema.Name = "Taj Cinema";
            //Assert
            Assert.Equal("Taj Cinema", cinema.Name);
        }
        [Fact]
        public async void CrudCinemaInDB()
        {
            //Arrange
            //setup our DB
            //set values

            DbContextOptions<AppDbContext> options =
            new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("DbCanSave").Options;

            //Act
            using (AppDbContext context = new AppDbContext(options))
            {
                Cinema cinema = new Cinema();
                cinema.Name = "Test Product";
                cinema.Logo = "https://sultan.blob.core.windows.net/attac/Taj.png";



                ////Act

                context.Cinemas.Add(cinema);
                context.SaveChanges();

                var productName = await context.Cinemas.FirstOrDefaultAsync(x => x.Name == cinema.Name);

                //Assert
                Assert.Equal("Test Product", productName.Name);

                //UPDATE
                cinema.Name = "Update Product";
                context.Cinemas.Update(cinema);
                context.SaveChanges();

                var updated = await context.Cinemas.FirstOrDefaultAsync(x => x.Name == cinema.Name);

                Assert.Equal("Update Product", updated.Name);

                //DELETE
                context.Cinemas.Remove(cinema);
                context.SaveChanges();

                var deletedProduct = await context.Cinemas.FirstOrDefaultAsync(x => x.Name == cinema.Name);

                Assert.True(deletedProduct == null);
            }

        }
    }
}
