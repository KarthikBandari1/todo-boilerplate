using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using todo3.Authorization;

namespace todo3
{
    [DependsOn(
        typeof(todo3CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class todo3ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<todo3AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(todo3ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
