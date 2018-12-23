using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace TomsAbp.Web.Views
{
    public abstract class TomsAbpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TomsAbpRazorPage()
        {
            LocalizationSourceName = TomsAbpConsts.LocalizationSourceName;
        }
    }
}
