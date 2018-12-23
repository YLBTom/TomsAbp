using Abp.Authorization;
using TomsAbp.Authorization.Roles;
using TomsAbp.Authorization.Users;

namespace TomsAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
