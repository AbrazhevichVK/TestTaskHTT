using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestTaskHTT
{
    public partial class MainForm : Form
    {
        private readonly Color _highlightButtonColor = Color.Yellow;

        public MainForm()
        {
            InitializeComponent();
        }

        private void TestTaskHTT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelCatalog_Click(object sender, EventArgs e)
        {
            var catalogForm = new CatalogForm(panelFormArea) { TopLevel = false, AutoScroll = true };
            panelFormArea.Controls.Add(catalogForm);
            catalogForm.Show();
            catalogForm.BringToFront();
        }

        private void labelCatalog_MouseHover(object sender, EventArgs e)
        {
            labelCatalog.ForeColor = _highlightButtonColor;
            labelCatalog.Font = new Font(labelCatalog.Font, FontStyle.Bold);
        }

        private void labelCatalog_MouseLeave(object sender, EventArgs e)
        {
            labelCatalog.ForeColor = Color.White;
            labelCatalog.Font = new Font(labelCatalog.Font, FontStyle.Regular);
        }

        private void labelProducts_MouseClick(object sender, MouseEventArgs e)
        {
            var productsForm = new ProductsForm(panelFormArea) { TopLevel = false, AutoScroll = true };
            panelFormArea.Controls.Add(productsForm);
            productsForm.Show();
            productsForm.BringToFront();
        }

        private void labelProducts_MouseHover(object sender, EventArgs e)
        {
            labelProducts.ForeColor = _highlightButtonColor;
            labelProducts.Font = new Font(labelProducts.Font, FontStyle.Bold);
        }

        private void labelProducts_MouseLeave(object sender, EventArgs e)
        {
            labelProducts.ForeColor = Color.White;
            labelProducts.Font = new Font(labelProducts.Font, FontStyle.Regular);
        }

        private void labelCategories_MouseClick(object sender, MouseEventArgs e)
        {
            var categoriesForm = new CategoriesForm(panelFormArea) { TopLevel = false, AutoScroll = true };
            panelFormArea.Controls.Add(categoriesForm);
            categoriesForm.Show();
            categoriesForm.BringToFront();
        }

        private void labelCategories_MouseHover(object sender, EventArgs e)
        {
            labelCategories.ForeColor = _highlightButtonColor;
            labelCategories.Font = new Font(labelCategories.Font, FontStyle.Bold);
        }

        private void labelCategories_MouseLeave(object sender, EventArgs e)
        {
            labelCategories.ForeColor = Color.White;
            labelCategories.Font = new Font(labelCategories.Font, FontStyle.Regular);
        }
    }
}
