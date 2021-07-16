using System;
using System.Collections.Generic;
using System.Text;

namespace ACCSolution.Entities.Models.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        IEnumerable<T> FindAll();
        // find all
        // IEnumerable<T> FindAll();

    }
}
