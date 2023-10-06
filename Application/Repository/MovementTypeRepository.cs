using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class MovementTypeRepository : GenericRepository<MovementType>, IMovementTypeRepository{
    public MovementTypeRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<MovementType>> GetAll(Expression<Func<MovementType, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Description)
                    .Include(x => x.MedicineMovements)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Description)
                .Include(x => x.MedicineMovements)
                .ToListAsync();
        }
}
