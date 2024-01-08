using Abp.Authorization;
using Moises2024.Authorization.Roles;
using Moises2024.Authorization.Users;

namespace Moises2024.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
