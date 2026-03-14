using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Butcher_shop
{
    public class RoleSelectionForm : Form
    {
        private Color primaryGreen = Color.FromArgb(46, 125, 50);
        private Color accentOrange = Color.FromArgb(245, 124, 0);
        private Color lightBackground = Color.FromArgb(241, 248, 233);

        public RoleSelectionForm()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Butcher Shop Login";
            this.Size = new Size(500, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = lightBackground;

            // Title
            Label lblTitle = new Label()
            {
                Text = "Juan's Pork Meat Shop",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = primaryGreen,
                AutoSize = true,
                Location = new Point(95, 50)
            };

            // Subtitle
            Label lblSubtitle = new Label()
            {
                Text = "Select your login role",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(170, 95)
            };

            // Owner Button
            Button btnOwner = CreateModernButton("Login as Owner", primaryGreen);
            btnOwner.Location = new Point(140, 140);

            // Employee Button
            Button btnEmployee = CreateModernButton("Login as Employee", accentOrange);
            btnEmployee.Location = new Point(140, 200);

            btnOwner.Click += (s, e) =>
            {
                new OwnerLoginForm().Show();
                this.Hide();
            };

            btnEmployee.Click += (s, e) =>
            {
                //new EmployeeLoginForm().Show();
                this.Hide();
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(lblSubtitle);
            this.Controls.Add(btnOwner);
            this.Controls.Add(btnEmployee);
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

            // Hover effect
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