using System.Drawing;
using System.Windows.Forms;

namespace Butcher_shop
{
    partial class InventoryControl
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
            pnlInventoryToolbar = new System.Windows.Forms.Panel();
            btnInventoryRefresh = new System.Windows.Forms.Button();
            btnUpdateQuantity = new System.Windows.Forms.Button();
            lblInventoryTitle = new System.Windows.Forms.Label();
            pnlInventoryList = new System.Windows.Forms.Panel();
            dgvInventory = new System.Windows.Forms.DataGridView();
            invColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            invColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            invColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            invColUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            invColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlInventoryToolbar.SuspendLayout();
            pnlInventoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // pnlInventoryToolbar
            // 
            pnlInventoryToolbar.BackColor = System.Drawing.Color.White;
            pnlInventoryToolbar.Controls.Add(btnInventoryRefresh);
            pnlInventoryToolbar.Controls.Add(btnUpdateQuantity);
            pnlInventoryToolbar.Controls.Add(lblInventoryTitle);
            pnlInventoryToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlInventoryToolbar.Location = new System.Drawing.Point(0, 0);
            pnlInventoryToolbar.Name = "pnlInventoryToolbar";
            pnlInventoryToolbar.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            pnlInventoryToolbar.Size = new System.Drawing.Size(1200, 70);
            pnlInventoryToolbar.TabIndex = 0;
            // 
            // btnInventoryRefresh
            // 
            btnInventoryRefresh.BackColor = System.Drawing.Color.SteelBlue;
            btnInventoryRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInventoryRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnInventoryRefresh.ForeColor = System.Drawing.Color.White;
            btnInventoryRefresh.Location = new System.Drawing.Point(993, 22);
            btnInventoryRefresh.Name = "btnInventoryRefresh";
            btnInventoryRefresh.Size = new System.Drawing.Size(120, 35);
            btnInventoryRefresh.TabIndex = 2;
            btnInventoryRefresh.Text = "Refresh";
            btnInventoryRefresh.UseVisualStyleBackColor = false;
            btnInventoryRefresh.Click += btnInventoryRefresh_Click;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.BackColor = System.Drawing.Color.DarkGoldenrod;
            btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpdateQuantity.ForeColor = System.Drawing.Color.White;
            btnUpdateQuantity.Location = new System.Drawing.Point(813, 22);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new System.Drawing.Size(120, 35);
            btnUpdateQuantity.TabIndex = 1;
            btnUpdateQuantity.Text = "Update Quantity";
            btnUpdateQuantity.UseVisualStyleBackColor = false;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
            // 
            // lblInventoryTitle
            // 
            lblInventoryTitle.AutoSize = true;
            lblInventoryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblInventoryTitle.ForeColor = System.Drawing.Color.Black;
            lblInventoryTitle.Location = new System.Drawing.Point(13, 10);
            lblInventoryTitle.Name = "lblInventoryTitle";
            lblInventoryTitle.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            lblInventoryTitle.Size = new System.Drawing.Size(166, 52);
            lblInventoryTitle.TabIndex = 1;
            lblInventoryTitle.Text = "Inventory";
            // 
            // pnlInventoryList
            // 
            pnlInventoryList.Controls.Add(dgvInventory);
            pnlInventoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlInventoryList.Location = new System.Drawing.Point(0, 70);
            pnlInventoryList.Name = "pnlInventoryList";
            pnlInventoryList.Padding = new System.Windows.Forms.Padding(20);
            pnlInventoryList.Size = new System.Drawing.Size(1200, 630);
            pnlInventoryList.TabIndex = 1;
            // 
            // dgvInventory
            // 
            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvInventory.BackgroundColor = System.Drawing.Color.White;
            dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;

            // Maintained from original setup
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AutoGenerateColumns = false;

            // Styling for readability
            dgvInventory.EnableHeadersVisualStyles = false;

            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvInventory.ColumnHeadersHeight = 45;

            dgvInventory.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvInventory.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvInventory.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvInventory.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvInventory.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvInventory.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            dgvInventory.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvInventory.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { invColProductID, invColProductName, invColQuantity, invColUnit, invColStatus });
            dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvInventory.Location = new System.Drawing.Point(20, 20);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.Size = new System.Drawing.Size(1160, 590);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // invColProductID
            // 
            invColProductID.DataPropertyName = "product_id";
            invColProductID.HeaderText = "Product ID";
            invColProductID.MinimumWidth = 6;
            invColProductID.Name = "invColProductID";
            invColProductID.ReadOnly = true;
            // 
            // invColProductName
            // 
            invColProductName.DataPropertyName = "product_name";
            invColProductName.HeaderText = "Product Name";
            invColProductName.MinimumWidth = 6;
            invColProductName.Name = "invColProductName";
            invColProductName.ReadOnly = true;
            // 
            // invColQuantity
            // 
            invColQuantity.DataPropertyName = "product_stock_level";
            invColQuantity.HeaderText = "Stock Level";
            invColQuantity.MinimumWidth = 6;
            invColQuantity.Name = "invColQuantity";
            invColQuantity.ReadOnly = true;
            // 
            // invColUnit
            // 
            invColUnit.DataPropertyName = "product_unit";
            invColUnit.HeaderText = "Unit";
            invColUnit.MinimumWidth = 6;
            invColUnit.Name = "invColUnit";
            invColUnit.ReadOnly = true;
            // 
            // invColStatus
            // 
            invColStatus.DataPropertyName = "is_active";
            invColStatus.HeaderText = "Active";
            invColStatus.MinimumWidth = 6;
            invColStatus.Name = "invColStatus";
            invColStatus.ReadOnly = true;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(pnlInventoryList);
            Controls.Add(pnlInventoryToolbar);
            Name = "InventoryControl";
            Size = new System.Drawing.Size(1200, 700);
            pnlInventoryToolbar.ResumeLayout(false);
            pnlInventoryToolbar.PerformLayout();
            pnlInventoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlInventoryToolbar;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.Button btnInventoryRefresh;
        private System.Windows.Forms.Panel pnlInventoryList;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn invColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn invColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn invColUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn invColStatus;
    }
}