using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SampleBarterApp.EntityFramework;

namespace SampleBarterApp
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SampleBarterAppCoreModule))]
    public class SampleBarterAppDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SampleBarterAppDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
