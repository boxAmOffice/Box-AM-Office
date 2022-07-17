using boxAmOffice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Interfaces
{
    public interface IActor
    {
        Task<List<Actor>> GetActors();

        Task<Actor> CreateActor(Actor Product);

        Task<Actor> GetActor(int Id);

        Task<Actor> UpdateActor(int Id, Actor actor);

        Task DeleteActor(int Id);
    }
}
