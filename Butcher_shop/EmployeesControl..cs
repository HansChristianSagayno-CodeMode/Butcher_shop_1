using ButcherShopSystem;
using System;
using System.Drawing; // Ensure System.Drawing is included for Color and Font
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
            StyleGrid(dgvCustomers); // Apply new styling system
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