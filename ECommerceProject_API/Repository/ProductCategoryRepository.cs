using ECommerceProject_API.Data;
using ECommerceProject_API.Interface;
using ECommerceProject_API.Model;

namespace ECommerceProject_API.Repository
{
    public class ProductCategoryRepository: IProductCategoryRepository
    {
        ECommerceDbContext _dbContext;
        public ProductCategoryRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(ProductCategory category)
        {

            _dbContext.Categories.Add(category);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {

            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                category.IsDeleted = true;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }
        public bool Edit(ProductCategory category)
        {
            _dbContext.Categories.Update(category);
            return _dbContext.SaveChanges() > 0;
        }

        public List<ProductCategory> GetAll()
        {
            return _dbContext.Categories.Where(c => !c.IsDeleted).ToList();
        }

        public  ProductCategory GetCategory(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            //if(category==null)
            //{
            //    return new Category();
            //}
            return category;
        }
    }

    
}
