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
        public FormCatalog()
        {
            InitializeComponent();
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.InitializeConstant();
            List<Product> temp = catalog.GetAll();
            //foreach (var product in catalog.GetAll())
            //    listViewCatalog.Items.Add(new ListViewItem(product.ToArray()));
            for (int i = 0; i < temp.Count; i++)
            {
                listViewCatalog.Items.Add(new ListViewItem(temp[i].ToArray()));
            }
            for (int i = 0; i < catalog.Count; i++)
            {
                listViewCatalog.Items.Add(new ListViewItem(catalog[i].ToArray()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
