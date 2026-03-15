

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
            btnInventoryRefresh.BackColor = Color.FromArgb(46, 125, 50); // Secondary Green
            btnInventoryRefresh.Cursor = Cursors.Hand;
            btnInventoryRefresh.FlatAppearance.BorderSize = 0;
            btnInventoryRefresh.FlatStyle = FlatStyle.Flat;
            btnInventoryRefresh.Font = new Font("Roboto", 10F, FontStyle.Bold);
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
            btnUpdateQuantity.BackColor = Color.FromArgb(245, 124, 0); // Primary Orange
            btnUpdateQuantity.Cursor = Cursors.Hand;
            btnUpdateQuantity.FlatAppearance.BorderSize = 0;
            btnUpdateQuantity.FlatStyle = FlatStyle.Flat;
            btnUpdateQuantity.Font = new Font("Roboto", 10F, FontStyle.Bold);
            btnUpdateQuantity.ForeColor = Color.White;
            btnUpdateQuantity.Location = new Point(813, 22);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new Size(160, 35);
            btnUpdateQuantity.TabIndex = 1;
            btnUpdateQuantity.Text = "+ Record Stock Out";
            btnUpdateQuantity.UseVisualStyleBackColor = false;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // lblInventoryTitle
            // 
            lblInventoryTitle.AutoSize = true;
            lblInventoryTitle.Font = new Font("Roboto", 16F, FontStyle.Bold);
            lblInventoryTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblInventoryTitle.Location = new Point(13, 10);
            lblInventoryTitle.Name = "lblInventoryTitle";
            lblInventoryTitle.Padding = new Padding(20, 10, 20, 10);
            lblInventoryTitle.Size = new Size(175, 52);
            lblInventoryTitle.TabIndex = 1;
            lblInventoryTitle.Text = "Stock Outs";
            // 
            // pnlInventoryList
            // 
            pnlInventoryList.BackColor = Color.White;
            pnlInventoryList.Controls.Add(dgvInventory);
            pnlInventoryList.Dock = DockStyle.Fill;
            pnlInventoryList.Location = new Point(0, 70);
            pnlInventoryList.Name = "pnlInventoryList";
            pnlInventoryList.Padding = new Padding(25);
            pnlInventoryList.Size = new Size(1200, 630);
            pnlInventoryList.TabIndex = 1;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Header Style
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50); // Green Theme
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            dgvInventory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dgvInventory.ColumnHeadersHeight = 45;

            // Row Style
            dgvInventory.DefaultCellStyle.BackColor = Color.White;
            dgvInventory.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvInventory.DefaultCellStyle.Font = new Font("Roboto", 10F);
            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0); // Orange Highlight
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInventory.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            // Alternating Style
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.GridColor = Color.FromArgb(235, 235, 235);
            dgvInventory.MultiSelect = false;
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowTemplate.Height = 45;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.AutoGenerateColumns = false;

            // Define Columns
            dgvInventory.Columns.Clear();

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "stock_out_id",
                HeaderText = "Stock Out ID",
                DataPropertyName = "stock_out_id"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_id",
                HeaderText = "Product ID",
                DataPropertyName = "product_id"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity_out",
                HeaderText = "Quantity Out",
                DataPropertyName = "quantity_out"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "stock_out_date",
                HeaderText = "Date",
                DataPropertyName = "stock_out_date"
            });
            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "reason",
                HeaderText = "Reason",
                DataPropertyName = "reason"
            });

            // Final Control Settings
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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