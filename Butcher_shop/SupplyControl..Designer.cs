namespace Butcher_shop
{
    partial class SupplyControl
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlToolbar;
        private Label lblTitle;
        private Button btnRecordSupply;
        private Button btnRefresh;
        private DataGridView dgvSupply;

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
            btnRefresh = new Button();
            btnRecordSupply = new Button();
            lblTitle = new Label();
            dgvSupply = new DataGridView();

            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupply).BeginInit();
            SuspendLayout();

            // Toolbar
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlToolbar.Height = 70;

            // Title
            lblTitle.Text = "Supply Records";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 15);

            // Record Supply Button
            btnRecordSupply.Text = "+ Record Supply";
            btnRecordSupply.BackColor = Color.ForestGreen;
            btnRecordSupply.ForeColor = Color.White;
            btnRecordSupply.FlatStyle = FlatStyle.Flat;
            btnRecordSupply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRecordSupply.Size = new Size(150, 35);
            btnRecordSupply.Location = new Point(850, 20);
            btnRecordSupply.Click += btnRecordSupply_Click;

            // Refresh Button
            btnRefresh.Text = "Refresh";
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.Size = new Size(120, 35);
            btnRefresh.Location = new Point(1010, 20);
            btnRefresh.Click += btnRefresh_Click;

            // DataGrid
            dgvSupply.Dock = DockStyle.Fill;
            dgvSupply.BackgroundColor = Color.White;
            dgvSupply.AllowUserToAddRows = false;
            dgvSupply.AllowUserToDeleteRows = false;

            // Add controls
            pnlToolbar.Controls.Add(lblTitle);
            pnlToolbar.Controls.Add(btnRecordSupply);
            pnlToolbar.Controls.Add(btnRefresh);

            Controls.Add(dgvSupply);
            Controls.Add(pnlToolbar);

            BackColor = Color.WhiteSmoke;
            Size = new Size(1200, 700);

            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupply).EndInit();
            ResumeLayout(false);
        }
    }
}