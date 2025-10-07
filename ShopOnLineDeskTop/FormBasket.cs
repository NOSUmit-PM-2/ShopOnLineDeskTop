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
        public FormBasket()
        {
            InitializeComponent();
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
            // var button = sender as DataGridViewButtonColumn;
            if (sender != null)
                MessageBox.Show(sender.ToString());
            else
                MessageBox.Show("!!!");

            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show("Нажата кнопка");
            }
        }
    }
}
