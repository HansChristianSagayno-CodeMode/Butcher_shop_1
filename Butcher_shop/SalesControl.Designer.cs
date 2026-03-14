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
            lblSalesPageTitle = new Label();
            btnSalesCreate = new Button();
            btnSalesReload = new Button();
            pnlSalesList = new Panel();
            dgvTransactions = new DataGridView();
            dgvTransactionDetails = new DataGridView();

         
            pnlSalesToolbar.SuspendLayout();
            pnlSalesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).BeginInit();
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
            // 
            // pnlSalesList
            // 
            // pnlSalesList
            pnlSalesList.Dock = DockStyle.Fill;
            pnlSalesList.Location = new Point(0, 70);
            pnlSalesList.Name = "pnlSalesList";
            pnlSalesList.Padding = new Padding(20);
            pnlSalesList.Size = new Size(1200, 630);
            pnlSalesList.TabIndex = 1;

            // TRANSACTIONS TABLE
            dgvTransactions = new DataGridView();
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.Dock = DockStyle.Top;
            dgvTransactions.Height = 250;

            transColID = new DataGridViewTextBoxColumn();
            transColID.DataPropertyName = "transaction_id";
            transColID.HeaderText = "Transaction ID";

            transColCustomer = new DataGridViewTextBoxColumn();
            transColCustomer.DataPropertyName = "customer_id";
            transColCustomer.HeaderText = "Customer ID";

            transColEmployee = new DataGridViewTextBoxColumn();
            transColEmployee.DataPropertyName = "employee_id";
            transColEmployee.HeaderText = "Employee ID";

            transColTotal = new DataGridViewTextBoxColumn();
            transColTotal.DataPropertyName = "total_amount";
            transColTotal.HeaderText = "Total Amount";

            transColDate = new DataGridViewTextBoxColumn();
            transColDate.DataPropertyName = "transaction_date";
            transColDate.HeaderText = "Date";

            dgvTransactions.Columns.AddRange(new DataGridViewColumn[]
            {
    transColID,
    transColCustomer,
    transColEmployee,
    transColTotal,
    transColDate
            });
            // TRANSACTION DETAILS TABLE
            dgvTransactionDetails = new DataGridView();
            dgvTransactionDetails.AllowUserToAddRows = false;
            dgvTransactionDetails.AllowUserToDeleteRows = false;
            dgvTransactionDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactionDetails.BackgroundColor = Color.White;
            dgvTransactionDetails.Dock = DockStyle.Fill;

            detailColTransID = new DataGridViewTextBoxColumn();
            detailColTransID.DataPropertyName = "transaction_id";
            detailColTransID.HeaderText = "Transaction ID";

            detailColProduct = new DataGridViewTextBoxColumn();
            detailColProduct.DataPropertyName = "product_id";
            detailColProduct.HeaderText = "Product ID";

            detailColQty = new DataGridViewTextBoxColumn();
            detailColQty.DataPropertyName = "quantity_sold";
            detailColQty.HeaderText = "Quantity Sold";

            detailColPrice = new DataGridViewTextBoxColumn();
            detailColPrice.DataPropertyName = "unit_price_at_sale";
            detailColPrice.HeaderText = "Unit Price";


            dgvTransactionDetails.Columns.AddRange(new DataGridViewColumn[]
            {
    detailColTransID,
    detailColProduct,
    detailColQty,
    detailColPrice
            });

            pnlSalesList.Controls.Add(dgvTransactionDetails);
            pnlSalesList.Controls.Add(dgvTransactions);
            // 

            // 

            // 

            // salesColTotal
            // 

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
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionDetails).EndInit();
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
