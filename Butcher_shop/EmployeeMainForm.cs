using System;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            SalesControl sales = new SalesControl();
            sales.Dock = DockStyle.Fill;

            panelContent.Controls.Add(sales);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            DashboardControl dashboard = new DashboardControl();
            dashboard.Dock = DockStyle.Fill;

            panelContent.Controls.Add(dashboard);
        }

        private void LoadControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            ProductsControl products = new ProductsControl();
            products.Dock = DockStyle.Fill;

            panelContent.Controls.Add(products);


        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            CustomersControl customers = new CustomersControl();
            customers.Dock = DockStyle.Fill;

            panelContent.Controls.Add(customers);
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginSelectionForm login = new LoginSelectionForm();
                login.Show();

                this.Close();
            }
        }
    }
}