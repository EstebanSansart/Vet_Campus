using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class SpeciesRepository : GenericRepository<Species>, ISpeciesRepository{
    public SpeciesRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Species>> GetAll(Expression<Func<Species, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Pets)
                    .Include(x => x.Breeds)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Pets)
                .Include(x => x.Breeds)
                .ToListAsync();
        }
}
