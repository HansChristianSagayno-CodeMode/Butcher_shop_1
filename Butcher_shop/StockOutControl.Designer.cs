

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
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { invColProductID, invColProductName, invColQuantity, invColUnit, invColStatus });
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.Location = new Point(20, 20);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.RowTemplate.Height = 30;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(1160, 590);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
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