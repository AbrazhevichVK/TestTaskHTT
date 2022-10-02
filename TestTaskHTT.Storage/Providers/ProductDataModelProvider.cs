using System.Collections.Generic;
using TestTaskHTT.Storage.Context;
using TestTaskHTT.Storage.Models;

namespace TestTaskHTT.Storage.Providers
{
    public class ProductDataModelProvider
    {
        private readonly ShopContext _shopContext;

        public ProductDataModelProvider(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public IEnumerable<ProductDataModel> GetProducts()
        {
            return _shopContext.Products;
        }

        public void CreateProduct(ProductDataModel productDataModel)
        {
            _shopContext.Products.Add(productDataModel);
            _shopContext.SaveChanges();
        }
    }
}
