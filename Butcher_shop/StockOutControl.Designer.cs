

namespace Butcher_shop
{
    partial class StockOutControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            pnlInventoryToolbar = new Panel();
            btnInventoryRefresh = new Button();
            btnUpdateQuantity = new Button();
            lblInventoryTitle = new Label();
            pnlInventoryList = new Panel();
            dgvInventory = new DataGridView();
            invColProductID = new DataGridViewTextBoxColumn();
            invColProductName = new DataGridViewTextBoxColumn();
            invColQuantity = new DataGridViewTextBoxColumn();
            invColUnit = new DataGridViewTextBoxColumn();
            invColStatus = new DataGridViewTextBoxColumn();
            pnlInventoryToolbar.SuspendLayout();
            pnlInventoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // pnlInventoryToolbar
            // 
            pnlInventoryToolbar.BackColor = Color.White;
            pnlInventoryToolbar.Controls.Add(btnInventoryRefresh);
            pnlInventoryToolbar.Controls.Add(btnUpdateQuantity);
            pnlInventoryToolbar.Controls.Add(lblInventoryTitle);
            pnlInventoryToolbar.Dock = DockStyle.Top;
            pnlInventoryToolbar.Location = new Point(0, 0);
            pnlInventoryToolbar.Name = "pnlInventoryToolbar";
            pnlInventoryToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlInventoryToolbar.Size = new Size(1200, 70);
            pnlInventoryToolbar.TabIndex = 0;
            // 
            // btnInventoryRefresh
            // 
            btnInventoryRefresh.BackColor = Color.SteelBlue;
            btnInventoryRefresh.FlatStyle = FlatStyle.Flat;
            btnInventoryRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventoryRefresh.ForeColor = Color.White;
            btnInventoryRefresh.Location = new Point(993, 22);
            btnInventoryRefresh.Name = "btnInventoryRefresh";
            btnInventoryRefresh.Size = new Size(120, 35);
            btnInventoryRefresh.TabIndex = 2;
            btnInventoryRefresh.Text = "Refresh";
            btnInventoryRefresh.UseVisualStyleBackColor = false;
            btnInventoryRefresh.Click += btnInventoryRefresh_Click;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.BackColor = Color.DarkGoldenrod;
            btnUpdateQuantity.FlatStyle = FlatStyle.Flat;
            btnUpdateQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateQuantity.ForeColor = Color.White;
            btnUpdateQuantity.Location = new Point(813, 22);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(120, 35);
            btnUpdateQuantity.TabIndex = 1;
            btnUpdateQuantity.Text = "+ Record Stock Out";
            btnUpdateQuantity.UseVisualStyleBackColor = false;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // lblInventoryTitle
            // 
            lblInventoryTitle.AutoSize = true;
            lblInventoryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInventoryTitle.ForeColor = Color.Black;
            lblInventoryTitle.Location = new Point(13, 10);
            lblInventoryTitle.Name = "lblInventoryTitle";
            lblInventoryTitle.Padding = new Padding(20, 10, 20, 10);
            lblInventoryTitle.Size = new Size(175, 52);
            lblInventoryTitle.TabIndex = 1;
            lblInventoryTitle.Text = "Stock Outs";
            // 
            // pnlInventoryList
            // 
            pnlInventoryList.Controls.Add(dgvInventory);
            pnlInventoryList.Dock = DockStyle.Fill;
            pnlInventoryList.Location = new Point(0, 70);
            pnlInventoryList.Name = "pnlInventoryList";
            pnlInventoryList.Padding = new Padding(20);
            pnlInventoryList.Size = new Size(1200, 630);
            pnlInventoryList.TabIndex = 1;
            // 
            // dgvInventory
            // =============================
            // DataGridView Styling
            // =============================

            dgvInventory.Dock = DockStyle.Fill;

            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.ReadOnly = true;

            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeRows = false;

            // Remove left selector column
            dgvInventory.RowHeadersVisible = false;

            // Prevent duplicate columns
            dgvInventory.AutoGenerateColumns = false;

