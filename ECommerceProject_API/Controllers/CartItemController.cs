using ECommerceProject_API.Interface;
using ECommerceProject_API.Model;
using ECommerceProject_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        ICartItemRepository _cartItemRepository;
        public CartItemController(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var products = _cartItemRepository.GetAll();
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
                var products = _cartItemRepository.GetById(id);

                return Ok(products);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Add(CartItem cartItem)
        {
            try
            {
                bool isSaved = _cartItemRepository.Add(cartItem);
                if (isSaved)
                {
                    return Ok("CartItem has been saved.");
                }
                return BadRequest("Cartitem saved failed.");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CartItem cartItem)
        {
            if (id != cartItem.CartItemId)
                return BadRequest();

            if (_cartItemRepository.Update(cartItem))
                return NoContent();
            else
                return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_cartItemRepository.Delete(id))
                return NoContent();
            else
                return NotFound();
        }


    }
}
