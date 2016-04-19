using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SeeMe.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Wrap nhiu qua hong tot ^^
        DbContext Context { get; }
        DbSet<TEntity> DbSet { get; }
        #endregion

        IQueryable<TEntity> GetAll();

        TEntity GetById(object id);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
        void Delete(object id);

    }
}
