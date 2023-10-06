using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class MedicineMovementRepository : GenericRepository<MedicineMovement>, IMedicineMovementRepository{
    public MedicineMovementRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<MedicineMovement>> GetAll(Expression<Func<MedicineMovement, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Quantity)
                    .Include(x => x.Date)
                    .Include(x => x.Medicine)
                    .Include(x => x.MovementType)
                    .Include(x => x.MovementDetails)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Quantity)
                .Include(x => x.Date)
                .Include(x => x.Medicine)
                .Include(x => x.MovementType)
                .Include(x => x.MovementDetails)
                .ToListAsync();
        }
}
