using ACCSolution.Entities.Models.Contracts;
using ACCSolution.Entities.Models.Databases;
using ACCSolution.Entities.Models.Menus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ACCSolution.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {

        }

        public IEnumerable<Category> FindAll()
        {
            return Context.Set<Category>()
                .Include(x => x.SubCategories)
                .AsEnumerable();
        }

        public Category FindAllById(int id)
        {
            return Context.Set<Category>().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
