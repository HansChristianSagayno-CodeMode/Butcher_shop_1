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
            dgvSummary.BackgroundColor = Color.White;
            dgvSummary.BorderStyle = BorderStyle.None;
            dgvSummary.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSummary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvSummary.EnableHeadersVisualStyles = false;
            dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvSummary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSummary.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            dgvSummary.ColumnHeadersHeight = 45;

            dgvSummary.DefaultCellStyle.BackColor = Color.White;
            dgvSummary.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvSummary.DefaultCellStyle.Font = new Font("Roboto", 10F);
            dgvSummary.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0);
            dgvSummary.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSummary.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvSummary.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvSummary.GridColor = Color.FromArgb(235, 235, 235);
            dgvSummary.RowTemplate.Height = 45;
            dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSummary.MultiSelect = false;
            dgvSummary.RowHeadersVisible = false;
            dgvSummary.ReadOnly = true;
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}