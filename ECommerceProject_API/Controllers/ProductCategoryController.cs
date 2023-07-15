using ECommerceProject_API.Interface;
using ECommerceProject_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        IProductCategoryRepository _categoryRepository;
        public ProductCategoryController(IProductCategoryRepository categroryRepository)
        {
            _categoryRepository = categroryRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var categories = _categoryRepository.GetAll();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
            
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            try
            {
                var category = _categoryRepository.GetCategory(id);
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        public IActionResult Add([FromBody] ProductCategory category)
        {
            try
            {
                bool isSaved = _categoryRepository.Add(category);
                if (isSaved)
                {
                    return Ok("Category has been saved.");
                }
                return BadRequest("Category saved failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Edit([FromBody] ProductCategory category)
        {
            try
            {
                bool isUpdated = _categoryRepository.Edit(category);
                if (isUpdated)
                {
                    return Ok("Category has been modified.");
                }
                return BadRequest("Category modified failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                bool isDeleted = _categoryRepository.Delete(id);
                if (isDeleted)
                {
                    return Ok("Category has been deleted.");
                }
                return BadRequest("Category deleted failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

 
}
