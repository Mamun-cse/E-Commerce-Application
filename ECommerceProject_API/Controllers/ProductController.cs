using ECommerceProject_API.Interface;
using ECommerceProject_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var products = _productRepository.GetAll();
                return Ok(products);
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
                var products = _productRepository.GetProduct(id);

                return Ok(products);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        


        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {

            
            try
            {
                bool isSaved = _productRepository.Add(product);
                if (isSaved)
                {
                    return Ok("Product has been saved.");
                }
                return BadRequest("Product saved failed.");    

            }
             catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
