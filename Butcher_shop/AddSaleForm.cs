using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class AddSaleForm : Form
    {
        string connectionString = "server=localhost;database=butcher_shop_db;uid=root;pwd=;";

        public AddSaleForm()
        {
            InitializeComponent();

            LoadCustomers();
            LoadEmployees();
            LoadProducts();

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(Width - 20, Height - 20, 20, 20, 0, 90);
            path.AddArc(0, Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }

        private void LoadCustomers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT customer_id, customer_name FROM customer";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cbCustomer.DisplayMember = "customer_name";
                cbCustomer.ValueMember = "customer_id";
                cbCustomer.DataSource = table;
            }
        }

        private void LoadEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT employee_id, employee_name FROM employee";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cbEmployee.DisplayMember = "employee_name";
                cbEmployee.ValueMember = "employee_id";
                cbEmployee.DataSource = table;
            }
        }

        private void LoadProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT product_id, product_name, product_price FROM product WHERE is_active = 1";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cbProduct.DisplayMember = "product_name";
                cbProduct.ValueMember = "product_id";
                cbProduct.DataSource = table;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int customer = Convert.ToInt32(cbCustomer.SelectedValue);
            int employee = Convert.ToInt32(cbEmployee.SelectedValue);
            int product = Convert.ToInt32(cbProduct.SelectedValue);

            int quantity = Convert.ToInt32(txtQuantity.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);

            decimal total = quantity * price;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string insertSale = @"INSERT INTO transaction
                                        (customer_id, employee_id, total_amount)
                                        VALUES
                                        (@customer,@employee,@total)";

                    MySqlCommand cmd = new MySqlCommand(insertSale, conn, transaction);

                    cmd.Parameters.AddWithValue("@customer", customer);
                    cmd.Parameters.AddWithValue("@employee", employee);
                    cmd.Parameters.AddWithValue("@total", total);

                    cmd.ExecuteNonQuery();

                    int transactionID = (int)cmd.LastInsertedId;

                    string insertDetails = @"INSERT INTO transaction_details
                                            (transaction_id,product_id,quantity_sold,unit_price_at_sale)
                                            VALUES
                                            (@trans,@product,@qty,@price)";

                    MySqlCommand cmd2 = new MySqlCommand(insertDetails, conn, transaction);

                    cmd2.Parameters.AddWithValue("@trans", transactionID);
                    cmd2.Parameters.AddWithValue("@product", product);
                    cmd2.Parameters.AddWithValue("@qty", quantity);
                    cmd2.Parameters.AddWithValue("@price", price);

                    cmd2.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Sale recorded successfully");

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving sale.");
                }
            }
        }
    }
}