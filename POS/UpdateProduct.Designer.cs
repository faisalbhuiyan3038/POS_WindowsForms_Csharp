namespace POS
{
    partial class UpdateProduct
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
            txtExistingName = new TextBox();
            txtNewName = new TextBox();
            txtNewPrice = new TextBox();
            txtNewVATPercent = new TextBox();
            txtNewDescription = new TextBox();
            comboBoxCategory = new ComboBox();
            AllowDiscountsGrpBox = new GroupBox();
            rdBtnDiscountYes = new RadioButton();
            rdBtnDiscountNo = new RadioButton();
            btnLoadExistingData = new Button();
            btnUpdateProduct = new Button();
            btnGoBack = new Button();
            AllowDiscountsGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // txtExistingName
            // 
            txtExistingName.BackColor = Color.FromArgb(255, 224, 192);
            txtExistingName.BorderStyle = BorderStyle.None;
            txtExistingName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtExistingName.Location = new Point(26, 22);
            txtExistingName.Name = "txtExistingName";
            txtExistingName.PlaceholderText = "Existing Name";
            txtExistingName.Size = new Size(274, 27);
            txtExistingName.TabIndex = 7;
            // 
            // txtNewName
            // 
            txtNewName.BackColor = Color.FromArgb(255, 224, 192);
            txtNewName.BorderStyle = BorderStyle.None;
            txtNewName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(361, 22);
            txtNewName.Name = "txtNewName";
            txtNewName.PlaceholderText = "New Name";
            txtNewName.Size = new Size(274, 27);
            txtNewName.TabIndex = 8;
            // 
            // txtNewPrice
            // 
            txtNewPrice.BackColor = Color.FromArgb(255, 224, 192);
            txtNewPrice.BorderStyle = BorderStyle.None;
            txtNewPrice.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPrice.Location = new Point(26, 128);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.PlaceholderText = "New Price";
            txtNewPrice.Size = new Size(274, 27);
            txtNewPrice.TabIndex = 9;
            // 
            // txtNewVATPercent
            // 
            txtNewVATPercent.BackColor = Color.FromArgb(255, 224, 192);
            txtNewVATPercent.BorderStyle = BorderStyle.None;
            txtNewVATPercent.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewVATPercent.Location = new Point(361, 79);
            txtNewVATPercent.Name = "txtNewVATPercent";
            txtNewVATPercent.PlaceholderText = "New VAT Percent";
            txtNewVATPercent.Size = new Size(274, 27);
            txtNewVATPercent.TabIndex = 10;
            // 
            // txtNewDescription
            // 
            txtNewDescription.BackColor = Color.FromArgb(255, 224, 192);
            txtNewDescription.BorderStyle = BorderStyle.None;
            txtNewDescription.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewDescription.Location = new Point(26, 79);
            txtNewDescription.Name = "txtNewDescription";
            txtNewDescription.PlaceholderText = "New Description";
            txtNewDescription.Size = new Size(274, 27);
            txtNewDescription.TabIndex = 11;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.FromArgb(255, 224, 192);
            comboBoxCategory.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.ForeColor = SystemColors.Desktop;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(361, 128);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(259, 36);
            comboBoxCategory.TabIndex = 12;
            comboBoxCategory.Text = "Choose New Category";
            // 
            // AllowDiscountsGrpBox
            // 
            AllowDiscountsGrpBox.Controls.Add(rdBtnDiscountYes);
            AllowDiscountsGrpBox.Controls.Add(rdBtnDiscountNo);
            AllowDiscountsGrpBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AllowDiscountsGrpBox.ForeColor = Color.Firebrick;
            AllowDiscountsGrpBox.Location = new Point(26, 193);
            AllowDiscountsGrpBox.Name = "AllowDiscountsGrpBox";
            AllowDiscountsGrpBox.Size = new Size(333, 60);
            AllowDiscountsGrpBox.TabIndex = 13;
            AllowDiscountsGrpBox.TabStop = false;
            AllowDiscountsGrpBox.Text = "Allow Discounts For This Product?";
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
            // btnLoadExistingData
            // 
            btnLoadExistingData.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadExistingData.Location = new Point(26, 283);
            btnLoadExistingData.Name = "btnLoadExistingData";
            btnLoadExistingData.Size = new Size(224, 38);
            btnLoadExistingData.TabIndex = 14;
            btnLoadExistingData.Text = "Load Existing Data";
            btnLoadExistingData.UseVisualStyleBackColor = true;
            btnLoadExistingData.Click += btnLoadExistingData_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateProduct.Location = new Point(279, 283);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(224, 38);
            btnUpdateProduct.TabIndex = 15;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoBack.Location = new Point(539, 283);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(127, 38);
            btnGoBack.TabIndex = 16;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(710, 359);
            Controls.Add(btnGoBack);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnLoadExistingData);
            Controls.Add(AllowDiscountsGrpBox);
            Controls.Add(comboBoxCategory);
            Controls.Add(txtNewDescription);
            Controls.Add(txtNewVATPercent);
            Controls.Add(txtNewPrice);
            Controls.Add(txtNewName);
            Controls.Add(txtExistingName);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            AllowDiscountsGrpBox.ResumeLayout(false);
            AllowDiscountsGrpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExistingName;
        private TextBox txtNewName;
        private TextBox txtNewPrice;
        private TextBox txtNewVATPercent;
        private TextBox txtNewDescription;
        private ComboBox comboBoxCategory;
        private GroupBox AllowDiscountsGrpBox;
        private RadioButton rdBtnDiscountYes;
        private RadioButton rdBtnDiscountNo;
        private Button btnLoadExistingData;
        private Button btnUpdateProduct;
        private Button btnGoBack;
    }
}