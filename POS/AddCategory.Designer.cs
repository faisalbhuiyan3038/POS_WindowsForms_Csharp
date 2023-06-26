namespace POS
{
    partial class AddCategory
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
            txtDescription = new TextBox();
            btnLogIn = new Button();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 224, 192);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(35, 42);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(241, 27);
            txtName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(255, 224, 192);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(35, 98);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(466, 27);
            txtDescription.TabIndex = 5;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(35, 151);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(224, 38);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "Add Category Entry";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGoBack.Location = new Point(277, 151);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(224, 38);
            btnGoBack.TabIndex = 8;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(538, 219);
            Controls.Add(btnGoBack);
            Controls.Add(btnLogIn);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "AddCategory";
            Text = "AddCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private Button btnLogIn;
        private Button btnGoBack;
    }
}