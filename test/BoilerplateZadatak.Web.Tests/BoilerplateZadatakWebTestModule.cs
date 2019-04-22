using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateZadatak.Web.Startup;
namespace BoilerplateZadatak.Web.Tests
{
    [DependsOn(
        typeof(BoilerplateZadatakWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BoilerplateZadatakWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateZadatakWebTestModule).GetAssembly());
        }
    }
}