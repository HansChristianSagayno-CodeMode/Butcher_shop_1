using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Butcher_shop
{
    public class OwnerLoginForm : Form
    {
        private Color primaryGreen = Color.FromArgb(46, 125, 50);
        private Color lightBackground = Color.FromArgb(241, 248, 233);

        public OwnerLoginForm()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Owner Login";
            this.Size = new Size(500, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = lightBackground;

            Label lblTitle = new Label()
            {
                Text = "Juan's Pork Meat Shop",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = primaryGreen,
                AutoSize = true,
                Location = new Point(95, 30)
            };

            Label lblHeader = new Label()
            {
                Text = "OWNER LOGIN",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(170, 80)
            };

            TextBox txtUser = CreateModernTextbox();
            txtUser.Location = new Point(140, 130);

            TextBox txtPass = CreateModernTextbox();
            txtPass.Location = new Point(140, 180);
            txtPass.UseSystemPasswordChar = true;

            CheckBox chkShow = new CheckBox()
            {
                Text = "Show Password",
                Location = new Point(140, 215),
                AutoSize = true
            };

            chkShow.CheckedChanged += (s, e) =>
            {
                txtPass.UseSystemPasswordChar = !chkShow.Checked;
            };

            Button btnLogin = CreateModernButton("Login", primaryGreen);
            btnLogin.Location = new Point(140, 250);

            Button btnBack = CreateModernButton("Back", Color.Gray);
            btnBack.Location = new Point(140, 305);

            btnLogin.Click += (s, e) =>
            {
                MessageBox.Show("Owner authentication will connect to database later.");
            };

            btnBack.Click += (s, e) =>
            {
                this.Close();
            };

            this.AcceptButton = btnLogin; // Press Enter to login

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblHeader);
            this.Controls.Add(txtUser);
            this.Controls.Add(txtPass);
            this.Controls.Add(chkShow);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnBack);
        }

        private TextBox CreateModernTextbox()
        {
            TextBox txt = new TextBox();
            txt.Size = new Size(220, 35);
            txt.Font = new Font("Segoe UI", 11);
            return txt;
        }

        private Button CreateModernButton(string text, Color baseColor)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(220, 45);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.BackColor = baseColor;
            btn.Cursor = Cursors.Hand;

            btn.Paint += (s, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, 20, 20, 180, 90);
                path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90);
                path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90);
                path.AddArc(0, btn.Height - 20, 20, 20, 90, 90);
                path.CloseAllFigures();
                btn.Region = new Region(path);
            };

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = ControlPaint.Light(baseColor);
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = baseColor;
            };

            return btn;
        }
    }
}