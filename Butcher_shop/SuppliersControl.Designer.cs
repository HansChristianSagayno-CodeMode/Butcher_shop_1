namespace Butcher_shop
{
    partial class SuppliersControl
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlToolbar;
        private Label lblTitle;
        private Button btnRefresh;
        private Button btnAddSupplier;
        private Button btnDeleteSupplier;

        private Panel pnlContent;
        private Label lblSection;
        private DataGridView dgvSuppliers;

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
            pnlToolbar = new Panel();
            lblTitle = new Label();
            btnRefresh = new Button();
            btnAddSupplier = new Button();
            btnDeleteSupplier = new Button();

            pnlContent = new Panel();
            lblSection = new Label();
            dgvSuppliers = new DataGridView();

            pnlToolbar.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();

            // Toolbar
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Height = 70;

            pnlToolbar.Controls.Add(lblTitle);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnAddSupplier);
            pnlToolbar.Controls.Add(btnDeleteSupplier);

            // Title
            lblTitle.Text = "Suppliers";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.AutoSize = true;

            // Refresh Button
            btnRefresh.Text = "Refresh";
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(780, 20);
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.Click += btnRefresh_Click;

            // Add Supplier Button
            btnAddSupplier.Text = "+ Add Supplier";
            btnAddSupplier.BackColor = Color.SeaGreen;
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Location = new Point(890, 20);
            btnAddSupplier.Size = new Size(130, 35);
            btnAddSupplier.Click += btnAddSupplier_Click;

            // Delete Supplier Button
            btnDeleteSupplier.Text = "Delete Supplier";
            btnDeleteSupplier.BackColor = Color.Crimson;
            btnDeleteSupplier.ForeColor = Color.White;
            btnDeleteSupplier.FlatStyle = FlatStyle.Flat;
            btnDeleteSupplier.Location = new Point(1030, 20);
            btnDeleteSupplier.Size = new Size(140, 35);
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;

            // Content Panel
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Padding = new Padding(20);
            pnlContent.BackColor = Color.WhiteSmoke;

            pnlContent.Controls.Add(lblSection);
            pnlContent.Controls.Add(dgvSuppliers);

            // Section Label
            lblSection.Text = "Suppliers";
            lblSection.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSection.Location = new Point(10, 10);
            lblSection.AutoSize = true;

            // DataGridView
            // DataGridView
            dgvSuppliers.Location = new Point(10, 40);
            dgvSuppliers.Size = new Size(1120, 540);

            dgvSuppliers.BackgroundColor = Color.White;
            dgvSuppliers.BorderStyle = BorderStyle.None;

            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.ReadOnly = true;

            // Remove left selector column
            dgvSuppliers.RowHeadersVisible = false;

            // Prevent duplicate columns
            dgvSuppliers.AutoGenerateColumns = false;

            // Styling for readability
            dgvSuppliers.EnableHeadersVisualStyles = false;

            dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvSuppliers.ColumnHeadersHeight = 35;

            dgvSuppliers.DefaultCellStyle.BackColor = Color.White;
            dgvSuppliers.DefaultCellStyle.ForeColor = Color.Black;
            dgvSuppliers.DefaultCellStyle.Font = new Font("Segoe UI", 10F);

            dgvSuppliers.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvSuppliers.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            dgvSuppliers.RowTemplate.Height = 40;

            // Clear columns before adding
            dgvSuppliers.Columns.Clear();

            // Supplier ID
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "supplier_id";
            colID.HeaderText = "Supplier ID";
            colID.DataPropertyName = "supplier_id";
            dgvSuppliers.Columns.Add(colID);

            // Supplier Name
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "supplier_name";
            colName.HeaderText = "Supplier Name";
            colName.DataPropertyName = "supplier_name";
            dgvSuppliers.Columns.Add(colName);

            // Supplier Address
            DataGridViewTextBoxColumn colAddress = new DataGridViewTextBoxColumn();
            colAddress.Name = "supplier_address";
            colAddress.HeaderText = "Supplier Address";
            colAddress.DataPropertyName = "supplier_address";
            dgvSuppliers.Columns.Add(colAddress);

            // Contact
            DataGridViewTextBoxColumn colContact = new DataGridViewTextBoxColumn();
            colContact.Name = "supplier_contact";
            colContact.HeaderText = "Contact";
            colContact.DataPropertyName = "supplier_contact";
            dgvSuppliers.Columns.Add(colContact);

            // Control
            Controls.Add(pnlContent);
            Controls.Add(pnlToolbar);

            Name = "SuppliersControl";
            Size = new Size(1200, 700);

            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }
    }
}