using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class RoleRepository : GenericRepository<Role>, IRoleRepository{
    public RoleRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Role>> GetAll(Expression<Func<Role, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Users)
                    .Include(x => x.UserRoles)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Users)
                .Include(x => x.UserRoles)
                .ToListAsync();
        }
}
