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
            panelSummary = new Panel();
            btnRefreshReports = new Button();
            dgvSummary = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblSummaryTitle = new Label();
            panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            SuspendLayout();
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.White;
            panelSummary.Controls.Add(btnRefreshReports);
            panelSummary.Controls.Add(dgvSummary);
            panelSummary.Controls.Add(lblSummaryTitle);
            panelSummary.Dock = DockStyle.Fill;
            panelSummary.Location = new Point(30, 30);
            panelSummary.Name = "panelSummary";
            panelSummary.Padding = new Padding(20);
            panelSummary.Size = new Size(1140, 640);
            panelSummary.TabIndex = 0;
            // 
            // btnRefreshReports
            // 
            btnRefreshReports.BackColor = Color.SeaGreen;
            btnRefreshReports.FlatStyle = FlatStyle.Flat;
            btnRefreshReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefreshReports.ForeColor = Color.White;
            btnRefreshReports.Location = new Point(921, 14);
            btnRefreshReports.Name = "btnRefreshReports";
            btnRefreshReports.Size = new Size(120, 35);
            btnRefreshReports.TabIndex = 4;
            btnRefreshReports.Text = "Refresh Reports";
            btnRefreshReports.UseVisualStyleBackColor = false;
            // 
            // dgvSummary
            // 
            dgvSummary.AllowUserToAddRows = false;
            dgvSummary.AllowUserToDeleteRows = false;
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummary.ColumnHeadersHeight = 29;
            dgvSummary.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvSummary.Dock = DockStyle.Fill;
            dgvSummary.Location = new Point(20, 55);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.RowHeadersVisible = false;
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.Size = new Size(1100, 565);
            dgvSummary.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            // Date
            dataGridViewTextBoxColumn1.HeaderText = "Date";
            dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";

            // Total Transactions
            dataGridViewTextBoxColumn2.HeaderText = "Total Transactions";
            dataGridViewTextBoxColumn2.DataPropertyName = "TotalTransactions";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";

            // Total Sales
            dataGridViewTextBoxColumn3.HeaderText = "Total Sales";
            dataGridViewTextBoxColumn3.DataPropertyName = "TotalSales";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.Dock = DockStyle.Top;
            lblSummaryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.Black;
            lblSummaryTitle.Location = new Point(20, 20);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(1100, 35);
            lblSummaryTitle.TabIndex = 1;
            lblSummaryTitle.Text = "Daily Sales Summary";
            // 
            // ReportsControl
            // 
            BackColor = Color.FromArgb(242, 247, 244);
            Controls.Add(panelSummary);
            Name = "ReportsControl";
            Padding = new Padding(30);
            Size = new Size(1200, 700);
            panelSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ResumeLayout(false);
        }

        private Panel panelSummary;
        private Label lblSummaryTitle;
        private DataGridView dgvSummary;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btnRefreshReports;
    }
}