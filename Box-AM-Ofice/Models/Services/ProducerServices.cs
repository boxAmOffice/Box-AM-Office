using Box_AM_Ofice.Models.Interfaces;
using boxAmOffice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Services
{
    public class ProducerServices : IProducer
    {
        private AppDbContext _context;

        public ProducerServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Producer> CreateProducer(Producer producer)
        {
            _context.Entry(producer).State = EntityState.Added;
            await _context.SaveChangesAsync();

            return producer;
        }

        public async Task DeleteProducer(int id)
        {
            Producer producer = await _context.Producers.FindAsync(id);
            _context.Entry(producer).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Producer> GetProducer(int Id)
        {
            return await _context.Producers.FindAsync(Id);
        }

        public async Task<List<Producer>> GetProducers()
        {
            return await _context.Producers.ToListAsync();
        }

        public async Task<Producer> UpdateProducer(int Id, Producer producer)
        {
            Producer UpdatedProducer = new Producer
            {
                Id = producer.Id,
                Bio = producer.Bio,
                FullName = producer.FullName,
                ProfilePictureURL = producer.ProfilePictureURL
            };

            _context.Entry(UpdatedProducer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return producer;
        }

       
    }
}
