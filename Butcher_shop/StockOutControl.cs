using System;
using System.Drawing;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class StockOutControl : UserControl
    {
        Butcher db = new Butcher();

        public StockOutControl()
        {
            InitializeComponent();

            StyleStockOutGrid();
            LoadStockOuts();
        }

        // LOAD STOCK OUT RECORDS
        public void LoadStockOuts()
        {
            string query = "SELECT stock_out_id, product_id, quantity_out, stock_out_date, reason FROM STOCK_OUT";

            db.displayRecord(query, dgvInventory);
        }

        // OPEN ADD STOCK OUT FORM
        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            AddStockOutForm form = new AddStockOutForm();
            form.ShowDialog();

            LoadStockOuts();
        }

        // REFRESH BUTTON
        private void btnInventoryRefresh_Click(object sender, EventArgs e)
        {
            LoadStockOuts();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // GRID DESIGN
        private void StyleStockOutGrid()
        {
            dgvInventory.EnableHeadersVisualStyles = false;

            // Header Style: Using the Green Secondary Color
            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11, FontStyle.Bold);
            dgvInventory.ColumnHeadersHeight = 45;

            // Row Style
            dgvInventory.DefaultCellStyle.Font = new Font("Roboto", 10);
            dgvInventory.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0); // Orange Selection
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvInventory.RowTemplate.Height = 45;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.GridColor = Color.FromArgb(235, 235, 235);

            // Subtle Alternating Rows
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;
            dgvInventory.RowHeadersVisible = false;

            // Column Fill Weights (Ensuring total visibility)
            if (dgvInventory.Columns.Count >= 5)
            {
                dgvInventory.Columns[0].FillWeight = 15;
                dgvInventory.Columns[1].FillWeight = 15;
                dgvInventory.Columns[2].FillWeight = 20;
                dgvInventory.Columns[3].FillWeight = 20;
                dgvInventory.Columns[4].FillWeight = 30;
            }

            foreach (DataGridViewColumn col in dgvInventory.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}