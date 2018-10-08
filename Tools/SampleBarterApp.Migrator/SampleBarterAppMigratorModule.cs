using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SampleBarterApp.EntityFramework;

namespace SampleBarterApp.Migrator
{
    [DependsOn(typeof(SampleBarterAppDataModule))]
    public class SampleBarterAppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SampleBarterAppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}