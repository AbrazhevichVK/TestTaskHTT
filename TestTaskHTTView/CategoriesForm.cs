using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestTaskHTT.Domain.Models;
using TestTaskHTT.Domain.Providers;
using TestTaskHTT.Storage.Context;
using TestTaskHTTView.ViewModels;

namespace TestTaskHTT
{
    public partial class CategoriesForm : Form
    {
        private readonly Panel _mainFormTabsPanel;

        public CategoriesForm(Panel mainFormTabsPanel)
        {
            _mainFormTabsPanel = mainFormTabsPanel;
            InitializeComponent();
            RefreshCategoryGrid();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var categoryName = createCategoryTextBox.Text;
            CreateCategory(categoryName);
            RefreshCategoryGrid();

        }

        private void RefreshCategoryGrid() 
        {
            using (ShopContext db = new ShopContext())
            {
                var provider = new CategoryProvider(db);

                var categoryModels = provider.GetCategories();

                var viewCategories = categoryModels.Select(x => ConvertToCategoryViewModel(x));

                var bindingList = new BindingList<CategoryViewModel>();

                foreach (var item in viewCategories)
                {
                    bindingList.Add(item);
                }

                dataGridViewCategories.DataSource = bindingList;
            }
        }

        private void CreateCategory(string categoryName)
        {
            using (ShopContext db = new ShopContext())
            {
                CategoryModel category = new CategoryModel { Name = categoryName };

                var provider = new CategoryProvider(db);

                provider.CreateCategory(category);
            }
        }

        private static CategoryViewModel ConvertToCategoryViewModel(CategoryModel model)
        {
            return new CategoryViewModel()
            {
               Name = model.Name
            };
        }
    }
}
