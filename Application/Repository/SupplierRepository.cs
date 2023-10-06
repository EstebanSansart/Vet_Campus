using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository{
    public SupplierRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Supplier>> GetAll(Expression<Func<Supplier, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Address)
                    .Include(x => x.PhoneNumber)
                    .Include(x => x.Medicines)
                    .Include(x => x.SupplierMedicines)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Address)
                .Include(x => x.PhoneNumber)
                .Include(x => x.Medicines)
                .Include(x => x.SupplierMedicines)
                .ToListAsync();
        }
}
