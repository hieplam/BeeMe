using System.Data.Entity;
using System.Linq;
using SeeMe.Repositories.Interfaces;

namespace SeeMe.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext _context;
        public DbContext Context => _context;

        private DbSet<TEntity> _dbSet;
        
        public DbSet<TEntity> DbSet => _dbSet;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Attach(entity);
            //Equal to _dbSet.Add(entity);
            _context.Entry(entity).State = EntityState.Added;
            
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Attach(entity);
            //Different between Remove and EntityState.Deleted
            //refer to http://stackoverflow.com/questions/17723626/entity-framework-remove-vs-deleteobject
            _dbSet.Remove(entity);
        }

        public void Delete(object id)
        {
            var entityToDelete = _dbSet.Find(id);
            //Generate delete statement
            //This will throw exception if there is reference constrain
            _context.Entry(entityToDelete).State = EntityState.Deleted;
            
        }
    }
}
