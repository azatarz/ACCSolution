using ACCSolution.Entities.Models.Contracts;
using ACCSolution.Entities.Models.Databases;
using ACCSolution.Entities.Models.Menus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACCSolution.Repository
{
    public class CategoryRepository : RepositoryBase<subcategory>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {

        }



        public subcategory FindAllById(int id)
        {
            return Context.Set<subcategory>().Where(x => x.Id == id).FirstOrDefault();
        }


	}
}
