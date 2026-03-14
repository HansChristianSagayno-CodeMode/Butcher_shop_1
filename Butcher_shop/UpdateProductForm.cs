using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Butcher_shop
{
    public partial class UpdateProductForm : Form
    {
        int productID;

        string connectionString =
            "server=localhost;user id=root;password=;database=butcher_shop;";

        public UpdateProductForm(
            int id,
            string name,
            string category,
            string unit,
            decimal price,
            int stock,
            bool active)
        {
            InitializeComponent();
            this.MouseDown += DragForm;

            productID = id;

            txtName.Text = name;
            txtCategory.Text = category;
            txtUnit.Text = unit;
            txtPrice.Text = price.ToString();
            txtStock.Text = stock.ToString();
            chkActive.Checked = active;

            ApplyRoundedCorners();
        }

        // DRAG FORM
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        // ROUNDED FORM
        private void ApplyRoundedCorners()
        {
            GraphicsPath path = new GraphicsPath();

            int radius = 20;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();

            this.Region = new Region(path);
        }

        // UPDATE BUTTON
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn =
                new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                @"UPDATE PRODUCT
                  SET product_name=@name,
                      product_cat_type=@cat,
                      product_unit=@unit,
                      product_price=@price,
                      product_stock_level=@stock,
                      is_active=@active
                  WHERE product_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@active", chkActive.Checked);
                cmd.Parameters.AddWithValue("@id", productID);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product Updated!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}