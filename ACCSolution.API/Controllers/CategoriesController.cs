using ACCSolution.Entities.Models.Contracts;
using ACCSolution.Entities.Models.Menus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACCSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private IUnitOfWork _unitOfWork;

        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public ActionResult<List<Category>> GetAllCategories()
        {
            var allCategories = _unitOfWork.CategoryRepository
                .FindAll()
                
                .ToList();
            if (allCategories.Count > 0)
                return Ok(allCategories);

            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<List<Category>> GetCategoryById(int id)
        {
            var allCategories = _unitOfWork.CategoryRepository.FindAllById(id);
            if (allCategories != null)
                return Ok(allCategories);

            return NoContent();
        }

    }
}
