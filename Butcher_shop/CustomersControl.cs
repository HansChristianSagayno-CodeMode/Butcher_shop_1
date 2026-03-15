using System;
using System.Drawing; // Required for UI styling
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class CustomersControl : UserControl
    {
        Butcher db = new Butcher();

        public CustomersControl()
        {
            InitializeComponent();
            LoadData();
            StyleGrid(dgvCustomers); // Apply standardized styling
        }

        private void pnlCustomersToolbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void dgvCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadData()
        {
            string query = "SELECT customer_id, customer_name, customer_address, customer_contact, created_at FROM CUSTOMER";

            db.displayRecord(query, dgvCustomers);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();

            form.ShowDialog();

            LoadData();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);

                string query = "DELETE FROM CUSTOMER WHERE customer_id = " + id;

                db.sqlManager(query);

                MessageBox.Show("Customer deleted successfully.");

                LoadData();
            }
        }

        private void btnCustomerRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}