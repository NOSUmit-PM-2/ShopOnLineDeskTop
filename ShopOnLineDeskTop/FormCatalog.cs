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
            foreach (var product in catalog.GetAll())
                listViewCatalog.Items.Add(new ListViewItem(product.ToArray()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
