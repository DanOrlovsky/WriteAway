using System;
using System.Collections.Generic;
using System.Text;

namespace WriteAway.Core.Data
{
    public interface IRepository<TEntity, T> where TEntity : BaseEntity<T>
    {
        /// <summary>
        /// Gets a single entity by its id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        TEntity GetById(T Id);


        /// <summary>
        /// Gets a collection of entities
        /// </summary>
        /// <returns></returns>
        ICollection<TEntity> GetAll();

        /// <summary>
        /// Inserts an entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);


        /// <summary>
        /// Inserts a collection of entities
        /// </summary>
        /// <param name="entities"></param>
        void Insert(IEnumerable<TEntity> entities);


        /// <summary>
        /// Updates an entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);


        /// <summary>
        /// Updates a range of entities
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<TEntity> entities);


        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);


        /// <summary>
        /// Deletes a range of entities
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<TEntity> entities);
    }
}
