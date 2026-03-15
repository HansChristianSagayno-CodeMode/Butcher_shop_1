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

            // Applies the new design system to both tables
            StyleGrid(dgvTransactions);
            StyleGrid(dgvTransactionDetails);

            LoadTransactions();
        }

        private void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            grid.ColumnHeadersHeight = 45;

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            grid.DefaultCellStyle.Font = new Font("Roboto", 10F);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            grid.GridColor = Color.FromArgb(235, 235, 235);
            grid.RowTemplate.Height = 45;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.RowHeadersVisible = false;
            grid.ReadOnly = true;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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