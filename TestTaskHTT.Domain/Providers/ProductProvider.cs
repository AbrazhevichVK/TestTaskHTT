using System.Collections.Generic;
using System.Linq;
using TestTaskHTT.Domain.Models;
using TestTaskHTT.Storage.Context;
using TestTaskHTT.Storage.Models;
using TestTaskHTT.Storage.Providers;

namespace TestTaskHTT.Domain.Providers
{
    public class ProductProvider
    {
        private readonly ShopContext _shopContext;

        public ProductProvider(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            var productProvider = new ProductDataModelProvider(_shopContext);
            var productsData = productProvider.GetProducts();

            var categoryProvider = new CategoryProvider(_shopContext);
            var categories = categoryProvider.GetCategories();

            return productsData.Select(x => ConvertToProductModel(x,
                categories.FirstOrDefault(y => y.Id == x.CategoryId)));
        }

        public void CreateProduct(ProductModel productModel)
        {
            var productProvider = new ProductDataModelProvider(_shopContext);

            var productData = ConvertToProductDataModel(productModel);

            productProvider.CreateProduct(productData);
        }

        private ProductDataModel ConvertToProductDataModel(ProductModel productModel)
        {
            return new ProductDataModel()
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Factory = productModel.Factory,
                CategoryId = productModel.Category.Id
            };
        }

        private ProductModel ConvertToProductModel(ProductDataModel productDataModel, CategoryModel categoryModel)
        {
            return new ProductModel()
            {
               Id = productDataModel.Id,
               Name= productDataModel.Name,
               Factory = productDataModel.Factory,
               Category = categoryModel
            };
        }
    }
}
