namespace ShopOnLineDeskTop
{
    partial class FormBasket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridBasket = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDecrease = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBasket
            // 
            this.dataGridBasket.AllowUserToDeleteRows = false;
            this.dataGridBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnPrice,
            this.ColumnCount,
            this.ColumnAdd,
            this.ColumnDecrease});
            this.dataGridBasket.Location = new System.Drawing.Point(48, 52);
            this.dataGridBasket.Name = "dataGridBasket";
            this.dataGridBasket.ReadOnly = true;
            this.dataGridBasket.Size = new System.Drawing.Size(560, 150);
            this.dataGridBasket.TabIndex = 0;
            this.dataGridBasket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBasket_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Продукт";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnCount
            // 
            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "+";
            this.ColumnAdd.Name = "ColumnAdd";
            this.ColumnAdd.ReadOnly = true;
            this.ColumnAdd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAdd.Text = "+";
            this.ColumnAdd.ToolTipText = "Увеличить количество";
            this.ColumnAdd.UseColumnTextForButtonValue = true;
            this.ColumnAdd.Width = 30;
            // 
            // ColumnDecrease
            // 
            this.ColumnDecrease.HeaderText = "-";
            this.ColumnDecrease.Name = "ColumnDecrease";
            this.ColumnDecrease.ReadOnly = true;
            this.ColumnDecrease.Text = "-";
            this.ColumnDecrease.ToolTipText = "Уменьшить количество";
            this.ColumnDecrease.UseColumnTextForButtonValue = true;
            this.ColumnDecrease.Width = 30;
            // 
            // FormBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.dataGridBasket);
            this.Name = "FormBasket";
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBasket)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAdd;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDecrease;
    }
}