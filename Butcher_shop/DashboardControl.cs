using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Butcher_shop
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();

            StyleGrid(dgvTransactions);

            LoadDashboardData();
        }
        string connectionString = "server=localhost;database=butcher_shop_db;uid=root;pwd=;";
        private void DashboardControl_Load(object sender, EventArgs e)
        {
            // Clear any design-time rows so tables start empty

        }

        private void panelSummaryCards_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardLowStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRecentTransactions_Paint(object sender, PaintEventArgs e)
        {

        }
        private void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            grid.ColumnHeadersHeight = 40;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.RowTemplate.Height = 35;

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false;

            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.LightGray;

            grid.BackgroundColor = Color.White;
        }
        private void lblRecentTransactions_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalProductsTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTransactionsCount_Click(object sender, EventArgs e)
        {

        }

        private void lblLowStockCount_Click(object sender, EventArgs e)
        {

        }

        private void lblLowStockCount_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadDashboardData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // TOTAL PRODUCTS
                MySqlCommand cmdProducts = new MySqlCommand(
                    "SELECT COUNT(*) FROM product WHERE is_active = 1", conn);
                lblTotalProducts.Text = cmdProducts.ExecuteScalar().ToString();

                // LOW STOCK ALERTS
                MySqlCommand cmdLowStock = new MySqlCommand(
                    "SELECT COUNT(*) FROM product WHERE product_stock_level <= 10", conn);
                lblLowStockCountValue.Text = cmdLowStock.ExecuteScalar().ToString();

                // TOTAL TRANSACTIONS
                MySqlCommand cmdTransactions = new MySqlCommand(
                    "SELECT COUNT(*) FROM transaction", conn);
                lblTransactionsCount.Text = cmdTransactions.ExecuteScalar().ToString();

                // TOTAL SALES
                MySqlCommand cmdSales = new MySqlCommand(
                    "SELECT IFNULL(SUM(total_amount),0) FROM transaction", conn);

                decimal totalSales = Convert.ToDecimal(cmdSales.ExecuteScalar());
                lblTotalSales.Text = "₱" + totalSales.ToString("N2");

                LoadRecentTransactions();
            }
        }

        private void LoadRecentTransactions()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                        transaction_id,
                        customer_id,
                        employee_id,
                        total_amount,
                        transaction_date
                        FROM transaction
                        ORDER BY transaction_date DESC
                        LIMIT 10";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvTransactions.DataSource = table;
            }
        }

        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashboardControl_Load_1(object sender, EventArgs e)
        {

        }

        private void lblLowStockAlertsTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvTransactions_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cardTotalProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardLowStock_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cardTransactions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardSales_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}