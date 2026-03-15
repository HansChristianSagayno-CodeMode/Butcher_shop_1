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
            dgvSupply.BackgroundColor = Color.White;
            dgvSupply.BorderStyle = BorderStyle.None;
            dgvSupply.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupply.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvSupply.EnableHeadersVisualStyles = false;
            dgvSupply.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvSupply.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSupply.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            dgvSupply.ColumnHeadersHeight = 45;

            dgvSupply.DefaultCellStyle.BackColor = Color.White;
            dgvSupply.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvSupply.DefaultCellStyle.Font = new Font("Roboto", 10F);
            dgvSupply.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0);
            dgvSupply.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSupply.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvSupply.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvSupply.GridColor = Color.FromArgb(235, 235, 235);
            dgvSupply.RowTemplate.Height = 45;
            dgvSupply.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupply.MultiSelect = false;
            dgvSupply.RowHeadersVisible = false;
            dgvSupply.ReadOnly = true;
            dgvSupply.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Preserved from original logic
            foreach (DataGridViewColumn col in dgvSupply.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}