            // Header style
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvInventory.ColumnHeadersHeight = 35;

            // Row style
            dgvInventory.DefaultCellStyle.BackColor = Color.White;
            dgvInventory.DefaultCellStyle.ForeColor = Color.Black;
            dgvInventory.DefaultCellStyle.Font = new Font("Segoe UI", 11F);

            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating rows
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            // Larger rows for readability
            dgvInventory.RowTemplate.Height = 40;

            // Clear columns first (prevents duplication)
            dgvInventory.Columns.Clear();

            // =============================
            // Columns
            // =============================

            // Stock Out ID
            DataGridViewTextBoxColumn colStockID = new DataGridViewTextBoxColumn();
            colStockID.Name = "stock_out_id";
            colStockID.HeaderText = "Stock Out ID";
            colStockID.DataPropertyName = "stock_out_id";
            dgvInventory.Columns.Add(colStockID);

            // Product ID
            DataGridViewTextBoxColumn colProductID = new DataGridViewTextBoxColumn();
            colProductID.Name = "product_id";
            colProductID.HeaderText = "Product ID";
            colProductID.DataPropertyName = "product_id";
            dgvInventory.Columns.Add(colProductID);

            // Quantity Out
            DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
            colQty.Name = "quantity_out";
            colQty.HeaderText = "Quantity Out";
            colQty.DataPropertyName = "quantity_out";
            dgvInventory.Columns.Add(colQty);

            // Date
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.Name = "stock_out_date";
            colDate.HeaderText = "Date";
            colDate.DataPropertyName = "stock_out_date";
            dgvInventory.Columns.Add(colDate);

            // Reason
            DataGridViewTextBoxColumn colReason = new DataGridViewTextBoxColumn();
            colReason.Name = "reason";
            colReason.HeaderText = "Reason";
            colReason.DataPropertyName = "reason";
            dgvInventory.Columns.Add(colReason);
            // 
            // invColProductID
            // 
            invColProductID.DataPropertyName = "stock_out_id";
            invColProductID.HeaderText = "Stock Out ID";
            invColProductID.MinimumWidth = 6;
            invColProductID.Name = "invColProductID";
            invColProductID.ReadOnly = true;
            // 
            // invColProductName
            // 
            invColProductName.DataPropertyName = "product_id";
            invColProductName.HeaderText = "Product ID";
            invColProductName.MinimumWidth = 6;
            invColProductName.Name = "invColProductName";
            invColProductName.ReadOnly = true;
            // 
            // invColQuantity
            // 
            invColQuantity.DataPropertyName = "quantity_out";
            invColQuantity.HeaderText = "Quantity Out";
            invColQuantity.MinimumWidth = 6;
            invColQuantity.Name = "invColQuantity";
            invColQuantity.ReadOnly = true;
            // 
            // invColUnit
            // 
            invColUnit.DataPropertyName = "stock_out_date";
            invColUnit.HeaderText = "Date";
            invColUnit.MinimumWidth = 6;
            invColUnit.Name = "invColUnit";
            invColUnit.ReadOnly = true;
            // 
            // invColStatus
            // 
            invColStatus.DataPropertyName = "reason";
            invColStatus.HeaderText = "Reason";
            invColStatus.MinimumWidth = 6;
            invColStatus.Name = "invColStatus";
            invColStatus.ReadOnly = true;
            // 
            // StockOutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlInventoryList);
            Controls.Add(pnlInventoryToolbar);
            Name = "StockOutControl";
            Size = new Size(1200, 700);
            pnlInventoryToolbar.ResumeLayout(false);
            pnlInventoryToolbar.PerformLayout();
            pnlInventoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInventoryToolbar;
        private Label lblInventoryTitle;
        private Button btnUpdateQuantity;
        private Button btnInventoryRefresh;
        private Panel pnlInventoryList;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn invColProductID;
        private DataGridViewTextBoxColumn invColProductName;
        private DataGridViewTextBoxColumn invColQuantity;
        private DataGridViewTextBoxColumn invColUnit;
        private DataGridViewTextBoxColumn invColStatus;
    }
}