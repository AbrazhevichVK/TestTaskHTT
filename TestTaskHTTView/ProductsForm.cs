using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestTaskHTT.Domain.Models;
using TestTaskHTT.Domain.Providers;
using TestTaskHTT.Storage.Context;
using TestTaskHTTView;
using TestTaskHTTView.ViewModels;

namespace TestTaskHTT
{
    public partial class ProductsForm : Form
    {
        private readonly Panel _mainFormTabsPanel;

        public ProductsForm(Panel mainFormTabsPanel)
        {
            _mainFormTabsPanel = mainFormTabsPanel;
            InitializeComponent();
            RefreshProductGrid();
        }

        private void RefreshProductGrid() 
        {
            using (ShopContext db = new ShopContext())
            {
                var provider = new ProductProvider(db);

                var productModels = provider.GetProducts();

                var viewProducts = productModels.Select(x => ConvertToProductViewModel(x));

                var bindingList = new BindingList<ProductViewModel>();

                foreach (var item in viewProducts)
                {
                    bindingList.Add(item);
                }

                dataGridViewProducts.DataSource = bindingList;
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm() { TopLevel = false, AutoScroll = true };
            _mainFormTabsPanel.Controls.Add(addProductForm);
            addProductForm.Show();
            addProductForm.BringToFront();
            WindowState = FormWindowState.Minimized;
        }

        private static ProductViewModel ConvertToProductViewModel(ProductModel model)
        {
            return new ProductViewModel()
            {
                Name = model.Name,
                Factory = model.Factory
            };
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshProductGrid();
        }
    }
}
