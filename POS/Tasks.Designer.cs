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
            tasksMenuStrip = new MenuStrip();
            menuAddItems = new ToolStripMenuItem();
            addCategoryToolStripMenuItem = new ToolStripMenuItem();
            addProductEntryToolStripMenuItem = new ToolStripMenuItem();
            addStockEntryToolStripMenuItem = new ToolStripMenuItem();
            addNewCustomerToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tasksMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tasksMenuStrip
            // 
            tasksMenuStrip.BackColor = Color.FromArgb(255, 192, 192);
            tasksMenuStrip.ImageScalingSize = new Size(20, 20);
            tasksMenuStrip.Items.AddRange(new ToolStripItem[] { menuAddItems });
            tasksMenuStrip.Location = new Point(0, 0);
            tasksMenuStrip.Name = "tasksMenuStrip";
            tasksMenuStrip.Size = new Size(607, 28);
            tasksMenuStrip.TabIndex = 11;
            tasksMenuStrip.Text = "menuStrip1";
            // 
            // menuAddItems
            // 
            menuAddItems.BackColor = Color.FromArgb(255, 128, 128);
            menuAddItems.DropDownItems.AddRange(new ToolStripItem[] { addCategoryToolStripMenuItem, addProductEntryToolStripMenuItem, addStockEntryToolStripMenuItem, addNewCustomerToolStripMenuItem });
            menuAddItems.Name = "menuAddItems";
            menuAddItems.Size = new Size(91, 24);
            menuAddItems.Text = "Add Items";
            menuAddItems.Click += menuAddItems_Click;
            // 
            // addCategoryToolStripMenuItem
            // 
            addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            addCategoryToolStripMenuItem.Size = new Size(239, 26);
            addCategoryToolStripMenuItem.Text = "Add Product Category";
            addCategoryToolStripMenuItem.Click += addCategoryToolStripMenuItem_Click;
            // 
            // addProductEntryToolStripMenuItem
            // 
            addProductEntryToolStripMenuItem.Name = "addProductEntryToolStripMenuItem";
            addProductEntryToolStripMenuItem.Size = new Size(239, 26);
            addProductEntryToolStripMenuItem.Text = "Add Product Entry";
            addProductEntryToolStripMenuItem.Click += addProductEntryToolStripMenuItem_Click;
            // 
            // addStockEntryToolStripMenuItem
            // 
            addStockEntryToolStripMenuItem.Name = "addStockEntryToolStripMenuItem";
            addStockEntryToolStripMenuItem.Size = new Size(239, 26);
            addStockEntryToolStripMenuItem.Text = "Add Stock Entry";
            addStockEntryToolStripMenuItem.Click += addStockEntryToolStripMenuItem_Click;
            // 
            // addNewCustomerToolStripMenuItem
            // 
            addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            addNewCustomerToolStripMenuItem.Size = new Size(239, 26);
            addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(165, 133);
            label1.Name = "label1";
            label1.Size = new Size(263, 40);
            label1.TabIndex = 12;
            label1.Text = "Welcome, Admin!";
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(607, 369);
            Controls.Add(label1);
            Controls.Add(tasksMenuStrip);
            MainMenuStrip = tasksMenuStrip;
            Name = "Tasks";
            Text = "Tasks";
            tasksMenuStrip.ResumeLayout(false);
            tasksMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddStock;
        private Button btnAddCustomer;
        private MenuStrip tasksMenuStrip;
        private ToolStripMenuItem menuAddItems;
        private ToolStripMenuItem addCategoryToolStripMenuItem;
        private ToolStripMenuItem addProductEntryToolStripMenuItem;
        private ToolStripMenuItem addStockEntryToolStripMenuItem;
        private ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private Label label1;
    }
}