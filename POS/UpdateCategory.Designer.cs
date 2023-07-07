namespace POS
{
    partial class UpdateCategory
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
            txtDescription = new TextBox();
            btnUpdateCategory = new Button();
            btnLoadExistingData = new Button();
            SuspendLayout();
            // 
            // txtExistingName
            // 
            txtExistingName.BackColor = Color.FromArgb(255, 224, 192);
            txtExistingName.BorderStyle = BorderStyle.None;
            txtExistingName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtExistingName.Location = new Point(28, 35);
            txtExistingName.Name = "txtExistingName";
            txtExistingName.PlaceholderText = "Existing Name";
            txtExistingName.Size = new Size(274, 27);
            txtExistingName.TabIndex = 6;
            // 
            // txtNewName
            // 
            txtNewName.BackColor = Color.FromArgb(255, 224, 192);
            txtNewName.BorderStyle = BorderStyle.None;
            txtNewName.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(356, 35);
            txtNewName.Name = "txtNewName";
            txtNewName.PlaceholderText = "New Name";
            txtNewName.Size = new Size(274, 27);
            txtNewName.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(255, 224, 192);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(28, 97);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(483, 27);
            txtDescription.TabIndex = 8;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateCategory.Location = new Point(28, 159);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(224, 38);
            btnUpdateCategory.TabIndex = 10;
            btnUpdateCategory.Text = "Update Category";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnLoadExistingData
            // 
            btnLoadExistingData.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadExistingData.Location = new Point(320, 159);
            btnLoadExistingData.Name = "btnLoadExistingData";
            btnLoadExistingData.Size = new Size(224, 38);
            btnLoadExistingData.TabIndex = 11;
            btnLoadExistingData.Text = "Load Existing Data";
            btnLoadExistingData.UseVisualStyleBackColor = true;
            btnLoadExistingData.Click += btnLoadExistingData_Click;
            // 
            // UpdateCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(658, 230);
            Controls.Add(btnLoadExistingData);
            Controls.Add(btnUpdateCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtNewName);
            Controls.Add(txtExistingName);
            Name = "UpdateCategory";
            Text = "UpdateCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExistingName;
        private TextBox txtNewName;
        private TextBox txtDescription;
        private Button btnUpdateCategory;
        private Button btnLoadExistingData;
    }
}