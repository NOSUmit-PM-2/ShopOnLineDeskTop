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

        public FormCatalog()
        {
            InitializeComponent();
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            catalog.InitializeConstant();
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
    }
}
