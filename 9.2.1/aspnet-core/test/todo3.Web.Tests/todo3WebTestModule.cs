using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using todo3.EntityFrameworkCore;
using todo3.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace todo3.Web.Tests
{
    [DependsOn(
        typeof(todo3WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class todo3WebTestModule : AbpModule
    {
        public todo3WebTestModule(todo3EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(todo3WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(todo3WebMvcModule).Assembly);
        }
    }
}