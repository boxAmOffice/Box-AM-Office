using Box_AM_Ofice.Models.Interfaces;
using boxAmOffice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Services
{
    public class ActorService : IActor
    {
        private AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Actor> CreateActor(Actor actor)
        {
            Actor actor1 = new Actor
            {
                FullName = actor.FullName,
                Bio = actor.Bio,
                ProfilePictureURL = actor.ProfilePictureURL

            };
            _context.Entry(actor).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return actor1;
        }

        public async Task DeleteActor(int id)
        {
            Actor actor = await _context.Actors.FindAsync(id);
            _context.Entry(actor).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> GetActor(int Id)
        {
            return await _context.Actors.FindAsync(Id);
        }

        public async Task<List<Actor>>  GetActors()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> UpdateActor(int Id, Actor actor)
        {
            Actor UpdatedActor = new Actor
            {
                Id = actor.Id,
                Bio = actor.Bio,
                FullName = actor.FullName,
                ProfilePictureURL = actor.ProfilePictureURL
            };

            _context.Entry(actor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return UpdatedActor;
        }
    }
}
