using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class VetRepository : GenericRepository<Vet>, IVetRepository{
    public VetRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Vet>> GetAll(Expression<Func<Vet, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Email)
                    .Include(x => x.PhoneNumber)
                    .Include(x => x.Specialty)
                    .Include(x => x.Appointments)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Email)
                .Include(x => x.PhoneNumber)
                .Include(x => x.Specialty)
                .Include(x => x.Appointments)
                .ToListAsync();
        }
}
