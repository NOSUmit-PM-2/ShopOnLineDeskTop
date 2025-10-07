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
    public partial class FormBasket : Form
    {
        Basket basket;

        public FormBasket(Basket basket)
        {
            InitializeComponent();
            this.basket = basket;
            foreach (var item in basket.GetAll())
            {
                dataGridBasket.Rows.Add(item.ToArray());
            }
        }

        private void FormBasket_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product("sdfgdrqae", "ooo", 10);
            dataGridBasket.Rows.Add(p.ToArray());
        }

        private void dataGridBasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // увеличить количество
            if (e.ColumnIndex == 4)
            { 
                int row = e.RowIndex;
                int productId = Convert.ToInt32(dataGridBasket.Rows[row].Cells[0].Value);
                //product
                //product.Increase()
            }
                
            //if (] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show("");
            }
        }
    }
}
