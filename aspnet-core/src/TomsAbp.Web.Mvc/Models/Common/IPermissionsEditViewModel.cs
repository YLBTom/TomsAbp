using System.Collections.Generic;
using TomsAbp.Roles.Dto;

namespace TomsAbp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}