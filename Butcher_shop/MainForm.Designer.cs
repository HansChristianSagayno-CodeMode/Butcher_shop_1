namespace Butcher_shop
{
    partial class MainForm
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
            panelHeader = new Panel();
            btnLogout1 = new Button();
            lblStoreName = new Label();
            panelSidebar = new Panel();
            btnStockOut = new Button();
            btnSupply = new Button();
            button2 = new Button();
            btnSuppliers = new Button();
            btnExit = new Button();
            btnReports = new Button();
            btnCustomers = new Button();
            btnInventory = new Button();
            btnProducts = new Button();
            btnSales = new Button();
            btnDashboard = new Button();
            panelContent = new Panel();
            btnLogout = new Button();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(27, 94, 32);
            panelHeader.Controls.Add(btnLogout1);
            panelHeader.Controls.Add(lblStoreName);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1482, 80);
            panelHeader.TabIndex = 0;
            panelHeader.TabStop = true;
            panelHeader.Tag = "";
            panelHeader.Paint += panelHeader_Paint;
            // 
            // btnLogout1
            // 
            btnLogout1.BackColor = Color.FromArgb(245, 124, 0);
            btnLogout1.FlatStyle = FlatStyle.Flat;
            btnLogout1.Location = new Point(1219, 12);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.Size = new Size(110, 38);
            btnLogout1.TabIndex = 2;
            btnLogout1.Text = "Logout";
            btnLogout1.UseVisualStyleBackColor = false;
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStoreName.ForeColor = Color.White;
            lblStoreName.Location = new Point(30, 12);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(366, 41);
            lblStoreName.TabIndex = 0;
            lblStoreName.Text = "Meat Shop Management";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 94, 32);
            panelSidebar.Controls.Add(btnStockOut);
            panelSidebar.Controls.Add(btnSupply);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(btnSuppliers);
            panelSidebar.Controls.Add(btnExit);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnCustomers);
            panelSidebar.Controls.Add(btnInventory);
            panelSidebar.Controls.Add(btnProducts);
            panelSidebar.Controls.Add(btnSales);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 80);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 773);
            panelSidebar.TabIndex = 1;
            // 
            // btnStockOut
            // 
            btnStockOut.BackColor = Color.FromArgb(27, 67, 50);
            btnStockOut.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnStockOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnStockOut.FlatStyle = FlatStyle.Flat;
            btnStockOut.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnStockOut.ForeColor = Color.White;
            btnStockOut.Location = new Point(-6, 486);
            btnStockOut.Name = "btnStockOut";
            btnStockOut.Size = new Size(240, 60);
            btnStockOut.TabIndex = 13;
            btnStockOut.Text = "Stock Out";
            btnStockOut.TextAlign = ContentAlignment.MiddleLeft;
            btnStockOut.UseVisualStyleBackColor = false;
            btnStockOut.Click += btnStockOut_Click;
            // 
            // btnSupply
            // 
            btnSupply.BackColor = Color.FromArgb(27, 67, 50);
            btnSupply.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnSupply.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnSupply.FlatStyle = FlatStyle.Flat;
            btnSupply.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnSupply.ForeColor = Color.White;
            btnSupply.Location = new Point(0, 435);
            btnSupply.Name = "btnSupply";
            btnSupply.Size = new Size(240, 60);
            btnSupply.TabIndex = 12;
            btnSupply.Text = "Supply";
            btnSupply.TextAlign = ContentAlignment.MiddleLeft;
            btnSupply.UseVisualStyleBackColor = false;
            btnSupply.Click += btnSupply_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(27, 67, 50);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Corbel", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-3, 383);
            button2.Name = "button2";
            button2.Size = new Size(240, 60);
            button2.TabIndex = 11;
            button2.Text = "Employees";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnEmployees_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.FromArgb(27, 67, 50);
            btnSuppliers.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnSuppliers.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(-6, 326);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(240, 60);
            btnSuppliers.TabIndex = 10;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(27, 67, 50);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(240, 60);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(27, 67, 50);
            btnReports.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(-3, 273);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(240, 60);
            btnReports.TabIndex = 8;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(27, 67, 50);
            btnCustomers.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(-3, 219);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(240, 60);
            btnCustomers.TabIndex = 7;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(27, 67, 50);
            btnInventory.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 166);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(240, 60);
            btnInventory.TabIndex = 6;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(27, 67, 50);
            btnProducts.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 110);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(240, 60);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(27, 67, 50);
            btnSales.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnSales.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 55);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(240, 60);
            btnSales.TabIndex = 4;
            btnSales.Text = "Sales";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(27, 67, 50);
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 106, 79);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, -1);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(240, 60);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelContent
            // 
            panelContent.AccessibleRole = AccessibleRole.WhiteSpace;
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.Controls.Add(btnLogout);
            panelContent.Cursor = Cursors.Hand;
            panelContent.Dock = DockStyle.Fill;
            panelContent.ForeColor = Color.White;
            panelContent.Location = new Point(240, 80);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25, 0, 0, 0);
            panelContent.Size = new Size(1242, 773);
            panelContent.TabIndex = 2;
            panelContent.Paint += panel1_Paint;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(245, 124, 0);
            btnLogout.Location = new Point(1210, 21);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 38);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 248, 233);
            ClientSize = new Size(1482, 853);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelSidebar;
        private Panel panelContent;
        private Button btnLogout;
        private Label lblStoreName;
        private Button btnLogout1;
        private Button btnDashboard;
        private Button btnProducts;
        private Button btnSales;
        private Button btnInventory;
        private Button btnExit;
        private Button btnReports;
        private Button btnCustomers;
        private Button btnStockOut;
        private Button btnSupply;
        private Button button2;
        private Button btnSuppliers;
    }
}