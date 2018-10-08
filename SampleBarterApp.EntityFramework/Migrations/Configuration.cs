using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using SampleBarterApp.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace SampleBarterApp.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<SampleBarterApp.EntityFramework.SampleBarterAppDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SampleBarterApp";
        }

        protected override void Seed(SampleBarterApp.EntityFramework.SampleBarterAppDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
