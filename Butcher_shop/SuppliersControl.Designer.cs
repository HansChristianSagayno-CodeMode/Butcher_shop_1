namespace Butcher_shop
{
    partial class SuppliersControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.DataGridView dgvSuppliers;

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
            pnlToolbar = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            btnAddSupplier = new System.Windows.Forms.Button();
            btnDeleteSupplier = new System.Windows.Forms.Button();

            pnlContent = new System.Windows.Forms.Panel();
            lblSection = new System.Windows.Forms.Label();
            dgvSuppliers = new System.Windows.Forms.DataGridView();

            pnlToolbar.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();

            // Toolbar
            pnlToolbar.BackColor = System.Drawing.Color.White;
            pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlToolbar.Height = 70;

            pnlToolbar.Controls.Add(lblTitle);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnAddSupplier);
            pnlToolbar.Controls.Add(btnDeleteSupplier);

            // Title
            lblTitle.Text = "Suppliers";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.AutoSize = true;

            // Refresh Button
            btnRefresh.Text = "Refresh";
            btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Location = new System.Drawing.Point(780, 20);
            btnRefresh.Size = new System.Drawing.Size(100, 35);
            btnRefresh.Click += btnRefresh_Click;

            // Add Supplier Button
            btnAddSupplier.Text = "+ Add Supplier";
            btnAddSupplier.BackColor = System.Drawing.Color.SeaGreen;
            btnAddSupplier.ForeColor = System.Drawing.Color.White;
            btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddSupplier.Location = new System.Drawing.Point(890, 20);
            btnAddSupplier.Size = new System.Drawing.Size(130, 35);
            btnAddSupplier.Click += btnAddSupplier_Click;

            // Delete Supplier Button
            btnDeleteSupplier.Text = "Delete Supplier";
            btnDeleteSupplier.BackColor = System.Drawing.Color.Crimson;
            btnDeleteSupplier.ForeColor = System.Drawing.Color.White;
            btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteSupplier.Location = new System.Drawing.Point(1030, 20);
            btnDeleteSupplier.Size = new System.Drawing.Size(140, 35);
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;

            // Content Panel
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Padding = new System.Windows.Forms.Padding(20);
            pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;

            pnlContent.Controls.Add(lblSection);
            pnlContent.Controls.Add(dgvSuppliers);

            // Section Label
            lblSection.Text = "Suppliers";
            lblSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblSection.Location = new System.Drawing.Point(10, 10);
            lblSection.AutoSize = true;

            // DataGridView
            dgvSuppliers.Location = new System.Drawing.Point(10, 40);
            dgvSuppliers.Size = new System.Drawing.Size(1120, 540);

            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.AutoGenerateColumns = false;

            // Styling for readability
            dgvSuppliers.EnableHeadersVisualStyles = false;

            dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvSuppliers.ColumnHeadersHeight = 45;

            dgvSuppliers.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSuppliers.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvSuppliers.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvSuppliers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvSuppliers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvSuppliers.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvSuppliers.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            // Clear columns before adding
            dgvSuppliers.Columns.Clear();

            // Supplier ID (UNCHANGED)
            System.Windows.Forms.DataGridViewTextBoxColumn colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colID.Name = "supplier_id";
            colID.HeaderText = "Supplier ID";
            colID.DataPropertyName = "supplier_id";
            dgvSuppliers.Columns.Add(colID);

            // Supplier Name (UNCHANGED)
            System.Windows.Forms.DataGridViewTextBoxColumn colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName.Name = "supplier_name";
            colName.HeaderText = "Supplier Name";
            colName.DataPropertyName = "supplier_name";
            dgvSuppliers.Columns.Add(colName);

            // Supplier Address (UNCHANGED)
            System.Windows.Forms.DataGridViewTextBoxColumn colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAddress.Name = "supplier_address";
            colAddress.HeaderText = "Supplier Address";
            colAddress.DataPropertyName = "supplier_address";
            dgvSuppliers.Columns.Add(colAddress);

            // Contact (UNCHANGED)
            System.Windows.Forms.DataGridViewTextBoxColumn colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colContact.Name = "supplier_contact";
            colContact.HeaderText = "Contact";
            colContact.DataPropertyName = "supplier_contact";
            dgvSuppliers.Columns.Add(colContact);

            // Control
            Controls.Add(pnlContent);
            Controls.Add(pnlToolbar);

            Name = "SuppliersControl";
            Size = new System.Drawing.Size(1200, 700);

            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }
    }
}