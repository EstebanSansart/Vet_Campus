using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class OwnerRepository : GenericRepository<Owner>, IOwnerRepository{
    public OwnerRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Owner>> GetAll(Expression<Func<Owner, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Email)
                    .Include(x => x.PhoneNumber)
                    .Include(x => x.Pets)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Email)
                .Include(x => x.PhoneNumber)
                .Include(x => x.Pets)
                .ToListAsync();
        }
}
