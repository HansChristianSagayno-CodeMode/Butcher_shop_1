using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class EmployeeLoginForm : Form
    {
        string connString = "server=localhost;user=root;password=;database=butcher_shop_db;";

        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        // =========================================================
        // ORIGINAL LOGIC - UNTOUCHED
        // =========================================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT * FROM EMPLOYEE
                                 WHERE username=@username
                                 AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Employee Login Successful");

                    EmployeeMainForm emp = new EmployeeMainForm();
                    emp.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        // =========================================================
        // UI DESIGN LOGIC - FOR ROUNDED CORNERS
        // =========================================================

        // Makes the Login button pill-shaped
        private void PillButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            GraphicsPath grPath = new GraphicsPath();
            int radius = btn.Height; // Full height radius for pill shape
            grPath.AddArc(0, 0, radius, radius, 180, 90);
            grPath.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            grPath.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            grPath.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            btn.Region = new Region(grPath);
        }

        // Rounds the corners of the white login card natively
        private void RoundedCard_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            GraphicsPath grPath = new GraphicsPath();
            int radius = 20; // Soft rounded corners for the card
            grPath.AddArc(0, 0, radius, radius, 180, 90);
            grPath.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            grPath.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            grPath.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            pnl.Region = new Region(grPath);
        }
    }
}