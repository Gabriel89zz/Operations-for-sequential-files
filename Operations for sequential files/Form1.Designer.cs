namespace Operations_for_sequential_files
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrice = new TextBox();
            txtProduct = new TextBox();
            txtQuantity = new TextBox();
            btnRegisterSale = new Button();
            btnLoadSales = new Button();
            rtbSales = new RichTextBox();
            btnSearchSale = new Button();
            btnDeleteSale = new Button();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft YaHei Light", 14F);
            txtPrice.Location = new Point(282, 171);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(226, 32);
            txtPrice.TabIndex = 1;
            // 
            // txtProduct
            // 
            txtProduct.Font = new Font("Microsoft YaHei Light", 14F);
            txtProduct.Location = new Point(282, 67);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(226, 32);
            txtProduct.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft YaHei Light", 14F);
            txtQuantity.Location = new Point(282, 117);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(226, 32);
            txtQuantity.TabIndex = 3;
            // 
            // btnRegisterSale
            // 
            btnRegisterSale.Location = new Point(210, 235);
            btnRegisterSale.Name = "btnRegisterSale";
            btnRegisterSale.Size = new Size(87, 33);
            btnRegisterSale.TabIndex = 4;
            btnRegisterSale.Text = "Register Sale";
            btnRegisterSale.UseVisualStyleBackColor = true;
            btnRegisterSale.Click += btnRegisterSale_Click;
            // 
            // btnLoadSales
            // 
            btnLoadSales.Location = new Point(303, 235);
            btnLoadSales.Name = "btnLoadSales";
            btnLoadSales.Size = new Size(87, 33);
            btnLoadSales.TabIndex = 5;
            btnLoadSales.Text = "Load Sales";
            btnLoadSales.UseVisualStyleBackColor = true;
            btnLoadSales.Click += btnLoadSales_Click;
            // 
            // rtbSales
            // 
            rtbSales.Location = new Point(208, 283);
            rtbSales.Name = "rtbSales";
            rtbSales.Size = new Size(367, 140);
            rtbSales.TabIndex = 6;
            rtbSales.Text = "";
            // 
            // btnSearchSale
            // 
            btnSearchSale.Location = new Point(488, 235);
            btnSearchSale.Name = "btnSearchSale";
            btnSearchSale.Size = new Size(87, 33);
            btnSearchSale.TabIndex = 8;
            btnSearchSale.Text = "Search Sale";
            btnSearchSale.UseVisualStyleBackColor = true;
            btnSearchSale.Click += btnSearchSale_Click;
            // 
            // btnDeleteSale
            // 
            btnDeleteSale.Location = new Point(395, 235);
            btnDeleteSale.Name = "btnDeleteSale";
            btnDeleteSale.Size = new Size(87, 33);
            btnDeleteSale.TabIndex = 7;
            btnDeleteSale.Text = "Delete Sale";
            btnDeleteSale.UseVisualStyleBackColor = true;
            btnDeleteSale.Click += btnDeleteSale_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchSale);
            Controls.Add(btnDeleteSale);
            Controls.Add(rtbSales);
            Controls.Add(btnLoadSales);
            Controls.Add(btnRegisterSale);
            Controls.Add(txtQuantity);
            Controls.Add(txtProduct);
            Controls.Add(txtPrice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrice;
        private TextBox txtProduct;
        private TextBox txtQuantity;
        private Button btnRegisterSale;
        private Button btnLoadSales;
        private RichTextBox rtbSales;
        private Button btnSearchSale;
        private Button btnDeleteSale;
    }
}
