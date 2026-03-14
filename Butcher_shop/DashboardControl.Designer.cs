namespace Butcher_shop
{
    partial class DashboardControl
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

        private void InitializeComponent()
        {
            panelSummaryCards = new Panel();
            cardTotalProducts = new Panel();
            lblTotalProductsTitle = new Label();
            lblTotalProducts = new Label();
            cardLowStock = new Panel();
            lblLowStockTitle = new Label();
            lblLowStockCountValue = new Label();
            cardTransactions = new Panel();
            lblTransactionsTitle = new Label();
            lblTransactionsCount = new Label();
            cardSales = new Panel();
            lblSalesTitle = new Label();
            lblTotalSales = new Label();
            panelRecentTransactions = new Panel();
            dgvTransactions = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            lblRecentTransactionsTitle = new Label();
            panelSummaryCards.SuspendLayout();
            cardTotalProducts.SuspendLayout();
            cardLowStock.SuspendLayout();
            cardTransactions.SuspendLayout();
            cardSales.SuspendLayout();
            panelRecentTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // panelSummaryCards
            // 
            panelSummaryCards.BackColor = Color.Transparent;
            panelSummaryCards.Controls.Add(cardTotalProducts);
            panelSummaryCards.Controls.Add(cardLowStock);
            panelSummaryCards.Controls.Add(cardTransactions);
            panelSummaryCards.Controls.Add(cardSales);
            panelSummaryCards.Dock = DockStyle.Top;
            panelSummaryCards.Location = new Point(30, 30);
            panelSummaryCards.Name = "panelSummaryCards";
            panelSummaryCards.Size = new Size(1140, 160);
            panelSummaryCards.TabIndex = 2;
            // 
            // cardTotalProducts
            // 
            cardTotalProducts.BackColor = Color.White;
            cardTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            cardTotalProducts.Controls.Add(lblTotalProductsTitle);
            cardTotalProducts.Controls.Add(lblTotalProducts);
            cardTotalProducts.Location = new Point(0, 0);
            cardTotalProducts.Name = "cardTotalProducts";
            cardTotalProducts.Size = new Size(250, 120);
            cardTotalProducts.TabIndex = 0;
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalProductsTitle.ForeColor = Color.Black;
            lblTotalProductsTitle.Location = new Point(15, 15);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(100, 23);
            lblTotalProductsTitle.TabIndex = 0;
            lblTotalProductsTitle.Text = "Total Products";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.Black;
            lblTotalProducts.Location = new Point(15, 55);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(100, 47);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "0";
            // 
            // cardLowStock
            // 
            cardLowStock.BackColor = Color.White;
            cardLowStock.BorderStyle = BorderStyle.FixedSingle;
            cardLowStock.Controls.Add(lblLowStockTitle);
            cardLowStock.Controls.Add(lblLowStockCountValue);
            cardLowStock.Location = new Point(290, 0);
            cardLowStock.Name = "cardLowStock";
            cardLowStock.Size = new Size(250, 120);
            cardLowStock.TabIndex = 1;
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLowStockTitle.ForeColor = Color.Black;
            lblLowStockTitle.Location = new Point(15, 15);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(100, 23);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "Low Stock Alerts";
            // 
            // lblLowStockCountValue
            // 
            lblLowStockCountValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLowStockCountValue.ForeColor = Color.Black;
            lblLowStockCountValue.Location = new Point(15, 55);
            lblLowStockCountValue.Name = "lblLowStockCountValue";
            lblLowStockCountValue.Size = new Size(100, 47);
            lblLowStockCountValue.TabIndex = 1;
            lblLowStockCountValue.Text = "0";
            // 
            // cardTransactions
            // 
            cardTransactions.BackColor = Color.White;
            cardTransactions.BorderStyle = BorderStyle.FixedSingle;
            cardTransactions.Controls.Add(lblTransactionsTitle);
            cardTransactions.Controls.Add(lblTransactionsCount);
            cardTransactions.Location = new Point(580, 0);
            cardTransactions.Name = "cardTransactions";
            cardTransactions.Size = new Size(250, 120);
            cardTransactions.TabIndex = 2;
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTransactionsTitle.ForeColor = Color.Black;
            lblTransactionsTitle.Location = new Point(15, 15);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(100, 23);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "Total Transactions";
            // 
            // lblTransactionsCount
            // 
            lblTransactionsCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTransactionsCount.ForeColor = Color.Black;
            lblTransactionsCount.Location = new Point(15, 55);
            lblTransactionsCount.Name = "lblTransactionsCount";
            lblTransactionsCount.Size = new Size(100, 47);
            lblTransactionsCount.TabIndex = 1;
            lblTransactionsCount.Text = "0";
            // 
            // cardSales
            // 
            cardSales.BackColor = Color.White;
            cardSales.BorderStyle = BorderStyle.FixedSingle;
            cardSales.Controls.Add(lblSalesTitle);
            cardSales.Controls.Add(lblTotalSales);
            cardSales.Location = new Point(870, 0);
            cardSales.Name = "cardSales";
            cardSales.Size = new Size(250, 120);
            cardSales.TabIndex = 3;
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSalesTitle.ForeColor = Color.Black;
            lblSalesTitle.Location = new Point(15, 15);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(100, 23);
            lblSalesTitle.TabIndex = 0;
            lblSalesTitle.Text = "Total Sales";
            // 
            // lblTotalSales
            // 
            lblTotalSales.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalSales.ForeColor = Color.Black;
            lblTotalSales.Location = new Point(15, 55);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(100, 47);
            lblTotalSales.TabIndex = 1;
            lblTotalSales.Text = "₱0.00";
            // 
            // panelRecentTransactions
            // 
            panelRecentTransactions.BackColor = Color.White;
            panelRecentTransactions.Controls.Add(dgvTransactions);
            panelRecentTransactions.Controls.Add(lblRecentTransactionsTitle);
            panelRecentTransactions.Dock = DockStyle.Fill;
            panelRecentTransactions.Location = new Point(30, 190);
            panelRecentTransactions.Name = "panelRecentTransactions";
            panelRecentTransactions.Padding = new Padding(20);
            panelRecentTransactions.Size = new Size(1140, 480);
            panelRecentTransactions.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.ColumnHeadersHeight = 29;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] {
    dataGridViewTextBoxColumn1,
    dataGridViewTextBoxColumn2,
    dataGridViewTextBoxColumn3,
    dataGridViewTextBoxColumn4,
    dataGridViewTextBoxColumn5
});
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(20, 43);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.Size = new Size(1100, 417);
            dgvTransactions.TabIndex = 0;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "transaction_id";
            dataGridViewTextBoxColumn1.HeaderText = "transaction_id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "customer_id";
            dataGridViewTextBoxColumn2.HeaderText = "customer_id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "employee_id";
            dataGridViewTextBoxColumn3.HeaderText = "employee_id";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "total_amount";
            dataGridViewTextBoxColumn4.HeaderText = "total_amount";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "transaction_date";
            dataGridViewTextBoxColumn5.HeaderText = "transaction_date";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // lblRecentTransactionsTitle
            // 
            lblRecentTransactionsTitle.Dock = DockStyle.Top;
            lblRecentTransactionsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecentTransactionsTitle.ForeColor = Color.Black;
            lblRecentTransactionsTitle.Location = new Point(20, 20);
            lblRecentTransactionsTitle.Name = "lblRecentTransactionsTitle";
            lblRecentTransactionsTitle.Size = new Size(1100, 23);
            lblRecentTransactionsTitle.TabIndex = 1;
            lblRecentTransactionsTitle.Text = "Recent Transactions";
            // 
            // DashboardControl
            // 
            BackColor = Color.FromArgb(242, 247, 244);
            Controls.Add(panelRecentTransactions);
            Controls.Add(panelSummaryCards);
            Name = "DashboardControl";
            Padding = new Padding(30);
            Size = new Size(1200, 700);
            panelSummaryCards.ResumeLayout(false);
            cardTotalProducts.ResumeLayout(false);
            cardLowStock.ResumeLayout(false);
            cardTransactions.ResumeLayout(false);
            cardSales.ResumeLayout(false);
            panelRecentTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        private Panel panelSummaryCards;
        private Panel cardTotalProducts;
        private Panel cardLowStock;
        private Panel cardTransactions;
        private Panel cardSales;

        private Label lblTotalProducts;
        private Label lblTotalProductsTitle;
        private Label lblLowStockCountValue;
        private Label lblLowStockTitle;
        private Label lblTransactionsCount;
        private Label lblTransactionsTitle;
        private Label lblTotalSales;
        private Label lblSalesTitle;
        private Panel panelRecentTransactions;
        private DataGridView dgvTransactions;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label lblRecentTransactionsTitle;
    }
}