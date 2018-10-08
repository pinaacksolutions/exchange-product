using System.Collections.Generic;
using SampleBarterApp.Roles.Dto;
using SampleBarterApp.Users.Dto;

namespace SampleBarterApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}