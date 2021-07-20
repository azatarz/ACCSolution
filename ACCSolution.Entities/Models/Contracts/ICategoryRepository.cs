using ACCSolution.Entities.Models.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACCSolution.Entities.Models.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<subcategory>
    {
        // IEnumerable<Category> FindAll();
        subcategory FindAllById(int id);

        
    }
}
