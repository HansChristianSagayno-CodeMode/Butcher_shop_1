using System;
using System.Drawing; // Ensure System.Drawing is included for Color and Font
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class SuppliersControl : UserControl
    {
        Butcher db = new Butcher();

        public SuppliersControl()
        {
            InitializeComponent();
            LoadSuppliers();
            StyleGrid(dgvSuppliers);
        }

        private void LoadSuppliers()
        {
            string query = @"SELECT 
                            supplier_id,
                            supplier_name,
                            supplier_address,
                            supplier_contact
                            FROM SUPPLIER";

            db.displayRecord(query, dgvSuppliers);

            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierForm frm = new AddSupplierForm();
            frm.ShowDialog();

            LoadSuppliers();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            int id = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells[0].Value);

            DialogResult confirm = MessageBox.Show(
                "Delete this supplier?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                string query = $"DELETE FROM SUPPLIER WHERE supplier_id = {id}";
                db.sqlManager(query);

                LoadSuppliers();
            }
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 45;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);
            dgv.DefaultCellStyle.Font = new Font("Roboto", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 124, 0);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            dgv.GridColor = Color.FromArgb(235, 235, 235);
            dgv.RowTemplate.Height = 45;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
        }
    }
}