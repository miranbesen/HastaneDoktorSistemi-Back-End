using System.Collections.Generic;

namespace HastaneDoktor.DataAccess.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();

        TEntity Create(TEntity entities);

        TEntity Update(TEntity entities);

        void Delete(int id);

    }
}
