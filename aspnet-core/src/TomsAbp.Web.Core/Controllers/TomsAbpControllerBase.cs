using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TomsAbp.Controllers
{
    public abstract class TomsAbpControllerBase: AbpController
    {
        protected TomsAbpControllerBase()
        {
            LocalizationSourceName = TomsAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
