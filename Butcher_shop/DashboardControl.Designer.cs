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
            this.panelSummaryCards = new System.Windows.Forms.Panel();
            this.cardTotalProducts = new System.Windows.Forms.Panel();
            this.lblTotalProductsTitle = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.cardLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.lblLowStockCountValue = new System.Windows.Forms.Label();
            this.cardTransactions = new System.Windows.Forms.Panel();
            this.lblTransactionsTitle = new System.Windows.Forms.Label();
            this.lblTransactionsCount = new System.Windows.Forms.Label();
            this.cardSales = new System.Windows.Forms.Panel();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.panelRecentTransactions = new System.Windows.Forms.Panel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecentTransactionsTitle = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSummaryCards.SuspendLayout();
            this.cardTotalProducts.SuspendLayout();
            this.cardLowStock.SuspendLayout();
            this.cardTransactions.SuspendLayout();
            this.cardSales.SuspendLayout();
            this.panelRecentTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSummaryCards
            // 
            this.panelSummaryCards.BackColor = System.Drawing.Color.Transparent;
            this.panelSummaryCards.Controls.Add(this.cardTotalProducts);
            this.panelSummaryCards.Controls.Add(this.cardLowStock);
            this.panelSummaryCards.Controls.Add(this.cardTransactions);
            this.panelSummaryCards.Controls.Add(this.cardSales);
            this.panelSummaryCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummaryCards.Location = new System.Drawing.Point(30, 30);
            this.panelSummaryCards.Name = "panelSummaryCards";
            this.panelSummaryCards.Size = new System.Drawing.Size(1140, 160);
            this.panelSummaryCards.TabIndex = 2;
            // 
            // cardTotalProducts
            // 
            this.cardTotalProducts.BackColor = System.Drawing.Color.White;
            this.cardTotalProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalProducts.Controls.Add(this.lblTotalProductsTitle);
            this.cardTotalProducts.Controls.Add(this.lblTotalProducts);
            this.cardTotalProducts.Location = new System.Drawing.Point(0, 0);
            this.cardTotalProducts.Name = "cardTotalProducts";
            this.cardTotalProducts.Size = new System.Drawing.Size(250, 120);
            this.cardTotalProducts.TabIndex = 0;
            this.cardTotalProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.cardTotalProducts_Paint);
            // 
            // lblTotalProductsTitle
            // 
            this.lblTotalProductsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProductsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            this.lblTotalProductsTitle.Size = new System.Drawing.Size(150, 23);
            this.lblTotalProductsTitle.TabIndex = 0;
            this.lblTotalProductsTitle.Text = "Total Products";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProducts.Location = new System.Drawing.Point(15, 55);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(100, 47);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "0";
            // 
            // cardLowStock
            // 
            this.cardLowStock.BackColor = System.Drawing.Color.White;
            this.cardLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardLowStock.Controls.Add(this.lblLowStockTitle);
            this.cardLowStock.Controls.Add(this.lblLowStockCountValue);
            this.cardLowStock.Location = new System.Drawing.Point(290, 0);
            this.cardLowStock.Name = "cardLowStock";
            this.cardLowStock.Size = new System.Drawing.Size(250, 120);
            this.cardLowStock.TabIndex = 1;
            this.cardLowStock.Paint += new System.Windows.Forms.PaintEventHandler(this.cardLowStock_Paint_1);
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.Black;
            this.lblLowStockTitle.Location = new System.Drawing.Point(15, 15);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(150, 23);
            this.lblLowStockTitle.TabIndex = 0;
            this.lblLowStockTitle.Text = "Low Stock Alerts";
            // 
            // lblLowStockCountValue
            // 
            this.lblLowStockCountValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLowStockCountValue.ForeColor = System.Drawing.Color.Black;
            this.lblLowStockCountValue.Location = new System.Drawing.Point(15, 55);
            this.lblLowStockCountValue.Name = "lblLowStockCountValue";
            this.lblLowStockCountValue.Size = new System.Drawing.Size(100, 47);
            this.lblLowStockCountValue.TabIndex = 1;
            this.lblLowStockCountValue.Text = "0";
            // 
            // cardTransactions
            // 
            this.cardTransactions.BackColor = System.Drawing.Color.White;
            this.cardTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTransactions.Controls.Add(this.lblTransactionsTitle);
            this.cardTransactions.Controls.Add(this.lblTransactionsCount);
            this.cardTransactions.Location = new System.Drawing.Point(580, 0);
            this.cardTransactions.Name = "cardTransactions";
            this.cardTransactions.Size = new System.Drawing.Size(250, 120);
            this.cardTransactions.TabIndex = 2;
            this.cardTransactions.Paint += new System.Windows.Forms.PaintEventHandler(this.cardTransactions_Paint);
            // 
            // lblTransactionsTitle
            // 
            this.lblTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTransactionsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTransactionsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTransactionsTitle.Name = "lblTransactionsTitle";
            this.lblTransactionsTitle.Size = new System.Drawing.Size(150, 23);
            this.lblTransactionsTitle.TabIndex = 0;
            this.lblTransactionsTitle.Text = "Total Transactions";
            // 
            // lblTransactionsCount
            // 
            this.lblTransactionsCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTransactionsCount.ForeColor = System.Drawing.Color.Black;
            this.lblTransactionsCount.Location = new System.Drawing.Point(15, 55);
            this.lblTransactionsCount.Name = "lblTransactionsCount";
            this.lblTransactionsCount.Size = new System.Drawing.Size(100, 47);
            this.lblTransactionsCount.TabIndex = 1;
            this.lblTransactionsCount.Text = "0";
            // 
            // cardSales
            // 
            this.cardSales.BackColor = System.Drawing.Color.White;
            this.cardSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSales.Controls.Add(this.lblSalesTitle);
            this.cardSales.Controls.Add(this.lblTotalSales);
            this.cardSales.Location = new System.Drawing.Point(870, 0);
            this.cardSales.Name = "cardSales";
            this.cardSales.Size = new System.Drawing.Size(250, 120);
            this.cardSales.TabIndex = 3;
            this.cardSales.Paint += new System.Windows.Forms.PaintEventHandler(this.cardSales_Paint);
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblSalesTitle.Location = new System.Drawing.Point(15, 15);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(150, 23);
            this.lblSalesTitle.TabIndex = 0;
            this.lblSalesTitle.Text = "Total Sales";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalSales.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSales.Location = new System.Drawing.Point(15, 55);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(200, 47);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "₱0.00";
            // 
            // panelRecentTransactions
            // 
            this.panelRecentTransactions.BackColor = System.Drawing.Color.White;
            this.panelRecentTransactions.Controls.Add(this.dgvTransactions);
            this.panelRecentTransactions.Controls.Add(this.lblRecentTransactionsTitle);
            this.panelRecentTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecentTransactions.Location = new System.Drawing.Point(30, 190);
            this.panelRecentTransactions.Name = "panelRecentTransactions";
            this.panelRecentTransactions.Padding = new System.Windows.Forms.Padding(20);
            this.panelRecentTransactions.Size = new System.Drawing.Size(1140, 480);
            this.panelRecentTransactions.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoGenerateColumns = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.ColumnHeadersHeight = 45;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvTransactions.Location = new System.Drawing.Point(20, 43);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 45;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(1100, 417);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "transaction_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Transaction ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "total_amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "transaction_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // lblRecentTransactionsTitle
            // 
            this.lblRecentTransactionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentTransactionsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblRecentTransactionsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRecentTransactionsTitle.Name = "lblRecentTransactionsTitle";
            this.lblRecentTransactionsTitle.Size = new System.Drawing.Size(1100, 23);
            this.lblRecentTransactionsTitle.TabIndex = 1;
            this.lblRecentTransactionsTitle.Text = "Recent Transactions";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // DashboardControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panelRecentTransactions);
            this.Controls.Add(this.panelSummaryCards);
            this.Name = "DashboardControl";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1200, 700);
            this.panelSummaryCards.ResumeLayout(false);
            this.cardTotalProducts.ResumeLayout(false);
            this.cardLowStock.ResumeLayout(false);
            this.cardTransactions.ResumeLayout(false);
            this.cardSales.ResumeLayout(false);
            this.panelRecentTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSummaryCards;
        private System.Windows.Forms.Panel cardTotalProducts;
        private System.Windows.Forms.Panel cardLowStock;
        private System.Windows.Forms.Panel cardTransactions;
        private System.Windows.Forms.Panel cardSales;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblTotalProductsTitle;
        private System.Windows.Forms.Label lblLowStockCountValue;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblTransactionsCount;
        private System.Windows.Forms.Label lblTransactionsTitle;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Panel panelRecentTransactions;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblRecentTransactionsTitle;
    }
}