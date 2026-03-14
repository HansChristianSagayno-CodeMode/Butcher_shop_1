using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class SalesControl : UserControl
    {
        string connectionString = "server=localhost;database=butcher_shop_db;uid=root;pwd=;";

        public SalesControl()
        {
            InitializeComponent();
            StyleGrid(dgvTransactions);
            StyleGrid(dgvTransactionDetails);

            LoadTransactions();
        }

        private void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;

            // Header style
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            grid.ColumnHeadersHeight = 40;

            // Cell style
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.RowTemplate.Height = 40;

            // Alternate row color
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Grid settings
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.RowHeadersVisible = false;

            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.LightGray;

            grid.BackgroundColor = Color.White;
        }

        private void LoadTransactions()
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
                                ORDER BY transaction_date DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvTransactions.DataSource = table;
            }
        }

        private void LoadTransactionDetails(int transactionID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                transaction_id,
                                product_id,
                                quantity_sold,
                                unit_price_at_sale
                                FROM transaction_details
                                WHERE transaction_id = @id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@id", transactionID);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvTransactionDetails.DataSource = table;
            }
        }

        private void btnSalesCreate_Click(object sender, EventArgs e)
        {
            AddSaleForm form = new AddSaleForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTransactions();
            }
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnSalesReload_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int transactionID = Convert.ToInt32(dgvTransactions.Rows[e.RowIndex].Cells["transColID"].Value);

                LoadTransactionDetails(transactionID);
            }
        }
    }
}