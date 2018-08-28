using System;
using System.Collections.Generic;
using System.Text;
using WriteAway.Core;
using WriteAway.Core.Data;

namespace WriteAway.Data
{
    public class Repository<TEntity, T> : IRepository<TEntity, T> where TEntity : BaseEntity<T>
    {
        public ICollection<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(T Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
