using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class LabRepository : GenericRepository<Lab>, ILabRepository{
    public LabRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Lab>> GetAll(Expression<Func<Lab, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Address)
                    .Include(x => x.PhoneNumber)
                    .Include(x => x.Medicines)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Address)
                .Include(x => x.PhoneNumber)
                .Include(x => x.Medicines)
                .ToListAsync();
        }
}
