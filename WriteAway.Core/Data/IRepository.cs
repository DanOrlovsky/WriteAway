using System;
using System.Collections.Generic;
using System.Text;

namespace WriteAway.Core.Data
{
    public interface IRepository<TEntity> 
    {

        TEntity GetById(object Id);

        ICollection<TEntity> GetAll();

        void Insert(TEntity entity);

        void Insert(IEnumerable<TEntity> entities);
    }
}
