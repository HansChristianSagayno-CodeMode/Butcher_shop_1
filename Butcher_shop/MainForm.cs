using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //login
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


        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            InventoryControl inventory = new InventoryControl();
            inventory.Dock = DockStyle.Fill;

            panelContent.Controls.Add(inventory);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            CustomersControl customers = new CustomersControl();
            customers.Dock = DockStyle.Fill;

            panelContent.Controls.Add(customers);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            ReportsControl reports = new ReportsControl();
            reports.Dock = DockStyle.Fill;

            panelContent.Controls.Add(reports);
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

           SuppliersControl supply = new SuppliersControl();
            supply.Dock = DockStyle.Fill;

            panelContent.Controls.Add(supply);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            
            panelContent.Controls.Clear();

           SupplyControl suppliers = new SupplyControl();
            suppliers.Dock = DockStyle.Fill;

            panelContent.Controls.Add(suppliers);
            
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            
           panelContent.Controls.Clear();

           EmployeesControl employees = new EmployeesControl();
           employees.Dock = DockStyle.Fill;

           panelContent.Controls.Add(employees);
            
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            
           panelContent.Controls.Clear();

           StockOutControl stockOut = new StockOutControl();
           stockOut.Dock = DockStyle.Fill;

           panelContent.Controls.Add(stockOut);
               

        }
    }


}
