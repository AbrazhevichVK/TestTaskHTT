using System.Collections.Generic;
using System.Linq;
using TestTaskHTT.Storage.Context;
using TestTaskHTT.Storage.Models;

namespace TestTaskHTT.Storage.Providers
{
    public class CategoryDataModelProvider
    {
        private readonly ShopContext _shopContext;

        public CategoryDataModelProvider(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public IEnumerable<CategoryDataModel> GetCategories()
        {
            return _shopContext.Categories;
        }

        public CategoryDataModel GetCategory(int id)
        {
            return _shopContext.Categories.SingleOrDefault(x => x.Id == id);
        }

        public void CreateCategory(CategoryDataModel categoryDataModel)
        {
            _shopContext.Categories.Add(categoryDataModel);
            _shopContext.SaveChanges();
        }
    }
}

