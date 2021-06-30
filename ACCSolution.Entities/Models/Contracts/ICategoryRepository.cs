using ACCSolution.Entities.Models.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACCSolution.Entities.Models.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        IEnumerable<Category> FindAll();
        Category FindAllById(int id);
    }
}
