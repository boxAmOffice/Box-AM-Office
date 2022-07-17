using boxAmOffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Interfaces
{
   public interface IProducer
    {
        Task<List<Producer>> GetProducers();

        Task<Producer> CreateProducer(Producer Product);

        Task<Producer> GetProducer(int Id);

        Task<Producer> UpdateProducer(int Id, Producer producer);

        Task DeleteProducer(int Id);
    }
}
