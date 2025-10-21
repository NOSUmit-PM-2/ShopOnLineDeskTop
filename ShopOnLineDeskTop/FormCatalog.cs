using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOnLineDeskTop
{
    public partial class FormCatalog : Form
    {
        Basket basket = new Basket();
        Catalog catalog = new Catalog();

        delegate List<Product> FilerFunction();
        FilerFunction[] filerFunctions = null;

        public FormCatalog()
        {
            InitializeComponent();
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            catalog.InitializeConstant();
            // создать список фильтров
            filerFunctions = new FilerFunction[] { catalog.GetAll, catalog.GetLowPrice, catalog.GetPhones}; 

            List<Product> temp = catalog.GetAll();
            //foreach (var product in catalog.GetAll())
            //    listViewCatalog.Items.Add(new ListViewItem(product.ToArray()));
            for (int i = 0; i < temp.Count; i++)
            {
                listViewCatalog.Items.Add(new ListViewItem(temp[i].ToArray()));
            }
        }

        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listViewCatalog.SelectedItems[0].Text);
            //MessageBox.Show(id.ToString());
            Product product = catalog.GetById(id);
            basket.Add(product);
        }

        private void ToolStripMenuItemBasket_Click(object sender, EventArgs e)
        {
            FormBasket basketForm = new FormBasket(basket);
            basketForm.ShowDialog();
        }

        void showProducts(FilerFunction filerFunction)
        {
            var products = filerFunction();
            listViewCatalog.Items.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                listViewCatalog.Items.Add(new ListViewItem(products[i].ToArray()));
            }
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            showProducts(filerFunctions[comboBoxFilters.SelectedIndex]);
        }

        private void listViewCatalog_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 3) showProducts(catalog.SortByPrice);
            if (e.Column == 1) showProducts(catalog.SortByName);

        }
    }
}
