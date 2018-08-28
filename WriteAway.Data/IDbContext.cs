using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WriteAway.Core;

namespace WriteAway.Data
{
    public interface IDbContext
    {

        DbSet<TEntity> Set<TEntity, T>() where TEntity : BaseEntity<T>;

        int SaveChanges();

        string GenerateCreateScript();

        void Detach<TEntity, T>(TEntity entity) where TEntity : BaseEntity<T>;
    }
}
