using Microsoft.AspNetCore.Identity;

namespace DefaultIdentity.Areas.Identity.Data;

public static class RoleStorage
{
    public static List<IdentityRole> Roles { get; private set; }

    static RoleStorage()
    {
        Roles = new List<IdentityRole>()
        {
            new IdentityRole("Admin"),
            new IdentityRole("User")
        };
    }
}

