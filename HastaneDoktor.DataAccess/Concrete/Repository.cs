using HastaneDoktor.DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace HastaneDoktor.DataAccess.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        
        public TEntity Create(TEntity entities)
        {
            using (var DbContext = new HastaneDoktorDbContext())
            {
                DbContext.Set<TEntity>().Add(entities);
                DbContext.SaveChanges();
                return entities;
            }
        }

        public void Delete(int id)
        {
            using (var DbContext = new HastaneDoktorDbContext())
            {
                var deletedDb = DbContext.Set<TEntity>().Find(id);
                DbContext.Set<TEntity>().Remove(deletedDb);
                DbContext.SaveChanges();
            }

        }

        public IEnumerable<TEntity> GetAll()
        {
            using (var DbContext = new HastaneDoktorDbContext())
            {
                return DbContext.Set<TEntity>().ToList();
             }
        }

        public TEntity Update(TEntity entities)
        {
            using (var DbContext = new HastaneDoktorDbContext())
            {
                DbContext.Set<TEntity>().Update(entities);
                DbContext.SaveChanges();
                return entities;
            }
        }
    }
}
