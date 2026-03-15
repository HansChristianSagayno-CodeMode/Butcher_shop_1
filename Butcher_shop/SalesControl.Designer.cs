namespace Butcher_shop
{
    partial class SalesControl
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

        #region Component Designer generated code
        private void InitializeComponent()
        {
            pnlSalesToolbar = new System.Windows.Forms.Panel();
            btnSalesReload = new System.Windows.Forms.Button();
            btnSalesCreate = new System.Windows.Forms.Button();
            lblSalesPageTitle = new System.Windows.Forms.Label();
            pnlSalesList = new System.Windows.Forms.Panel();
            dgvTransactionDetails = new System.Windows.Forms.DataGridView();
            detailColTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detailColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detailColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detailColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvTransactions = new System.Windows.Forms.DataGridView();
            transColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transColEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            transColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlSalesToolbar.SuspendLayout();
            pnlSalesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // pnlSalesToolbar
            // 
            pnlSalesToolbar.BackColor = System.Drawing.Color.White;
            pnlSalesToolbar.Controls.Add(btnSalesReload);
            pnlSalesToolbar.Controls.Add(btnSalesCreate);
            pnlSalesToolbar.Controls.Add(lblSalesPageTitle);
            pnlSalesToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSalesToolbar.Location = new System.Drawing.Point(0, 0);
            pnlSalesToolbar.Name = "pnlSalesToolbar";
            pnlSalesToolbar.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            pnlSalesToolbar.Size = new System.Drawing.Size(1200, 70);
            pnlSalesToolbar.TabIndex = 0;
            // 
            // btnSalesReload
            // 
            btnSalesReload.BackColor = System.Drawing.Color.SteelBlue;
            btnSalesReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalesReload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSalesReload.ForeColor = System.Drawing.Color.White;
            btnSalesReload.Location = new System.Drawing.Point(993, 22);
            btnSalesReload.Name = "btnSalesReload";
            btnSalesReload.Size = new System.Drawing.Size(120, 35);
            btnSalesReload.TabIndex = 2;
            btnSalesReload.Text = " Refresh";
            btnSalesReload.UseVisualStyleBackColor = false;
            btnSalesReload.Click += btnSalesReload_Click;
            // 
            // btnSalesCreate
            // 
            btnSalesCreate.BackColor = System.Drawing.Color.ForestGreen;
            btnSalesCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalesCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSalesCreate.ForeColor = System.Drawing.Color.White;
            btnSalesCreate.Location = new System.Drawing.Point(813, 22);
            btnSalesCreate.Name = "btnSalesCreate";
            btnSalesCreate.Size = new System.Drawing.Size(120, 35);
            btnSalesCreate.TabIndex = 1;
            btnSalesCreate.Text = "New Sale";
            btnSalesCreate.UseVisualStyleBackColor = false;
            btnSalesCreate.Click += btnSalesCreate_Click;
            // 
            // lblSalesPageTitle
            // 
            lblSalesPageTitle.AutoSize = true;
            lblSalesPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblSalesPageTitle.ForeColor = System.Drawing.Color.Black;
            lblSalesPageTitle.Location = new System.Drawing.Point(13, 10);
            lblSalesPageTitle.Name = "lblSalesPageTitle";
            lblSalesPageTitle.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            lblSalesPageTitle.Size = new System.Drawing.Size(261, 52);
            lblSalesPageTitle.TabIndex = 1;
            lblSalesPageTitle.Text = "Sales Transactions";
            // 
            // pnlSalesList
            // 
            pnlSalesList.Controls.Add(dgvTransactionDetails);
            pnlSalesList.Controls.Add(dgvTransactions);
            pnlSalesList.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSalesList.Location = new System.Drawing.Point(0, 70);
            pnlSalesList.Name = "pnlSalesList";
            pnlSalesList.Padding = new System.Windows.Forms.Padding(20);
            pnlSalesList.Size = new System.Drawing.Size(1200, 630);
            pnlSalesList.TabIndex = 1;
            // 
            // dgvTransactionDetails
            // 
            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvTransactionDetails.BackgroundColor = System.Drawing.Color.White;
            dgvTransactionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTransactionDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactionDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvTransactionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionDetails.MultiSelect = false;
            dgvTransactionDetails.ReadOnly = true;
            dgvTransactionDetails.RowHeadersVisible = false;

            dgvTransactionDetails.AllowUserToAddRows = false;
            dgvTransactionDetails.AllowUserToDeleteRows = false;
            dgvTransactionDetails.AutoGenerateColumns = false;

            dgvTransactionDetails.EnableHeadersVisualStyles = false;
            dgvTransactionDetails.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvTransactionDetails.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvTransactionDetails.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvTransactionDetails.ColumnHeadersHeight = 45;

            dgvTransactionDetails.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvTransactionDetails.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvTransactionDetails.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvTransactionDetails.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvTransactionDetails.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvTransactionDetails.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvTransactionDetails.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dgvTransactionDetails.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvTransactionDetails.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            dgvTransactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { detailColTransID, detailColProduct, detailColQty, detailColPrice });
            dgvTransactionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTransactionDetails.Location = new System.Drawing.Point(20, 270);
            dgvTransactionDetails.Name = "dgvTransactionDetails";
            dgvTransactionDetails.Size = new System.Drawing.Size(1160, 340);
            dgvTransactionDetails.TabIndex = 0;
            dgvTransactionDetails.CellContentClick += dgvTransactionDetails_CellContentClick;
            // 
            // detailColTransID
            // 
            detailColTransID.DataPropertyName = "transaction_id";
            detailColTransID.HeaderText = "Transaction ID";
            detailColTransID.MinimumWidth = 6;
            detailColTransID.Name = "detailColTransID";
            detailColTransID.ReadOnly = true;
            // 
            // detailColProduct
            // 
            detailColProduct.DataPropertyName = "product_id";
            detailColProduct.HeaderText = "Product ID";
            detailColProduct.MinimumWidth = 6;
            detailColProduct.Name = "detailColProduct";
            detailColProduct.ReadOnly = true;
            // 
            // detailColQty
            // 
            detailColQty.DataPropertyName = "quantity_sold";
            detailColQty.HeaderText = "Quantity Sold";
            detailColQty.MinimumWidth = 6;
            detailColQty.Name = "detailColQty";
            detailColQty.ReadOnly = true;
            // 
            // detailColPrice
            // 
            detailColPrice.DataPropertyName = "unit_price_at_sale";
            detailColPrice.HeaderText = "Unit Price";
            detailColPrice.MinimumWidth = 6;
            detailColPrice.Name = "detailColPrice";
            detailColPrice.ReadOnly = true;
            // 
            // dgvTransactions
            // 
            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.MultiSelect = false;
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;

            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoGenerateColumns = false;

            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvTransactions.ColumnHeadersHeight = 45;

            dgvTransactions.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvTransactions.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvTransactions.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvTransactions.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvTransactions.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvTransactions.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            dgvTransactions.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvTransactions.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { transColID, transColCustomer, transColEmployee, transColTotal, transColDate });
            dgvTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            dgvTransactions.Location = new System.Drawing.Point(20, 20);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new System.Drawing.Size(1160, 250);
            dgvTransactions.TabIndex = 1;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            dgvTransactions.CellClick += dgvTransactions_CellClick; // IMPORTANT: Wired up CellClick for your master-detail logic
            // 
            // transColID
            // 
            transColID.DataPropertyName = "transaction_id";
            transColID.HeaderText = "Transaction ID";
            transColID.MinimumWidth = 6;
            transColID.Name = "transColID";
            transColID.ReadOnly = true;
            // 
            // transColCustomer
            // 
            transColCustomer.DataPropertyName = "customer_id";
            transColCustomer.HeaderText = "Customer ID";
            transColCustomer.MinimumWidth = 6;
            transColCustomer.Name = "transColCustomer";
            transColCustomer.ReadOnly = true;
            // 
            // transColEmployee
            // 
            transColEmployee.DataPropertyName = "employee_id";
            transColEmployee.HeaderText = "Employee ID";
            transColEmployee.MinimumWidth = 6;
            transColEmployee.Name = "transColEmployee";
            transColEmployee.ReadOnly = true;
            // 
            // transColTotal
            // 
            transColTotal.DataPropertyName = "total_amount";
            transColTotal.HeaderText = "Total Amount";
            transColTotal.MinimumWidth = 6;
            transColTotal.Name = "transColTotal";
            transColTotal.ReadOnly = true;
            // 
            // transColDate
            // 
            transColDate.DataPropertyName = "transaction_date";
            transColDate.HeaderText = "Date";
            transColDate.MinimumWidth = 6;
            transColDate.Name = "transColDate";
            transColDate.ReadOnly = true;
            // 
            // SalesControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(pnlSalesList);
            Controls.Add(pnlSalesToolbar);
            Name = "SalesControl";
            Size = new System.Drawing.Size(1200, 700);
            pnlSalesToolbar.ResumeLayout(false);
            pnlSalesToolbar.PerformLayout();
            pnlSalesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel pnlSalesToolbar;
        private System.Windows.Forms.Label lblSalesPageTitle;
        private System.Windows.Forms.Button btnSalesCreate;
        private System.Windows.Forms.Button btnSalesReload;
        private System.Windows.Forms.Panel pnlSalesList;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridView dgvTransactionDetails;
        // Transactions columns
        private System.Windows.Forms.DataGridViewTextBoxColumn transColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn transColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn transColEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn transColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn transColDate;
        // Transaction details columns
        private System.Windows.Forms.DataGridViewTextBoxColumn detailColTransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailColProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailColQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailColPrice;
    }
}