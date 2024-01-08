using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Moises2024.EntityFramework.Repositories
{
    public abstract class Moises2024RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<Moises2024DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Moises2024RepositoryBase(IDbContextProvider<Moises2024DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class Moises2024RepositoryBase<TEntity> : Moises2024RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected Moises2024RepositoryBase(IDbContextProvider<Moises2024DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
