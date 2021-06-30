using System;
using System.Collections.Generic;
using System.Text;

namespace ACCSolution.Entities.Models.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        void InsertAbed(T entity);
        void UpdateAbed(T entity);
        void DeleteAbed(T entity);


        // find all
        // IEnumerable<T> FindAll();

    }
}
