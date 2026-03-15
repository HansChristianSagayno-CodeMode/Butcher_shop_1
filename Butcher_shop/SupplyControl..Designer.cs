namespace Butcher_shop
{
    partial class SupplyControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRecordSupply;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvSupply;

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
            btnRefresh = new System.Windows.Forms.Button();
            btnRecordSupply = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            dgvSupply = new System.Windows.Forms.DataGridView();

            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupply).BeginInit();
            SuspendLayout();

            // Toolbar
            pnlToolbar.BackColor = System.Drawing.Color.White;
            pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlToolbar.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            pnlToolbar.Height = 70;

            // Title
            lblTitle.Text = "Supply Records";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(20, 15);

            // Record Supply Button
            btnRecordSupply.Text = "+ Record Supply";
            btnRecordSupply.BackColor = System.Drawing.Color.ForestGreen;
            btnRecordSupply.ForeColor = System.Drawing.Color.White;
            btnRecordSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRecordSupply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRecordSupply.Size = new System.Drawing.Size(150, 35);
            btnRecordSupply.Location = new System.Drawing.Point(850, 20);
            btnRecordSupply.Click += btnRecordSupply_Click;

            // Refresh Button
            btnRefresh.Text = "Refresh";
            btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRefresh.Size = new System.Drawing.Size(120, 35);
            btnRefresh.Location = new System.Drawing.Point(1010, 20);
            btnRefresh.Click += btnRefresh_Click;

            // DataGrid
            dgvSupply.Dock = System.Windows.Forms.DockStyle.Fill;

            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvSupply.BackgroundColor = System.Drawing.Color.White;
            dgvSupply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSupply.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupply.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSupply.MultiSelect = false;
            dgvSupply.ReadOnly = true;
            dgvSupply.RowHeadersVisible = false;

            // Maintained from original setup
            dgvSupply.AllowUserToAddRows = false;
            dgvSupply.AllowUserToDeleteRows = false;

            // Styling for readability
            dgvSupply.EnableHeadersVisualStyles = false;

            dgvSupply.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvSupply.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvSupply.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvSupply.ColumnHeadersHeight = 45;

            dgvSupply.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSupply.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvSupply.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvSupply.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvSupply.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvSupply.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvSupply.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            dgvSupply.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvSupply.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            // Add controls
            pnlToolbar.Controls.Add(lblTitle);
            pnlToolbar.Controls.Add(btnRecordSupply);
            pnlToolbar.Controls.Add(btnRefresh);

            Controls.Add(dgvSupply);
            Controls.Add(pnlToolbar);

            BackColor = System.Drawing.Color.WhiteSmoke;
            Size = new System.Drawing.Size(1200, 700);

            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupply).EndInit();
            ResumeLayout(false);
        }
    }
}