using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class PetRepository : GenericRepository<Pet>, IPetRepository{
    public PetRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Pet>> GetAll(Expression<Func<Pet, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.BirthDate)
                    .Include(x => x.Owner)
                    .Include(x => x.Species)
                    .Include(x => x.Breed)
                    .Include(x => x.Appointments)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.BirthDate)
                .Include(x => x.Owner)
                .Include(x => x.Species)
                .Include(x => x.Breed)
                .Include(x => x.Appointments)
                .ToListAsync();
        }
}
