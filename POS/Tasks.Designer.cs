namespace POS
{
    partial class Tasks
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
            btnAddCategory = new Button();
            btnAddProduct = new Button();
            btnAddStock = new Button();
            btnAddCustomer = new Button();
            SuspendLayout();
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.FromArgb(255, 224, 192);
            btnAddCategory.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCategory.Location = new Point(57, 47);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(202, 81);
            btnAddCategory.TabIndex = 7;
            btnAddCategory.Text = "Add Product Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(255, 224, 192);
            btnAddProduct.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(297, 47);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(212, 81);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product Entry";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddStock
            // 
            btnAddStock.BackColor = Color.FromArgb(255, 224, 192);
            btnAddStock.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStock.Location = new Point(57, 146);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(202, 77);
            btnAddStock.TabIndex = 9;
            btnAddStock.Text = "Add Stock Entry";
            btnAddStock.UseVisualStyleBackColor = false;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(255, 224, 192);
            btnAddCustomer.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCustomer.Location = new Point(297, 146);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(212, 77);
            btnAddCustomer.TabIndex = 10;
            btnAddCustomer.Text = "Add New Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(607, 369);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnAddStock);
            Controls.Add(btnAddProduct);
            Controls.Add(btnAddCategory);
            Name = "Tasks";
            Text = "Tasks";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddCategory;
        private Button btnAddProduct;
        private Button btnAddStock;
        private Button btnAddCustomer;
    }
}