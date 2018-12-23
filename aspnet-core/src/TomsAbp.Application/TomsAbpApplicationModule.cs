using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TomsAbp.Authorization;

namespace TomsAbp
{
    [DependsOn(
        typeof(TomsAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TomsAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TomsAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TomsAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
