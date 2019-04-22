using System;
using System.Threading.Tasks;
using Abp.TestBase;
using BoilerplateZadatak.EntityFrameworkCore;
using BoilerplateZadatak.Tests.TestDatas;

namespace BoilerplateZadatak.Tests
{
    public class BoilerplateZadatakTestBase : AbpIntegratedTestBase<BoilerplateZadatakTestModule>
    {
        public BoilerplateZadatakTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BoilerplateZadatakDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerplateZadatakDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BoilerplateZadatakDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerplateZadatakDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BoilerplateZadatakDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerplateZadatakDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BoilerplateZadatakDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerplateZadatakDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
