using ECommerceProject_API.Data;
using ECommerceProject_API.Interface;
using ECommerceProject_API.Model;

namespace ECommerceProject_API.Repository
{

    public class ProductRepository: IProductRepository
    {
        ECommerceDbContext _dbContext;
        public ProductRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(Product product)
        {
            _dbContext.Products.Add(product);
            return _dbContext.SaveChanges() > 0;
                
        }

        public bool Delete(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(c=>c.ProductId == id);
            if (product != null)
            {
               product.IsDeleted = true;
               return _dbContext.SaveChanges() > 0;

            }
            return false;
        }

        public bool Edit(Product product)
        {
            _dbContext.Products.Update(product);
            return _dbContext.SaveChanges()>0;

        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.Where(c => !c.IsDeleted).ToList();
        }

        public Product GetProduct(int id)
        {
           var product = _dbContext.Products.FirstOrDefault(c=>c.ProductId == id);
            return product;
        }
    }
}
