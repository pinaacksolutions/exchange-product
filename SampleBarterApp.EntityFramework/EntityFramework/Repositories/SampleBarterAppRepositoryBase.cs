using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SampleBarterApp.EntityFramework.Repositories
{
    public abstract class SampleBarterAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SampleBarterAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SampleBarterAppRepositoryBase(IDbContextProvider<SampleBarterAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SampleBarterAppRepositoryBase<TEntity> : SampleBarterAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SampleBarterAppRepositoryBase(IDbContextProvider<SampleBarterAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
