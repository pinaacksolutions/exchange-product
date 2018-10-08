using Abp.Authorization;
using SampleBarterApp.Authorization.Roles;
using SampleBarterApp.Authorization.Users;

namespace SampleBarterApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
