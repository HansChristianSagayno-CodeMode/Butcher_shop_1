using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class DashboardControl : UserControl
    {
        // MySQL Connection String
        string connString = "server=localhost;user id=root;password=;database=butcher_shop_db;";

        public DashboardControl()
        {
            InitializeComponent();

            // Apply the new standardized design system
            StyleGrid(dgvTransactions);

            // Load dashboard metrics and grid data
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    // 1. Total Products (Active)
                    string queryProducts = "SELECT COUNT(*) FROM PRODUCT WHERE is_active = 1";
                    using (MySqlCommand cmd = new MySqlCommand(queryProducts, conn))
                    {
                        lblTotalProducts.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                    }

                    // 2. Low Stock Alerts (Assuming threshold is < 10, adjust if needed)
                    string queryLowStock = "SELECT COUNT(*) FROM PRODUCT WHERE product_stock_level < 10 AND is_active = 1";
                    using (MySqlCommand cmd = new MySqlCommand(queryLowStock, conn))
                    {
                        lblLowStockCountValue.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                    }

                    // 3. Total Transactions
                    string queryTransactions = "SELECT COUNT(*) FROM TRANSACTION";
                    using (MySqlCommand cmd = new MySqlCommand(queryTransactions, conn))
                    {
                        lblTransactionsCount.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                    }

                    // 4. Total Sales
                    string querySales = "SELECT SUM(total_amount) FROM TRANSACTION";
                    using (MySqlCommand cmd = new MySqlCommand(querySales, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal totalSales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        lblTotalSales.Text = "₱" + totalSales.ToString("N2");
                    }

                    // 5. Recent Transactions Grid
                    string queryGrid = @"SELECT 
                                        transaction_id,
                                        customer_id,
                                        employee_id,
                                        total_amount,
                                        transaction_date
                                        FROM transaction
                                        ORDER BY transaction_date DESC
                                        LIMIT 10";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(queryGrid, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvTransactions.DataSource = table;
                    dgvTransactions.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 45;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgv.DefaultCellStyle.Font = new Font("Roboto", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgv.GridColor = Color.FromArgb(235, 235, 235);
            dgv.RowTemplate.Height = 45;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --- Event Handlers required by your Designer ---

        private void cardTotalProducts_Paint(object sender, PaintEventArgs e) { }
        private void cardLowStock_Paint_1(object sender, PaintEventArgs e) { }
        private void cardTransactions_Paint(object sender, PaintEventArgs e) { }
        private void cardSales_Paint(object sender, PaintEventArgs e) { }
        private void dgvTransactions_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
    }
}