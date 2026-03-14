using ButcherShopSystem;
using System;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class EmployeesControl : UserControl
    {
        Butcher db = new Butcher();

        public EmployeesControl()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            string query = "SELECT employee_id, owner_id, employee_name, employee_contact, employee_role FROM EMPLOYEE";
            db.displayRecord(query, dgvCustomers);
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.ShowDialog();

            LoadData();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);

            string query = "DELETE FROM EMPLOYEE WHERE employee_id = " + id;

            db.sqlManager(query);

            LoadData();
        }

        private void btnCustomerRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}