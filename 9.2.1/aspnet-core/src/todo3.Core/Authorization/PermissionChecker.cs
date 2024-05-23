using Abp.Authorization;
using todo3.Authorization.Roles;
using todo3.Authorization.Users;

namespace todo3.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
