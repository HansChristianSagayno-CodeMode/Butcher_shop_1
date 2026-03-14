using System;
using System.Data;
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
            dgvInventory.EnableHeadersVisualStyles = false;

            // Header style
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvInventory.ColumnHeadersHeight = 40;

            // Default cell style
            dgvInventory.DefaultCellStyle.BackColor = Color.White;
            dgvInventory.DefaultCellStyle.ForeColor = Color.Black;
            dgvInventory.DefaultCellStyle.Font = new Font("Segoe UI", 11F);

            // Selection style (important fix)
            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating rows
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Row height
            dgvInventory.RowTemplate.Height = 40;

            // Grid appearance
            dgvInventory.GridColor = Color.LightGray;
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Behavior
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.RowHeadersVisible = false;

            // Column size balancing
            dgvInventory.Columns["invColProductID"].FillWeight = 15;
            dgvInventory.Columns["invColProductName"].FillWeight = 35;
            dgvInventory.Columns["invColQuantity"].FillWeight = 20;
            dgvInventory.Columns["invColUnit"].FillWeight = 15;
            dgvInventory.Columns["invColStatus"].FillWeight = 15;

            // Disable sorting
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