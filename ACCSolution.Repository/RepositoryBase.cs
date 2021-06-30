using ACCSolution.Entities.Models.Contracts;
using ACCSolution.Entities.Models.Databases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACCSolution.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly RepositoryContext Context;
        private DbSet<T> entities;

        public RepositoryBase(RepositoryContext context)
        {
            Context = context;
            entities = context.Set<T>();
        }

        public void DeleteAbed(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entities.Remove(entity);
        }

        //public IEnumerable<T> FindAll()
        //{
        //    throw new NotImplementedException();
        //}

        public void InsertAbed(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entities.Add(entity);
        }

        public void UpdateAbed(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entities.Update(entity);
        }
    }
}
