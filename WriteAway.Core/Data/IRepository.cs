using System;
using System.Collections.Generic;
using System.Text;

namespace WriteAway.Core.Data
{
    public interface IRepository<TEntity, T> where TEntity : BaseEntity<T>
    {

        TEntity GetById(T Id);

        ICollection<TEntity> GetAll();

        void Insert(TEntity entity);

        void Insert(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
    }
}
