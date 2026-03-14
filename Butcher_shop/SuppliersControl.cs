using System;
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
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);

            dgv.RowTemplate.Height = 40;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
        }
    }
}