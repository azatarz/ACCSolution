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
    public class SubCategoriesController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public SubCategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public ActionResult<List<SubCategory>> GetAllSubCategories()
        {
            var allEntities = _unitOfWork.SubCategoryRepository.FindAll().ToList();
            
            if (allEntities.Count > 0)
                return Ok(allEntities);

            return NoContent();
        }
    }
}
