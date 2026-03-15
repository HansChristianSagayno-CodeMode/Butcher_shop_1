using System;
using System.Data;
using System.Drawing; // Required for styling
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Butcher_shop
{
    public partial class InventoryControl : UserControl
    {
        // MySQL Connection
        string connectionString = "server=localhost;user id=root;password=;database=butcher_shop_db;";

        public InventoryControl()
        {
            InitializeComponent();

            StyleInventoryGrid();

            LoadInventory();
        }

        // LOAD INVENTORY
        private void LoadInventory()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                    product_id,
                                    product_name,
                                    product_stock_level,
                                    product_unit,
                                    is_active
                                    FROM PRODUCT";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvInventory.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
        }

        // REFRESH BUTTON
        private void btnInventoryRefresh_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        // UPDATE QUANTITY BUTTON
        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            DataGridViewRow row = dgvInventory.SelectedRows[0];

            UpdateProductForm form = new UpdateProductForm(
                Convert.ToInt32(row.Cells["invColProductID"].Value),
                row.Cells["invColProductName"].Value.ToString(),
                "",
                row.Cells["invColUnit"].Value.ToString(),
                0,
                Convert.ToInt32(row.Cells["invColQuantity"].Value),
                Convert.ToBoolean(row.Cells["invColStatus"].Value)
            );

            if (form.ShowDialog() == DialogResult.OK)
                LoadInventory();
        }

        private void StyleInventoryGrid()
        {
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            dgvInventory.ColumnHeadersHeight = 45;

            dgvInventory.DefaultCellStyle.BackColor = Color.White;
            dgvInventory.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvInventory.DefaultCellStyle.Font = new Font("Roboto", 10F);
            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0);
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInventory.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvInventory.GridColor = Color.FromArgb(235, 235, 235);
            dgvInventory.RowTemplate.Height = 45;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ReadOnly = true;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Maintained your specific column size balancing
            if (dgvInventory.Columns.Contains("invColProductID"))
                dgvInventory.Columns["invColProductID"].FillWeight = 15;
            if (dgvInventory.Columns.Contains("invColProductName"))
                dgvInventory.Columns["invColProductName"].FillWeight = 35;
            if (dgvInventory.Columns.Contains("invColQuantity"))
                dgvInventory.Columns["invColQuantity"].FillWeight = 20;
            if (dgvInventory.Columns.Contains("invColUnit"))
                dgvInventory.Columns["invColUnit"].FillWeight = 15;
            if (dgvInventory.Columns.Contains("invColStatus"))
                dgvInventory.Columns["invColStatus"].FillWeight = 15;

            // Maintained sorting disable logic
            foreach (DataGridViewColumn col in dgvInventory.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        // UPDATE DATABASE
        private void UpdateStock(int productID, int quantity)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE PRODUCT 
                                     SET product_stock_level = @qty
                                     WHERE product_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@qty", quantity);
                    cmd.Parameters.AddWithValue("@id", productID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Stock updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message);
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}