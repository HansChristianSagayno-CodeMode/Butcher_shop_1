using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing; // Required for styling
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
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            dgvProducts.ColumnHeadersHeight = 45;

            dgvProducts.DefaultCellStyle.BackColor = Color.White;
            dgvProducts.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvProducts.DefaultCellStyle.Font = new Font("Roboto", 10F);
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0);
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProducts.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvProducts.GridColor = Color.FromArgb(235, 235, 235);
            dgvProducts.RowTemplate.Height = 45;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Maintained your column width balance
            if (dgvProducts.Columns.Contains("prodColID")) dgvProducts.Columns["prodColID"].FillWeight = 10;
            if (dgvProducts.Columns.Contains("prodColName")) dgvProducts.Columns["prodColName"].FillWeight = 25;
            if (dgvProducts.Columns.Contains("prodColCategory")) dgvProducts.Columns["prodColCategory"].FillWeight = 20;
            if (dgvProducts.Columns.Contains("prodColUnit")) dgvProducts.Columns["prodColUnit"].FillWeight = 10;
            if (dgvProducts.Columns.Contains("prodColPrice")) dgvProducts.Columns["prodColPrice"].FillWeight = 15;
            if (dgvProducts.Columns.Contains("prodColStock")) dgvProducts.Columns["prodColStock"].FillWeight = 10;
            if (dgvProducts.Columns.Contains("prodColStatus")) dgvProducts.Columns["prodColStatus"].FillWeight = 10;

            // Maintained disable sorting logic
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