using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class MovementDetailRepository : GenericRepository<MovementDetail>, IMovementDetailRepository{
    public MovementDetailRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<MovementDetail>> GetAll(Expression<Func<MovementDetail, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Quantity)
                    .Include(x => x.Price)
                    .Include(x => x.Medicine)
                    .Include(x => x.MedicineMovement)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Quantity)
                .Include(x => x.Price)
                .Include(x => x.Medicine)
                .Include(x => x.MedicineMovement)
                .ToListAsync();
        }
}
