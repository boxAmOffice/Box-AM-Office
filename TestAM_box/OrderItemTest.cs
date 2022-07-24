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
   public class OrderItemTest
    {
        [Fact]
        public async void CrudOrderItemInDB()
        {

            DbContextOptions<AppDbContext> options =
            new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("DbCanSave").Options;

            //Act
            using (AppDbContext context = new AppDbContext(options))
            {
                OrderItem basket = new OrderItem();
                basket.OrderId = 1;
                basket.Amount = 1;
                basket.MovieId= 1;

                ////Act

                context.OrderItems.Add(basket);
                context.SaveChanges();

                var basketQty = await context.OrderItems.FirstOrDefaultAsync(x => x.OrderId == basket.OrderId);

                //Assert
                Assert.Equal(1, basketQty.OrderId);

                //UPDATE
                basket.Amount = 2;
                context.OrderItems.Update(basket);
                context.SaveChanges();

                var updatedBasket = await context.OrderItems.FirstOrDefaultAsync(x => x.Amount == basket.Amount);

                Assert.Equal(2, updatedBasket.Amount);

                //DELETE
                context.OrderItems.Remove(basket);
                context.SaveChanges();

                var deletedBasket = await context.OrderItems.FirstOrDefaultAsync(x => x.Amount == basket.Amount);

                Assert.True(deletedBasket == null);
            }
        }
    }
}
