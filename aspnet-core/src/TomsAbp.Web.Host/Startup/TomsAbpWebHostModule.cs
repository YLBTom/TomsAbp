using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TomsAbp.Configuration;

namespace TomsAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(TomsAbpWebCoreModule))]
    public class TomsAbpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TomsAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TomsAbpWebHostModule).GetAssembly());
        }
    }
}
