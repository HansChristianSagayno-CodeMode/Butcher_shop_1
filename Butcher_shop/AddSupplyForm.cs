using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
namespace Butcher_shop
{
    public partial class AddSupplyForm : Form
    {
        string connectionString = "server=localhost;database=butcher_shop_db;uid=root;pwd=;";

        public AddSupplyForm()
        {
            InitializeComponent();

            // Rounded corners
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            LoadSuppliers();
            LoadProducts();
        }
        


        private void LoadSuppliers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT supplier_id, supplier_name FROM supplier";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbSupplier.Items.Add(new ComboItem(
                        reader["supplier_name"].ToString(),
                        reader["supplier_id"].ToString()
                    ));
                }
            }
        }




        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void LoadProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT product_id, product_name FROM product WHERE is_active = 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbProduct.Items.Add(new ComboItem(
                        reader["product_name"].ToString(),
                        reader["product_id"].ToString()
                    ));
                }
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSupplier.SelectedItem == null || cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select supplier and product.");
                return;
            }

            if (txtCost.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter cost and quantity.");
                return;
            }

            ComboItem supplier = (ComboItem)cmbSupplier.SelectedItem;
            ComboItem product = (ComboItem)cmbProduct.SelectedItem;

            decimal cost = Convert.ToDecimal(txtCost.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // insert into SUPPLY
                    string supplyQuery = @"INSERT INTO supply (supplier_id)
                                           VALUES (@supplier)";

                    MySqlCommand cmd1 = new MySqlCommand(supplyQuery, conn, transaction);
                    cmd1.Parameters.AddWithValue("@supplier", supplier.Value);
                    cmd1.ExecuteNonQuery();

                    int supplyID = (int)cmd1.LastInsertedId;

                    // insert into SUPPLY_DETAILS
                    string detailQuery = @"INSERT INTO supply_details
                                           (supply_id, product_id, unit_cost, supply_quantity)
                                           VALUES (@supply,@product,@cost,@qty)";

                    MySqlCommand cmd2 = new MySqlCommand(detailQuery, conn, transaction);

                    cmd2.Parameters.AddWithValue("@supply", supplyID);
                    cmd2.Parameters.AddWithValue("@product", product.Value);
                    cmd2.Parameters.AddWithValue("@cost", cost);
                    cmd2.Parameters.AddWithValue("@qty", quantity);

                    cmd2.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Supply recorded successfully.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving supply: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ComboItem
    {
        public string Text;
        public string Value;

        public ComboItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}