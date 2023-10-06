using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class UserRepository : GenericRepository<User>, IUserRepository{
    public UserRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<User>> GetAll(Expression<Func<User, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Username)
                    .Include(x => x.Email)
                    .Include(x => x.Password)
                    .Include(x => x.Roles)
                    .Include(x => x.UserRoles)
                    .Include(x => x.RefreshTokenRecords)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Username)
                .Include(x => x.Email)
                .Include(x => x.Password)
                .Include(x => x.Roles)
                .Include(x => x.UserRoles)
                .Include(x => x.RefreshTokenRecords)
                .ToListAsync();
        }
}
