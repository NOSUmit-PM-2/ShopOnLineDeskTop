namespace ShopOnLineDeskTop
{
    partial class FormCatalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewCatalog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSelectProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCatalog
            // 
            this.listViewCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCatalog.GridLines = true;
            this.listViewCatalog.HideSelection = false;
            this.listViewCatalog.Location = new System.Drawing.Point(38, 75);
            this.listViewCatalog.Name = "listViewCatalog";
            this.listViewCatalog.Size = new System.Drawing.Size(282, 306);
            this.listViewCatalog.TabIndex = 0;
            this.listViewCatalog.UseCompatibleStateImageBehavior = false;
            this.listViewCatalog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Описание";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цена";
            // 
            // buttonSelectProduct
            // 
            this.buttonSelectProduct.Location = new System.Drawing.Point(38, 398);
            this.buttonSelectProduct.Name = "buttonSelectProduct";
            this.buttonSelectProduct.Size = new System.Drawing.Size(282, 23);
            this.buttonSelectProduct.TabIndex = 1;
            this.buttonSelectProduct.Text = "Добавить в корзину";
            this.buttonSelectProduct.UseVisualStyleBackColor = true;
            this.buttonSelectProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Каталог продуктов";
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectProduct);
            this.Controls.Add(this.listViewCatalog);
            this.Name = "FormCatalog";
            this.Text = "Онлайн магазин";
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCatalog;
        private System.Windows.Forms.Button buttonSelectProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
    }
}

