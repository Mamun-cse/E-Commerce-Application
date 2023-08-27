using ECommerceProject_API.Model;

namespace ECommerceProject_API.Interface
{
    public interface ICartItemRepository
    {
        List<CartItem> GetAll();
        CartItem GetById(int id);
        bool Add(CartItem cartItem);
        bool Update(CartItem cartItem);
        bool Delete(int id);

    }
}
