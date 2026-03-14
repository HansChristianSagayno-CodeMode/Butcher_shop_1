namespace Butcher_shop
{
    partial class SalesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSalesToolbar = new Panel();
            btnSalesReload = new Button();
            btnSalesCreate = new Button();
            lblSalesPageTitle = new Label();
            pnlSalesList = new Panel();
            dgvTransactionDetails = new DataGridView();
            detailColTransID = new DataGridViewTextBoxColumn();
            detailColProduct = new DataGridViewTextBoxColumn();
            detailColQty = new DataGridViewTextBoxColumn();
            detailColPrice = new DataGridViewTextBoxColumn();
            dgvTransactions = new DataGridView();
            transColID = new DataGridViewTextBoxColumn();
            transColCustomer = new DataGridViewTextBoxColumn();
            transColEmployee = new DataGridViewTextBoxColumn();
            transColTotal = new DataGridViewTextBoxColumn();
            transColDate = new DataGridViewTextBoxColumn();
            pnlSalesToolbar.SuspendLayout();
            pnlSalesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // pnlSalesToolbar
            // 
            pnlSalesToolbar.BackColor = Color.White;
            pnlSalesToolbar.Controls.Add(btnSalesReload);
            pnlSalesToolbar.Controls.Add(btnSalesCreate);
            pnlSalesToolbar.Controls.Add(lblSalesPageTitle);
            pnlSalesToolbar.Dock = DockStyle.Top;
            pnlSalesToolbar.Location = new Point(0, 0);
            pnlSalesToolbar.Name = "pnlSalesToolbar";
            pnlSalesToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlSalesToolbar.Size = new Size(1200, 70);
            pnlSalesToolbar.TabIndex = 0;
            // 
            // btnSalesReload
            // 
            btnSalesReload.BackColor = Color.SteelBlue;
            btnSalesReload.FlatStyle = FlatStyle.Flat;
            btnSalesReload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalesReload.ForeColor = Color.White;
            btnSalesReload.Location = new Point(993, 22);
            btnSalesReload.Name = "btnSalesReload";
            btnSalesReload.Size = new Size(120, 35);
            btnSalesReload.TabIndex = 2;
            btnSalesReload.Text = " Refresh";
            btnSalesReload.UseVisualStyleBackColor = false;
            btnSalesReload.Click += btnSalesReload_Click;
            // 
            // btnSalesCreate
            // 
            btnSalesCreate.BackColor = Color.ForestGreen;
            btnSalesCreate.FlatStyle = FlatStyle.Flat;
            btnSalesCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalesCreate.ForeColor = Color.White;
            btnSalesCreate.Location = new Point(813, 22);
            btnSalesCreate.Name = "btnSalesCreate";
            btnSalesCreate.Size = new Size(120, 35);
            btnSalesCreate.TabIndex = 1;
            btnSalesCreate.Text = "New Sale";
            btnSalesCreate.UseVisualStyleBackColor = false;
            btnSalesCreate.Click += btnSalesCreate_Click;
            // 
            // lblSalesPageTitle
            // 
            lblSalesPageTitle.AutoSize = true;
            lblSalesPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSalesPageTitle.ForeColor = Color.Black;
            lblSalesPageTitle.Location = new Point(13, 10);
            lblSalesPageTitle.Name = "lblSalesPageTitle";
            lblSalesPageTitle.Padding = new Padding(20, 10, 20, 10);
            lblSalesPageTitle.Size = new Size(261, 52);
            lblSalesPageTitle.TabIndex = 1;
            lblSalesPageTitle.Text = "Sales Transactions";
            // 
            // pnlSalesList
            // 
            pnlSalesList.Controls.Add(dgvTransactionDetails);
            pnlSalesList.Controls.Add(dgvTransactions);
            pnlSalesList.Dock = DockStyle.Fill;
            pnlSalesList.Location = new Point(0, 70);
            pnlSalesList.Name = "pnlSalesList";
            pnlSalesList.Padding = new Padding(20);
            pnlSalesList.Size = new Size(1200, 630);
            pnlSalesList.TabIndex = 1;
            // 
            // dgvTransactionDetails
            // 
            dgvTransactionDetails.AllowUserToAddRows = false;
            dgvTransactionDetails.AllowUserToDeleteRows = false;
            dgvTransactionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionDetails.BackgroundColor = Color.White;
            dgvTransactionDetails.ColumnHeadersHeight = 29;
            dgvTransactionDetails.Columns.AddRange(new DataGridViewColumn[] { detailColTransID, detailColProduct, detailColQty, detailColPrice });
            dgvTransactionDetails.Dock = DockStyle.Fill;
            dgvTransactionDetails.Location = new Point(20, 270);
            dgvTransactionDetails.Name = "dgvTransactionDetails";
            dgvTransactionDetails.RowHeadersWidth = 51;
            dgvTransactionDetails.Size = new Size(1160, 340);
            dgvTransactionDetails.TabIndex = 0;
            dgvTransactionDetails.CellContentClick += dgvTransactionDetails_CellContentClick;
            // 
            // detailColTransID
            // 
            detailColTransID.DataPropertyName = "transaction_id";
            detailColTransID.HeaderText = "Transaction ID";
            detailColTransID.MinimumWidth = 6;
            detailColTransID.Name = "detailColTransID";
            // 
            // detailColProduct
            // 
            detailColProduct.DataPropertyName = "product_id";
            detailColProduct.HeaderText = "Product ID";
            detailColProduct.MinimumWidth = 6;
            detailColProduct.Name = "detailColProduct";
            // 
            // detailColQty
            // 
            detailColQty.DataPropertyName = "quantity_sold";
            detailColQty.HeaderText = "Quantity Sold";
            detailColQty.MinimumWidth = 6;
            detailColQty.Name = "detailColQty";
            // 
            // detailColPrice
            // 
            detailColPrice.DataPropertyName = "unit_price_at_sale";
            detailColPrice.HeaderText = "Unit Price";
            detailColPrice.MinimumWidth = 6;
            detailColPrice.Name = "detailColPrice";
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.ColumnHeadersHeight = 29;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { transColID, transColCustomer, transColEmployee, transColTotal, transColDate });
            dgvTransactions.Dock = DockStyle.Top;
            dgvTransactions.Location = new Point(20, 20);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.Size = new Size(1160, 250);
            dgvTransactions.TabIndex = 1;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // transColID
            // 
            transColID.DataPropertyName = "transaction_id";
            transColID.HeaderText = "Transaction ID";
            transColID.MinimumWidth = 6;
            transColID.Name = "transColID";
            // 
            // transColCustomer
            // 
            transColCustomer.DataPropertyName = "customer_id";
            transColCustomer.HeaderText = "Customer ID";
            transColCustomer.MinimumWidth = 6;
            transColCustomer.Name = "transColCustomer";
            // 
            // transColEmployee
            // 
            transColEmployee.DataPropertyName = "employee_id";
            transColEmployee.HeaderText = "Employee ID";
            transColEmployee.MinimumWidth = 6;
            transColEmployee.Name = "transColEmployee";
            // 
            // transColTotal
            // 
            transColTotal.DataPropertyName = "total_amount";
            transColTotal.HeaderText = "Total Amount";
            transColTotal.MinimumWidth = 6;
            transColTotal.Name = "transColTotal";
            // 
            // transColDate
            // 
            transColDate.DataPropertyName = "transaction_date";
            transColDate.HeaderText = "Date";
            transColDate.MinimumWidth = 6;
            transColDate.Name = "transColDate";
            // 
            // SalesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlSalesList);
            Controls.Add(pnlSalesToolbar);
            Name = "SalesControl";
            Size = new Size(1200, 700);
            pnlSalesToolbar.ResumeLayout(false);
            pnlSalesToolbar.PerformLayout();
            pnlSalesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSalesToolbar;
        private Label lblSalesPageTitle;
        private Button btnSalesCreate;
        private Button btnSalesReload;
        private Panel pnlSalesList;
        private DataGridView dgvTransactions;
        private DataGridView dgvTransactionDetails;

        // Transactions columns
        private DataGridViewTextBoxColumn transColID;
        private DataGridViewTextBoxColumn transColCustomer;
        private DataGridViewTextBoxColumn transColEmployee;
        private DataGridViewTextBoxColumn transColTotal;
        private DataGridViewTextBoxColumn transColDate;

        // Transaction details columns
        private DataGridViewTextBoxColumn detailColTransID;
        private DataGridViewTextBoxColumn detailColProduct;
        private DataGridViewTextBoxColumn detailColQty;
        private DataGridViewTextBoxColumn detailColPrice;


    }
}
