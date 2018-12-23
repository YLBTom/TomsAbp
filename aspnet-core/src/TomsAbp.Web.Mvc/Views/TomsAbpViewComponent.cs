using Abp.AspNetCore.Mvc.ViewComponents;

namespace TomsAbp.Web.Views
{
    public abstract class TomsAbpViewComponent : AbpViewComponent
    {
        protected TomsAbpViewComponent()
        {
            LocalizationSourceName = TomsAbpConsts.LocalizationSourceName;
        }
    }
}
