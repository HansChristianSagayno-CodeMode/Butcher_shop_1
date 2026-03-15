namespace Butcher_shop
{
    partial class EmployeeMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            btnLogout1 = new Button();
            lblStoreName = new Label();
            panelSidebar = new Panel();
            btnCustomers = new Button();
            btnSales = new Button();
            btnExit = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            panelContent = new Panel();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
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
            panelHeader.TabIndex = 2;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // btnLogout1
            // 
            btnLogout1.BackColor = Color.FromArgb(245, 124, 0);
            btnLogout1.FlatStyle = FlatStyle.Flat;
            btnLogout1.Location = new Point(1339, 20);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.Size = new Size(110, 38);
            btnLogout1.TabIndex = 0;
            btnLogout1.Text = "Logout";
            btnLogout1.UseVisualStyleBackColor = false;
            btnLogout1.Click += btnLogout1_Click;
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblStoreName.ForeColor = Color.White;
            lblStoreName.Location = new Point(30, 12);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(366, 41);
            lblStoreName.TabIndex = 1;
            lblStoreName.Text = "Meat Shop Management";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 94, 32);
            panelSidebar.Controls.Add(btnCustomers);
            panelSidebar.Controls.Add(btnSales);
            panelSidebar.Controls.Add(btnExit);
            panelSidebar.Controls.Add(btnProducts);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 80);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 773);
            panelSidebar.TabIndex = 1;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(27, 67, 50);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 174);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(240, 60);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(27, 67, 50);
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(0, 58);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(240, 60);
            btnSales.TabIndex = 1;
            btnSales.Text = "Sales";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(27, 67, 50);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(240, 60);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(27, 67, 50);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Corbel", 12F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 116);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(240, 60);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(27, 67, 50);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, -1);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(240, 60);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(240, 80);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25, 0, 0, 0);
            panelContent.Size = new Size(1242, 773);
            panelContent.TabIndex = 0;
            panelContent.Paint += panel1_Paint;
            // 
            // EmployeeMainForm
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
            Name = "EmployeeMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeMainForm";
            Load += EmployeeMainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelSidebar;
        private Panel panelContent;
        private Label lblStoreName;
        private Button btnLogout1;
        private Button btnDashboard;
        private Button btnProducts;
        private Button btnSales;
        private Button btnCustomers;
        private Button btnExit;
    }
}