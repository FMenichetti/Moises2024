using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Moises2024.EntityFramework;

namespace Moises2024
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(Moises2024CoreModule))]
    public class Moises2024DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Moises2024DbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
