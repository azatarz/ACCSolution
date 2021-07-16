using ACCSolution.Entities.Models.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACCSolution.Entities.Models.Contracts
{
    public interface ISubCategoryRepository : IRepositoryBase<SubCategory>
    {
        // IEnumerable<SubCategory> FindAll();

        IEnumerable<SubCategory> FindSubCategory(SubCategory Subcat);
        IEnumerable<SubCategory> FindSubCategoryByCategoryID(int id);


    }
}
