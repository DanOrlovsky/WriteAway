using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;
using WriteAway.Core;
using WriteAway.Core.Domain.Files;
using WriteAway.Core.Domain.Users;

namespace WriteAway.Data
{
    public class WriteAwayContext : DbContext, IDbContext
    {

        public WriteAwayContext(DbContextOptions options) : base(options)
        {

        }

        public virtual new DbSet<TEntity> Set<TEntity, T>() where TEntity : BaseEntity<T>
        {
            return base.Set<TEntity>();
        }

        public virtual string GenerateCreateScript()
        {
            return this.Database.GenerateCreateScript();
        }

        public void Detach<TEntity, T>(TEntity entity) where TEntity : BaseEntity<T>
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var entityEntry = this.Entry(entity);
            if (entityEntry == null)
                return;

            entityEntry.State = EntityState.Detached;
        }


    }
}
