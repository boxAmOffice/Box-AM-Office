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
   public class ActorTest
    {
        [Fact]
        public void CanGetActor()
        {
            //Arrange
            Actor actor = new Actor();
            actor.FullName = "Sergey Borisov";

            //Assert
            Assert.Equal("Sergey Borisov", actor.FullName);
        }
        [Fact]
        public void CanSetActor()
        {
            //Arrange
            Actor actor = new Actor()
            {
                Id = 6,
                FullName = "Sergey Borisov",
                Bio = "Sergey Borisov was born on April 4, 1975 in the USSR. He is an actor",
                ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Sergey_Borisov.png"

            };
            actor.FullName = "Sergey";
            //Assert
            Assert.Equal("Sergey", actor.FullName);
        }
        [Fact]
        public async void CrudActorInDB()
        {
            //Arrange
            //setup our DB
            //set values

            DbContextOptions<AppDbContext> options =
            new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("DbCanSave").Options;

            //Act
            using (AppDbContext context = new AppDbContext(options))
            {
                Actor actor = new Actor()
                {

                    Id = 6,
                    FullName = "Sergey Borisov",
                    Bio = "Sergey Borisov was born on April 4, 1975 in the USSR. He is an actor",
                    ProfilePictureURL = "https://sultan.blob.core.windows.net/attac/Sergey_Borisov.png"
                };



                ////Act

                context.Actors.Add(actor);
                context.SaveChanges();

                var productName = await context.Actors.FirstOrDefaultAsync(x => x.FullName == actor.FullName);

                //Assert
                Assert.Equal("Sergey Borisov", productName.FullName);

                //UPDATE
                actor.FullName = "Update Product";
                context.Actors.Update(actor);
                context.SaveChanges();

                var updated = await context.Actors.FirstOrDefaultAsync(x => x.FullName == actor.FullName);

                Assert.Equal("Update Product", updated.FullName);

                //DELETE
                context.Actors.Remove(actor);
                context.SaveChanges();

                var deletedProduct = await context.Actors.FirstOrDefaultAsync(x => x.FullName == actor.FullName);

                Assert.True(deletedProduct == null);
            }

        }
    }
}
