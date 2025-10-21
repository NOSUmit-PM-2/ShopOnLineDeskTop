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
            RepaintDataGridView();
        }

        private void RepaintDataGridView()
        {
            dataGridBasket.Rows.Clear();
            foreach (var item in basket.GetAll())
            {
                dataGridBasket.Rows.Add(item.ToArray());
            }
        }

        private void dataGridBasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // увеличить количество
            if (e.ColumnIndex == 4)
            { 
                int row = e.RowIndex;
                int productId = Convert.ToInt32(dataGridBasket.Rows[row].Cells[0].Value);
                //MessageBox.Show(productId.ToString());
                if (productId > 0)
                {
                    basket.Increase(productId);
                    RepaintDataGridView();
                }
            }
            // уменьшить количество
            if (e.ColumnIndex == 5)
            {
                int row = e.RowIndex;
                int productId = Convert.ToInt32(dataGridBasket.Rows[row].Cells[0].Value);
                if (productId > 0)
                {
                    basket.Decrease(productId);
                    RepaintDataGridView();
                }
            }


        }
    }
}
