using System;
using System.Windows.Forms;
using TestTaskHTT.Domain.Models;
using TestTaskHTT.Domain.Providers;
using TestTaskHTT.Storage.Context;

namespace TestTaskHTTView
{
    public partial class AddProductForm : Form
    {
        private readonly ShopContext _shopContext;

        public AddProductForm()
        {
            InitializeComponent();
        }

        public AddProductForm(ShopContext shopContext)
        {
            InitializeComponent();
            _shopContext = shopContext;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var productName = productNameTextBox.Text;
            var productFactory = productFactoryTextBox.Text;
            int categoryId = Int32.Parse(categoryIdTextBox.Text);

            CreateProduct(productName, productFactory, categoryId);

        }

        private void CreateProduct(string productName, string productFactory, int categoryId) 
        {
            using (ShopContext db = new ShopContext())
            {
                var categoryProvider = new CategoryProvider(db);

                var categoryById = categoryProvider.GetGategory(categoryId);

                ProductModel product = new ProductModel { Name = productName, Factory = productFactory, Category = categoryById };

                var productProvider = new ProductProvider(db);

                productProvider.CreateProduct(product);
            }
        }
    }
}
