using ECommerceProject_API.Model;

namespace ECommerceProject_API.Interface
{
    public interface IProductCategoryRepository
    {
        List<ProductCategory> GetAll();
        ProductCategory GetCategory(int id);
        bool Add(ProductCategory category);
        bool Edit(ProductCategory category);
        bool Delete(int id);
    }
}
