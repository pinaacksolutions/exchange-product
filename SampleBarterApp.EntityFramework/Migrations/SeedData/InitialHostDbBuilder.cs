using SampleBarterApp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SampleBarterApp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SampleBarterAppDbContext _context;

        public InitialHostDbBuilder(SampleBarterAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
