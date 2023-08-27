using ECommerceProject_API.Data;
using ECommerceProject_API.Interface;
using ECommerceProject_API.Model;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject_API.Repository
{
    public class CartItemRepository : ICartItemRepository
    {
        ECommerceDbContext _dbcontext;
        public CartItemRepository(ECommerceDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool Add(CartItem cartItem)
        {
            _dbcontext.CartItems.Add(cartItem);
            return _dbcontext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var existingCartItem = _dbcontext.CartItems.FirstOrDefault(c => c.CartItemId == id);
            if (existingCartItem == null)
                return false;

            _dbcontext.Remove(existingCartItem);
            return true;
        }

        public List<CartItem> GetAll()
        {
            return _dbcontext.CartItems.ToList();

        }

        public CartItem GetById(int id)
        {
            var cartItem = _dbcontext.CartItems.FirstOrDefault(c=>c.CartItemId==id);
            return cartItem;
        }

        public bool Update(CartItem cartItem)
        {
            var existingCartItem = _dbcontext.CartItems.FirstOrDefault(c => c.CartItemId == cartItem.CartItemId);
            if (existingCartItem == null)
                return false;

            existingCartItem.ProductId = cartItem.ProductId;
            existingCartItem.Quantity = cartItem.Quantity;
            return true;
        }
    }
}
