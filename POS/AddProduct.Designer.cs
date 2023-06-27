namespace POS
{
    partial class AddProduct
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
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtVATPercent = new TextBox();
            txtDescription = new TextBox();
            rdBtnDiscountYes = new RadioButton();
            rdBtnDiscountNo = new RadioButton();
            AllowDiscountsGrpBox = new GroupBox();
            comboBoxCategory = new ComboBox();
            btnAddProduct = new Button();
            btnGoBack = new Button();
            AllowDiscountsGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 224, 192);
            txtName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(12, 22);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(202, 34);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(255, 224, 192);
            txtPrice.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(12, 72);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(202, 34);
            txtPrice.TabIndex = 1;
            // 
            // txtVATPercent
            // 
            txtVATPercent.BackColor = Color.FromArgb(255, 224, 192);
            txtVATPercent.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtVATPercent.Location = new Point(12, 122);
            txtVATPercent.Name = "txtVATPercent";
            txtVATPercent.PlaceholderText = "VAT Percent";
            txtVATPercent.Size = new Size(202, 34);
            txtVATPercent.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(255, 224, 192);
            txtDescription.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(261, 22);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(303, 34);
            txtDescription.TabIndex = 3;
            // 
            // rdBtnDiscountYes
            // 
            rdBtnDiscountYes.AutoSize = true;
            rdBtnDiscountYes.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdBtnDiscountYes.Location = new Point(15, 30);
            rdBtnDiscountYes.Name = "rdBtnDiscountYes";
            rdBtnDiscountYes.Size = new Size(51, 24);
            rdBtnDiscountYes.TabIndex = 4;
            rdBtnDiscountYes.TabStop = true;
            rdBtnDiscountYes.Text = "Yes";
            rdBtnDiscountYes.UseVisualStyleBackColor = true;
            rdBtnDiscountYes.CheckedChanged += rdBtnDiscountYes_CheckedChanged;
            // 
            // rdBtnDiscountNo
            // 
            rdBtnDiscountNo.AutoSize = true;
            rdBtnDiscountNo.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdBtnDiscountNo.Location = new Point(72, 30);
            rdBtnDiscountNo.Name = "rdBtnDiscountNo";
            rdBtnDiscountNo.Size = new Size(48, 24);
            rdBtnDiscountNo.TabIndex = 5;
            rdBtnDiscountNo.TabStop = true;
            rdBtnDiscountNo.Text = "No";
            rdBtnDiscountNo.UseVisualStyleBackColor = true;
            // 
            // AllowDiscountsGrpBox
            // 
            AllowDiscountsGrpBox.Controls.Add(rdBtnDiscountYes);
            AllowDiscountsGrpBox.Controls.Add(rdBtnDiscountNo);
            AllowDiscountsGrpBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AllowDiscountsGrpBox.ForeColor = Color.Firebrick;
            AllowDiscountsGrpBox.Location = new Point(240, 122);
            AllowDiscountsGrpBox.Name = "AllowDiscountsGrpBox";
            AllowDiscountsGrpBox.Size = new Size(333, 60);
            AllowDiscountsGrpBox.TabIndex = 7;
            AllowDiscountsGrpBox.TabStop = false;
            AllowDiscountsGrpBox.Text = "Allow Discounts For This Product?";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.FromArgb(255, 224, 192);
            comboBoxCategory.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.ForeColor = Color.DimGray;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(261, 72);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(213, 36);
            comboBoxCategory.TabIndex = 8;
            comboBoxCategory.Text = "Choose Category";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.Location = new Point(12, 180);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(151, 39);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoBack.Location = new Point(422, 196);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(151, 39);
            btnGoBack.TabIndex = 10;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(599, 247);
            Controls.Add(btnGoBack);
            Controls.Add(btnAddProduct);
            Controls.Add(comboBoxCategory);
            Controls.Add(AllowDiscountsGrpBox);
            Controls.Add(txtDescription);
            Controls.Add(txtVATPercent);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Name = "AddProduct";
            Text = "AddProduct";
            AllowDiscountsGrpBox.ResumeLayout(false);
            AllowDiscountsGrpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtVATPercent;
        private TextBox txtDescription;
        private RadioButton rdBtnDiscountYes;
        private RadioButton rdBtnDiscountNo;
        private GroupBox AllowDiscountsGrpBox;
        private ComboBox comboBoxCategory;
        private Button btnAddProduct;
        private Button btnGoBack;
    }
}