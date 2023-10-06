using Domain.Entities.Generic;

namespace Domain.Entities;
public class User : BaseEntity{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<RefreshTokenRecord> RefreshTokenRecords { get; set; }
}