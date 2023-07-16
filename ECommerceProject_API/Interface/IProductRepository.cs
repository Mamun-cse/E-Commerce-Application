using ECommerceProject_API.Model;

namespace ECommerceProject_API.Interface
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetProduct(int id);
        bool Add(Product product);
        bool Edit(Product product);
        bool Delete(int id);


    }
}
