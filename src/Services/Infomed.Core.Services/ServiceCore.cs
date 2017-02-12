

namespace Infomed.Core.Services
{
    using Context.Sql;
    using Entities.Core;
    using Microsoft.EntityFrameworkCore;
    using System;
    public class ServiceCore<TEntity, TId> where TEntity : EntityCore<TId> // : IDisposable
    {
        protected readonly LibraryContext context;
        protected readonly DbSet<TEntity> DbSet;

        public ServiceCore(LibraryContext context)
        {
            this.context = context;
            this.DbSet = context.Set<TEntity>();
        }

        //public void Dispose()
        //{
        //    this.context.SaveChanges();
        //}
    }
}
