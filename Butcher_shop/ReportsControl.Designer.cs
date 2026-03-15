namespace Butcher_shop
{
    partial class ReportsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelSummary = new System.Windows.Forms.Panel();
            btnRefreshReports = new System.Windows.Forms.Button();
            dgvSummary = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblSummaryTitle = new System.Windows.Forms.Label();
            panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            SuspendLayout();
            // 
            // panelSummary
            // 
            panelSummary.BackColor = System.Drawing.Color.White;
            panelSummary.Controls.Add(btnRefreshReports);
            panelSummary.Controls.Add(dgvSummary);
            panelSummary.Controls.Add(lblSummaryTitle);
            panelSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSummary.Location = new System.Drawing.Point(30, 30);
            panelSummary.Name = "panelSummary";
            panelSummary.Padding = new System.Windows.Forms.Padding(20);
            panelSummary.Size = new System.Drawing.Size(1140, 640);
            panelSummary.TabIndex = 0;
            // 
            // btnRefreshReports
            // 
            btnRefreshReports.BackColor = System.Drawing.Color.SeaGreen;
            btnRefreshReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefreshReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRefreshReports.ForeColor = System.Drawing.Color.White;
            btnRefreshReports.Location = new System.Drawing.Point(921, 14);
            btnRefreshReports.Name = "btnRefreshReports";
            btnRefreshReports.Size = new System.Drawing.Size(120, 35);
            btnRefreshReports.TabIndex = 4;
            btnRefreshReports.Text = "Refresh Reports";
            btnRefreshReports.UseVisualStyleBackColor = false;
            btnRefreshReports.Click += btnRefreshReports_Click;
            // 
            // dgvSummary
            // 
            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvSummary.BackgroundColor = System.Drawing.Color.White;
            dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSummary.MultiSelect = false;
            dgvSummary.ReadOnly = true;
            dgvSummary.RowHeadersVisible = false;

            // Maintained from original setup
            dgvSummary.AllowUserToAddRows = false;
            dgvSummary.AllowUserToDeleteRows = false;
            dgvSummary.AutoGenerateColumns = false;

            // Styling for readability
            dgvSummary.EnableHeadersVisualStyles = false;

            dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvSummary.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvSummary.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvSummary.ColumnHeadersHeight = 45;

            dgvSummary.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSummary.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvSummary.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvSummary.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvSummary.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvSummary.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvSummary.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            dgvSummary.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvSummary.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSummary.Location = new System.Drawing.Point(20, 55);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.Size = new System.Drawing.Size(1100, 565);
            dgvSummary.TabIndex = 0;
            dgvSummary.CellContentClick += dgvSummary_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            dataGridViewTextBoxColumn1.HeaderText = "Date";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TotalTransactions";
            dataGridViewTextBoxColumn2.HeaderText = "Total Transactions";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "TotalSales";
            dataGridViewTextBoxColumn3.HeaderText = "Total Sales";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblSummaryTitle.ForeColor = System.Drawing.Color.Black;
            lblSummaryTitle.Location = new System.Drawing.Point(20, 20);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new System.Drawing.Size(1100, 35);
            lblSummaryTitle.TabIndex = 1;
            lblSummaryTitle.Text = "Daily Sales Summary";
            // 
            // ReportsControl
            // 
            BackColor = System.Drawing.Color.FromArgb(242, 247, 244);
            Controls.Add(panelSummary);
            Name = "ReportsControl";
            Padding = new System.Windows.Forms.Padding(30);
            Size = new System.Drawing.Size(1200, 700);
            panelSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnRefreshReports;
    }
}