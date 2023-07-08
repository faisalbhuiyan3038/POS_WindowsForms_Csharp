namespace POS
{
    partial class UpdateStock
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
            comboBoxExistingProduct = new ComboBox();
            comboBoxNewProduct = new ComboBox();
            label1 = new Label();
            numericUpDownQty = new NumericUpDown();
            label2 = new Label();
            dTPickerExpiryDate = new DateTimePicker();
            btnLoadData = new Button();
            btnUpdateStock = new Button();
            btnGoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).BeginInit();
            SuspendLayout();
            // 
            // comboBoxExistingProduct
            // 
            comboBoxExistingProduct.BackColor = Color.FromArgb(255, 224, 192);
            comboBoxExistingProduct.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxExistingProduct.ForeColor = SystemColors.Desktop;
            comboBoxExistingProduct.FormattingEnabled = true;
            comboBoxExistingProduct.Location = new Point(22, 21);
            comboBoxExistingProduct.Name = "comboBoxExistingProduct";
            comboBoxExistingProduct.Size = new Size(274, 36);
            comboBoxExistingProduct.TabIndex = 10;
            comboBoxExistingProduct.Text = "Choose Existing Product";
            // 
            // comboBoxNewProduct
            // 
            comboBoxNewProduct.BackColor = Color.FromArgb(255, 224, 192);
            comboBoxNewProduct.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxNewProduct.ForeColor = SystemColors.Desktop;
            comboBoxNewProduct.FormattingEnabled = true;
            comboBoxNewProduct.Location = new Point(22, 84);
            comboBoxNewProduct.Name = "comboBoxNewProduct";
            comboBoxNewProduct.Size = new Size(274, 36);
            comboBoxNewProduct.TabIndex = 11;
            comboBoxNewProduct.Text = "Choose New Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(370, 88);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 13;
            label1.Text = "Quantity:";
            // 
            // numericUpDownQty
            // 
            numericUpDownQty.BackColor = Color.FromArgb(255, 224, 192);
            numericUpDownQty.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownQty.Location = new Point(488, 86);
            numericUpDownQty.Name = "numericUpDownQty";
            numericUpDownQty.Size = new Size(54, 34);
            numericUpDownQty.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 159);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 15;
            label2.Text = "Expiry Date:";
            // 
            // dTPickerExpiryDate
            // 
            dTPickerExpiryDate.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dTPickerExpiryDate.Location = new Point(168, 154);
            dTPickerExpiryDate.Name = "dTPickerExpiryDate";
            dTPickerExpiryDate.Size = new Size(384, 34);
            dTPickerExpiryDate.TabIndex = 14;
            // 
            // btnLoadData
            // 
            btnLoadData.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadData.Location = new Point(22, 230);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(211, 38);
            btnLoadData.TabIndex = 16;
            btnLoadData.Text = "Load Existing Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateStock.Location = new Point(251, 230);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(180, 38);
            btnUpdateStock.TabIndex = 17;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoBack.Location = new Point(460, 230);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(110, 38);
            btnGoBack.TabIndex = 18;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            // 
            // UpdateStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(608, 318);
            Controls.Add(btnGoBack);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnLoadData);
            Controls.Add(label2);
            Controls.Add(dTPickerExpiryDate);
            Controls.Add(label1);
            Controls.Add(numericUpDownQty);
            Controls.Add(comboBoxNewProduct);
            Controls.Add(comboBoxExistingProduct);
            Name = "UpdateStock";
            Text = "UpdateStock";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxExistingProduct;
        private ComboBox comboBoxNewProduct;
        private Label label1;
        private NumericUpDown numericUpDownQty;
        private Label label2;
        private DateTimePicker dTPickerExpiryDate;
        private Button btnLoadData;
        private Button btnUpdateStock;
        private Button btnGoBack;
    }
}