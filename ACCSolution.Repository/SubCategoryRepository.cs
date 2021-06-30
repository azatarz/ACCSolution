using ACCSolution.Entities.Models.Contracts;
using ACCSolution.Entities.Models.Databases;
using ACCSolution.Entities.Models.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACCSolution.Repository
{
    public class SubCategoryRepository : RepositoryBase<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(RepositoryContext context) : base(context)
        {

        }

        public IEnumerable<SubCategory> FindAll()
        {
            return Context.Set<SubCategory>().AsEnumerable();
        }
    
    }
}
