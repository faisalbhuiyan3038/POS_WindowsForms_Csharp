namespace POS
{
    partial class AddCustomer
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
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtAddress = new TextBox();
            btnAddCustomer = new Button();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 224, 192);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(22, 25);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(241, 27);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(255, 224, 192);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(22, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(318, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtMobile
            // 
            txtMobile.BackColor = Color.FromArgb(255, 224, 192);
            txtMobile.BorderStyle = BorderStyle.None;
            txtMobile.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMobile.Location = new Point(22, 123);
            txtMobile.Name = "txtMobile";
            txtMobile.PlaceholderText = "Mobile";
            txtMobile.Size = new Size(318, 27);
            txtMobile.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 224, 192);
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(22, 176);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(277, 128);
            txtAddress.TabIndex = 8;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCustomer.Location = new Point(22, 343);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(224, 38);
            btnAddCustomer.TabIndex = 9;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoBack.Location = new Point(291, 343);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(224, 38);
            btnGoBack.TabIndex = 10;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(545, 400);
            Controls.Add(btnGoBack);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtAddress);
            Controls.Add(txtMobile);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "AddCustomer";
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtAddress;
        private Button btnAddCustomer;
        private Button btnGoBack;
    }
}