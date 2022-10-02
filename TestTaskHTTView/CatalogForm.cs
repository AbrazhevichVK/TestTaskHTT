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
    public partial class CatalogForm : Form
    {
        private readonly Panel _mainFormTabsPanel;

        public CatalogForm(Panel mainFormTabsPanel)
        {
            _mainFormTabsPanel = mainFormTabsPanel;
            InitializeComponent();
            RefreshCatalogGrid();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshCatalogGrid();
        }

        private void RefreshCatalogGrid() 
        {
            using (ShopContext db = new ShopContext())
            {
                var provider = new ProductProvider(db);

                var productModels = provider.GetProducts();

                var viewCatalog = productModels.Select(x => ConvertToProductViewModel(x));

                var bindingList = new BindingList<CatalogViewModel>();

                foreach (var item in viewCatalog)
                {
                    bindingList.Add(item);
                }

                dataGridViewCatalog.DataSource = bindingList;
            }
        }

        private static CatalogViewModel ConvertToProductViewModel(ProductModel model)
        {
            if (model.Category == null)
            {
                return new CatalogViewModel()
                {
                    Name = model.Name,
                    Factory = model.Factory,
                    Category = "Unknown"
                };
            }
            else 
            {
                return new CatalogViewModel()
                {
                    Name = model.Name,
                    Factory = model.Factory,
                    Category = model.Category.Name
                };
            }
        }
    }
}
