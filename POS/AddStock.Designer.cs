namespace POS
{
    partial class AddStock
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
            comboBoxProduct = new ComboBox();
            numericUpDownQty = new NumericUpDown();
            label1 = new Label();
            dTPickerExpiryDate = new DateTimePicker();
            label2 = new Label();
            btnAddStock = new Button();
            btnGoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).BeginInit();
            SuspendLayout();
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.BackColor = Color.FromArgb(255, 224, 192);
            comboBoxProduct.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProduct.ForeColor = SystemColors.Desktop;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(27, 29);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(213, 36);
            comboBoxProduct.TabIndex = 9;
            comboBoxProduct.Text = "Choose Product";
            // 
            // numericUpDownQty
            // 
            numericUpDownQty.BackColor = Color.FromArgb(255, 224, 192);
            numericUpDownQty.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownQty.Location = new Point(145, 83);
            numericUpDownQty.Name = "numericUpDownQty";
            numericUpDownQty.Size = new Size(54, 34);
            numericUpDownQty.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 11;
            label1.Text = "Quantity:";
            // 
            // dTPickerExpiryDate
            // 
            dTPickerExpiryDate.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dTPickerExpiryDate.Location = new Point(173, 141);
            dTPickerExpiryDate.Name = "dTPickerExpiryDate";
            dTPickerExpiryDate.Size = new Size(384, 34);
            dTPickerExpiryDate.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 146);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 13;
            label2.Text = "Expiry Date:";
            // 
            // btnAddStock
            // 
            btnAddStock.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStock.Location = new Point(27, 206);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(236, 38);
            btnAddStock.TabIndex = 14;
            btnAddStock.Text = "Add Stock Entry";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoBack.Location = new Point(321, 206);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(236, 38);
            btnGoBack.TabIndex = 15;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // AddStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(580, 270);
            Controls.Add(btnGoBack);
            Controls.Add(btnAddStock);
            Controls.Add(label2);
            Controls.Add(dTPickerExpiryDate);
            Controls.Add(label1);
            Controls.Add(numericUpDownQty);
            Controls.Add(comboBoxProduct);
            Name = "AddStock";
            Text = "AddStock";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProduct;
        private NumericUpDown numericUpDownQty;
        private Label label1;
        private DateTimePicker dTPickerExpiryDate;
        private Label label2;
        private Button btnAddStock;
        private Button btnGoBack;
    }
}