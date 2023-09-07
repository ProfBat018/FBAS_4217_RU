using DefaultIdentity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DefaultIdentity.Data;

public class UserContext : IdentityDbContext<User>
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
