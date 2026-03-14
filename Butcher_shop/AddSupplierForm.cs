using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Butcher_shop
{
    public partial class AddSupplierForm : Form
    {
        Butcher db = new Butcher();

        private Panel headerPanel;
        private Label lblTitle;
        private Button btnClose;



        public AddSupplierForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            CreateHeader();
            ApplyModernStyle();
            this.Height = 460;
        }

        // Rounded corners
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

        // Allow dragging
        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Header bar
        private void CreateHeader()
        {
            headerPanel = new Panel();
            headerPanel.BackColor = Color.SeaGreen;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 45;
            headerPanel.MouseDown += Header_MouseDown;

            lblTitle = new Label();
            lblTitle.Text = "Add Supplier";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitle.Location = new Point(15, 10);
            lblTitle.AutoSize = true;

            btnClose = new Button();
            btnClose.Text = "X";
            btnClose.ForeColor = Color.White;
            btnClose.BackColor = Color.SeaGreen;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Size = new Size(40, 30);
            btnClose.Location = new Point(this.Width - 50, 7);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;

            btnClose.Click += (s, e) => this.Close();

            // hover effect
            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.Firebrick;
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.SeaGreen;

            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(btnClose);

            this.Controls.Add(headerPanel);
            headerPanel.BringToFront();
        }

        // Modern UI
        private void ApplyModernStyle()
        {
            int labelLeft = 40;
            int textboxLeft = 40;
            int textboxWidth = 300;

            int currentTop = 70; // start below header

            // TEXTBOX STYLE
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtContact.BorderStyle = BorderStyle.FixedSingle;

            txtName.Font = new Font("Segoe UI", 11);
            txtAddress.Font = new Font("Segoe UI", 11);
            txtContact.Font = new Font("Segoe UI", 11);

            txtName.Width = textboxWidth;
            txtAddress.Width = textboxWidth;
            txtContact.Width = textboxWidth;

            txtName.Height = 30;
            txtAddress.Height = 30;
            txtContact.Height = 30;

            // NAME
            lblName.Location = new Point(labelLeft, currentTop);
            txtName.Location = new Point(textboxLeft, currentTop + 25);

            currentTop += 75;

            // ADDRESS
            lblAddress.Location = new Point(labelLeft, currentTop);
            txtAddress.Location = new Point(textboxLeft, currentTop + 25);

            currentTop += 75;

            // CONTACT
            lblContact.Location = new Point(labelLeft, currentTop);
            txtContact.Location = new Point(textboxLeft, currentTop + 25);

            currentTop += 60;

            // SAVE BUTTON
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor = Color.SeaGreen;
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnSave.Size = new Size(130, 40);

            // CANCEL BUTTON
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.Font = new Font("Segoe UI", 10);
            btnCancel.Size = new Size(110, 40);

            // CENTER BUTTONS
            int centerX = (this.Width / 2) - 140;

            btnSave.Location = new Point(centerX, currentTop);
            btnCancel.Location = new Point(centerX + 150, currentTop);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter supplier name.");
                return;
            }

            string query = $"INSERT INTO SUPPLIER (supplier_name, supplier_address, supplier_contact) " +
                           $"VALUES ('{name}','{address}','{contact}')";

            db.sqlManager(query);

            MessageBox.Show("Supplier added successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}