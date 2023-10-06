using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class BreedRepository : GenericRepository<Breed>, IBreedRepository{
    public BreedRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Breed>> GetAll(Expression<Func<Breed, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Species)
                    .Include(x => x.Pets)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Species)
                .Include(x => x.Pets)
                .ToListAsync();
        }
}
