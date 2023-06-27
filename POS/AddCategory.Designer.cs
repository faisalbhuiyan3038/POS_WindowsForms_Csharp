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
            btnAddCategory = new Button();
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
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCategory.Location = new Point(35, 151);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(224, 38);
            btnAddCategory.TabIndex = 7;
            btnAddCategory.Text = "Add Category Entry";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnLogIn_Click;
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
            Controls.Add(btnAddCategory);
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
        private Button btnAddCategory;
        private Button btnGoBack;
    }
}