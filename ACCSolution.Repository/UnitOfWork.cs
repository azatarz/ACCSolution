using ACCSolution.Entities.Models.Contracts;
using ACCSolution.Entities.Models.Databases;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACCSolution.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly IConfiguration _configuration;

        private ICategoryRepository _categoryRepository;
        private ISubCategoryRepository _subcategoryRepository;

        public UnitOfWork(RepositoryContext databaseContext, IConfiguration configuration)
        {
            _repositoryContext = databaseContext;
            _configuration = configuration;
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository = _categoryRepository ?? new CategoryRepository(_repositoryContext);
            }
        }

        public ISubCategoryRepository SubCategoryRepository
        {
            get
            {
                return _subcategoryRepository = _subcategoryRepository ?? new SubCategoryRepository(_repositoryContext);
            }
        }

        public void SaveChanges()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
