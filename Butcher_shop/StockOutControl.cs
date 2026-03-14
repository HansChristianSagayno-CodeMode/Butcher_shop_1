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

            dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dgvInventory.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvInventory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvInventory.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvInventory.RowTemplate.Height = 40;

            dgvInventory.GridColor = Color.LightGray;

            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvInventory.BorderStyle = BorderStyle.None;

            dgvInventory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvInventory.MultiSelect = false;

            dgvInventory.RowHeadersVisible = false;

            // Better column sizing
            dgvInventory.Columns[0].FillWeight = 15;
            dgvInventory.Columns[1].FillWeight = 20;
            dgvInventory.Columns[2].FillWeight = 20;
            dgvInventory.Columns[3].FillWeight = 20;
            dgvInventory.Columns[4].FillWeight = 25;

            // Disable sorting for simplicity
            foreach (DataGridViewColumn col in dgvInventory.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}