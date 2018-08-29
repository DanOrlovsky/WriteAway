using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteAway.Core.Data
{
    public interface IRepository<TEntity, T> where TEntity : BaseEntity<T>
    {
        /// <summary>
        /// Gets a single entity by its id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        TEntity GetById(T id);


        /// <summary>
        /// Async method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(T id);

        /// <summary>
        /// Gets all entities Async
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<TEntity>> GetAllAsync();

        /// <summary>
        /// Gets a collection of entities
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Inserts an entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> InsertAsync(TEntity entity);

        /// <summary>
        /// Inserts a collection of entities
        /// </summary>
        /// <param name="entities"></param>
        void Insert(IEnumerable<TEntity> entities);

        /// <summary>
        /// Inserts a collection Async
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task InsertAsync(IEnumerable<TEntity> entities);

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
