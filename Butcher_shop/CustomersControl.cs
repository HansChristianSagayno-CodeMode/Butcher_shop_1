using System;
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
    }
}