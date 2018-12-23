using System.Collections.Generic;
using TomsAbp.Roles.Dto;
using TomsAbp.Users.Dto;

namespace TomsAbp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
