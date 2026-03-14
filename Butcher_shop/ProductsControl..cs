using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class ProductsControl : UserControl
    {
        string connString = "server=localhost;user id=root;password=;database=butcher_shop_db;";

        public ProductsControl()
        {
            InitializeComponent();

            StyleProductsGrid();
            LoadProducts();
        }

        // LOAD PRODUCTS
        private void LoadProducts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                    product_id,
                                    product_name,
                                    product_cat_type,
                                    product_unit,
                                    product_price,
                                    product_stock_level,
                                    is_active
                                    FROM PRODUCT";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvProducts.DataSource = table;

                    dgvProducts.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        // GRID STYLE
        private void StyleProductsGrid()
        {
            dgvProducts.EnableHeadersVisualStyles = false;

            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgvProducts.DefaultCellStyle.BackColor = Color.White;
            dgvProducts.DefaultCellStyle.ForeColor = Color.Black;

            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvProducts.RowTemplate.Height = 40;

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.GridColor = Color.LightGray;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.RowHeadersVisible = false;

            // column width balance
            dgvProducts.Columns["prodColID"].FillWeight = 10;
            dgvProducts.Columns["prodColName"].FillWeight = 25;
            dgvProducts.Columns["prodColCategory"].FillWeight = 20;
            dgvProducts.Columns["prodColUnit"].FillWeight = 10;
            dgvProducts.Columns["prodColPrice"].FillWeight = 15;
            dgvProducts.Columns["prodColStock"].FillWeight = 10;
            dgvProducts.Columns["prodColStatus"].FillWeight = 10;

            foreach (DataGridViewColumn col in dgvProducts.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // ADD PRODUCT
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        // REFRESH
        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // EDIT PRODUCT
        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            DataGridViewRow row = dgvProducts.SelectedRows[0];

            UpdateProductForm form = new UpdateProductForm(
                Convert.ToInt32(row.Cells["prodColID"].Value),
                row.Cells["prodColName"].Value.ToString(),
                row.Cells["prodColCategory"].Value.ToString(),
                row.Cells["prodColUnit"].Value.ToString(),
                Convert.ToDecimal(row.Cells["prodColPrice"].Value),
                Convert.ToInt32(row.Cells["prodColStock"].Value),
                Convert.ToBoolean(row.Cells["prodColStatus"].Value)
            );

            if (form.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        // DELETE PRODUCT
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(
                dgvProducts.SelectedRows[0].Cells["prodColID"].Value);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "DELETE FROM PRODUCT WHERE product_id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}