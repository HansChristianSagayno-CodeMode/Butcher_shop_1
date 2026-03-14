using System;
using System.Windows.Forms;
using System.Drawing;

namespace Butcher_shop
{
    public partial class ReportsControl : UserControl
    {
        Butcher db = new Butcher();

        public ReportsControl()
        {
            InitializeComponent();

            StyleSummaryGrid();
            LoadDailySalesReport();
        }

        private void LoadDailySalesReport()
        {
            string query = @"
            SELECT 
            DATE(transaction_date) AS Date,
            COUNT(transaction_id) AS TotalTransactions,
            SUM(total_amount) AS TotalSales
            FROM TRANSACTION
            GROUP BY DATE(transaction_date)
            ORDER BY Date DESC";

            db.displayRecord(query, dgvSummary);
        }

        private void btnRefreshReports_Click(object sender, EventArgs e)
        {
            LoadDailySalesReport();
        }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StyleSummaryGrid()
        {
            dgvSummary.EnableHeadersVisualStyles = false;

            dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvSummary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSummary.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dgvSummary.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvSummary.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);

            dgvSummary.RowTemplate.Height = 40;

            dgvSummary.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSummary.MultiSelect = false;
            dgvSummary.RowHeadersVisible = false;

            dgvSummary.BorderStyle = BorderStyle.None;
        }
    }
}