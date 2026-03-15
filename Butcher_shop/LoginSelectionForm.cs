using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class LoginSelectionForm : Form
    {
        public LoginSelectionForm()
        {
            InitializeComponent();
        }

        private void btnOwnerLogin_Click(object sender, EventArgs e)
        {
            OwnerLoginForm ownerLogin = new OwnerLoginForm();
            ownerLogin.Show();
            this.Hide();
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            EmployeeLoginForm employeeLogin = new EmployeeLoginForm();
            employeeLogin.Show();
            this.Hide();
        }

        // Purely visual event to make buttons pill-shaped (rounded)
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
    }
}