using System.Collections.Generic;
using TestTaskHTT.Domain.Models;
using TestTaskHTT.Storage.Context;
using TestTaskHTT.Storage.Models;
using TestTaskHTT.Storage.Providers;

namespace TestTaskHTT.Domain.Providers
{
    public sealed class CategoryProvider
    {
        private readonly ShopContext _shopContext;

        public CategoryProvider(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public IEnumerable<CategoryModel> GetCategories()
        {
            var provider = new CategoryDataModelProvider(_shopContext);

            var categoriesData = provider.GetCategories();

            var categories = new List<CategoryModel>();

            foreach (var item in categoriesData)
            {
                var category = ConvertToCategoryModel(item);

                categories.Add(category);
            }

            return categories;
        }

        public CategoryModel GetGategory(int id)
        {
            var provider = new CategoryDataModelProvider(_shopContext);

            var categoryData = provider.GetCategory(id);

            return ConvertToCategoryModel(categoryData);
        }

        public void CreateCategory(CategoryModel categoryModel)
        {
            var provider = new CategoryDataModelProvider(_shopContext);

            var categoryData = ConvertToCategoryDataModel(categoryModel);

            provider.CreateCategory(categoryData);
        }

        private CategoryDataModel ConvertToCategoryDataModel(CategoryModel categoryModel)
        {
            return new CategoryDataModel()
            {
                Id = categoryModel.Id,
                Name = categoryModel.Name
            };
        }

        private CategoryModel ConvertToCategoryModel(CategoryDataModel categoryDataModel)
        {
            return new CategoryModel()
            {
                Id = categoryDataModel.Id,
                Name = categoryDataModel.Name
            };
        }
    }
}
