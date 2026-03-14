using System;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class AddStockOutForm : Form
    {
        public AddStockOutForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text;
            string quantity = txtQuantity.Text;
            string reason = txtReason.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            if (productID == "" || quantity == "")
            {
                MessageBox.Show("Please fill required fields.");
                return;
            }

            string query = "INSERT INTO STOCK_OUT (product_id, quantity_out, date, reason) " +
                           "VALUES ('" + productID + "','" + quantity + "','" + date + "','" + reason + "')";

            Butcher db = new Butcher();
            db.sqlManager(query);

            MessageBox.Show("Stock Out recorded successfully!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}