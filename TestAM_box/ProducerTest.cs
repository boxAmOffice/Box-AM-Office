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
   public class ProducerTest
    {
        [Fact]
        public void CanGetProducer()
        {
            //Arrange
            Producer producer = new Producer();
            producer.FullName = "Ralph Guggenheim";

            //Assert
            Assert.Equal("Ralph Guggenheim", producer.FullName);
        }
        [Fact]
        public void CanSetProducer()
        {
            //Arrange
            Producer producer = new Producer()
            {
                Id = 6,
                FullName = "Ralph",
                Bio = "Ralph Guggenheim is an American video graphics designer and film producer. He won a Producers Guild of America Award in 1995 for his contributions to the film Toy Story..",
                ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Ralph-Guggenheim.jpg"

            };
            producer.FullName = "Ralph Guggenheim";
            //Assert
            Assert.Equal("Ralph Guggenheim", producer.FullName);
        }
        [Fact]
        public async void CrudProducerInDB()
        {
            //Arrange
            //setup our DB
            //set values

            DbContextOptions<AppDbContext> options =
            new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("DbCanSave").Options;

            //Act
            using (AppDbContext context = new AppDbContext(options))
            {
                Producer producer = new Producer()
                {

                    Id = 6,
                    FullName = "Ralph Guggenheim",
                    Bio = "Ralph Guggenheim is an American video graphics designer and film producer. He won a Producers Guild of America Award in 1995 for his contributions to the film Toy Story..",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Ralph-Guggenheim.jpg"
                };



                ////Act

                context.Producers.Add(producer);
                context.SaveChanges();

                var productName = await context.Producers.FirstOrDefaultAsync(x => x.FullName == producer.FullName);

                //Assert
                Assert.Equal("Ralph Guggenheim", productName.FullName);

                //UPDATE
                producer.FullName = "Update Product";
                context.Producers.Update(producer);
                context.SaveChanges();

                var updated = await context.Producers.FirstOrDefaultAsync(x => x.FullName == producer.FullName);

                Assert.Equal("Update Product", updated.FullName);

                //DELETE
                context.Producers.Remove(producer);
                context.SaveChanges();

                var deletedProduct = await context.Producers.FirstOrDefaultAsync(x => x.FullName == producer.FullName);

                Assert.True(deletedProduct == null);
            }

        }
    }
}
