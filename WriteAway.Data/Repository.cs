using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteAway.Core;
using WriteAway.Core.Data;
using WriteAway.Core.Routing;

namespace WriteAway.Data
{
    public class Repository<TEntity, T> : IRepository<TEntity, T> where TEntity : BaseEntity<T>
    {

        /// <summary>
        /// Context object injected in the constructor
        /// </summary>
        private readonly IDbContext _context;

        /// <summary>
        /// Set of the entities.
        /// </summary>
        private DbSet<TEntity> _entities;

        /// <summary>
        /// Returns an instance of the entities
        /// </summary>
        protected virtual DbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<TEntity, T>();

                return _entities;
            }
        }

        public Repository(IDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Rolls back entity changes on error
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        protected string GetFullErrorTextAndRollbackEntityChanges(DbUpdateException exception)
        {
            //rollback entity changes
            if (_context is DbContext dbContext)
            {
                var entries = dbContext.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified).ToList();

                entries.ForEach(entry => entry.State = EntityState.Unchanged);
            }

            _context.SaveChanges();
            return exception.ToString();
        }

        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return _entities;
        }

        /// <summary>
        /// Gets all async
        /// </summary>
        /// <returns></returns>
        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            var entities = await _entities.ToListAsync();
            return entities.AsQueryable();
        }

        /// <summary>
        /// Gets an entity by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(T id)
        {
            return _entities.Find(id);
        }

        /// <summary>
        /// Gets an Id asynchronously 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> GetByIdAsync(T id)
        {
            return await _entities.FindAsync(id);
        }

        /// <summary>
        /// Inserts an entity
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (typeof(ISluggable).IsAssignableFrom(typeof(TEntity)))
                (entity as ISluggable).UrlSlug.CreateNewSlug();

            try
            {
                _entities.Add(entity);
                _context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
        }

        /// <summary>
        /// Inserts a range of entities
        /// </summary>
        /// <param name="entities"></param>
        public void Insert(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach(TEntity entity in entities)
            {
                Insert(entity);
            }
        }

        /// <summary>
        /// Inserts an entity async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> InsertAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (typeof(ISluggable).IsAssignableFrom(typeof(TEntity)))
                (entity as ISluggable).UrlSlug.CreateNewSlug();

            try
            {
                await _entities.AddAsync(entity);
                _context.SaveChanges();
                return entity.Id;
            }
            catch (DbUpdateException exception)
            {
                throw new Exception(GetFullErrorTextAndRollbackEntityChanges(exception), exception);
            }
            
        }

        /// <summary>
        /// Inserts a range of entities, async
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task InsertAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (TEntity entity in entities)
            {
                await InsertAsync(entity);
            }
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

    }
}
