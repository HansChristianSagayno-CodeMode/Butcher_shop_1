using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Butcher_shop
{
    public partial class AddProductForm : Form
    {
        string connString = "server=localhost;user id=root;password=;database=butcher_shop;";

        public AddProductForm()
        {
            InitializeComponent();

            ApplyRoundedCorners();

            this.MouseDown += DragForm;
        }

        // ADD PRODUCT
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO PRODUCT
                (product_name, product_cat_type, product_unit,
                 product_price, product_stock_level, is_active)
                 VALUES
                (@name,@cat,@unit,@price,@stock,@active)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                cmd.Parameters.AddWithValue("@active", chkActive.Checked);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product Added!");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ROUNDED CORNERS
        private void ApplyRoundedCorners()
        {
            int radius = 20;

            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();

            Region = new Region(path);
        }

        // DRAG FORM
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void DragForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        // RESIZE FORM
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                if ((int)m.Result == 1)
                {
                    Point p = PointToClient(Cursor.Position);

                    if (p.X >= Width - 10 && p.Y >= Height - 10)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;

                    return;
                }
            }

            base.WndProc(ref m);
        }
    }
}