using ACCSolution.Entities.Models.Contracts;
using ACCSolution.Entities.Models.Databases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACCSolution.Repository
{
    public class RepositoryBase<X> : IRepositoryBase<X> where X : class
    {
        protected readonly RepositoryContext Context;
        private DbSet<X> entities;

        public RepositoryBase(RepositoryContext context)
        {
            Context = context;
            entities = context.Set<X>();
        }

        public void Delete(X entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            // if master -> search for children
       // func to search for childrne
       // then delete the children
       // then  delete parent
       // if table typeof(X) = categoriie -> check if column exist

            entities.Remove(entity);
        }

		public IEnumerable<X> FindAll()
		{
            return Context.Set<X>().AsEnumerable();
        }

		//public IEnumerable<T> FindAll()
		//{
		//    throw new NotImplementedException();
		//}

		public void Insert(X entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");



            entities.Add(entity);
        }

        public void Update(X entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            entities.Update(entity);
        }
    }
}
