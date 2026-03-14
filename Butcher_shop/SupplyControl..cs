using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Butcher_shop
{
    public partial class SupplyControl : UserControl
    {
        string connectionString = "server=localhost;database=butcher_shop_db;uid=root;pwd=;";

        public SupplyControl()
        {
            InitializeComponent();

            StyleGrid();
            LoadSupplyRecords();
        }

        private void LoadSupplyRecords()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                    s.supply_id,
                                    sp.supplier_name,
                                    p.product_name,
                                    sd.unit_cost,
                                    sd.supply_quantity,
                                    s.supply_date
                                    FROM supply s
                                    JOIN supplier sp ON s.supplier_id = sp.supplier_id
                                    JOIN supply_details sd ON s.supply_id = sd.supply_id
                                    JOIN product p ON sd.product_id = p.product_id
                                    ORDER BY s.supply_date DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvSupply.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supply records: " + ex.Message);
            }
        }

        private void btnRecordSupply_Click(object sender, EventArgs e)
        {
            AddSupplyForm form = new AddSupplyForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSupplyRecords();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSupplyRecords();
        }

        private void StyleGrid()
        {
            dgvSupply.EnableHeadersVisualStyles = false;

            dgvSupply.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvSupply.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSupply.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            dgvSupply.DefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgvSupply.DefaultCellStyle.BackColor = Color.White;
            dgvSupply.DefaultCellStyle.ForeColor = Color.Black;

            dgvSupply.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvSupply.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvSupply.RowTemplate.Height = 40;

            dgvSupply.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvSupply.BorderStyle = BorderStyle.None;
            dgvSupply.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupply.GridColor = Color.LightGray;

            dgvSupply.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupply.MultiSelect = false;
            dgvSupply.RowHeadersVisible = false;

            dgvSupply.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in dgvSupply.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}