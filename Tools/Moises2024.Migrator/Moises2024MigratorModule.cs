using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Moises2024.EntityFramework;

namespace Moises2024.Migrator
{
    [DependsOn(typeof(Moises2024DataModule))]
    public class Moises2024MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<Moises2024DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}