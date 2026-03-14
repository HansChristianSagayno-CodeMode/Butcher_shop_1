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
            this.Height = 420;
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
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtContact.BorderStyle = BorderStyle.FixedSingle;

            txtName.Font = new Font("Segoe UI", 11);
            txtAddress.Font = new Font("Segoe UI", 11);
            txtContact.Font = new Font("Segoe UI", 11);

            txtName.Height = 30;
            txtAddress.Height = 30;
            txtContact.Height = 30;

            // SAVE BUTTON
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor = Color.SeaGreen;
            btnSave.ForeColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnSave.Height = 40;
            btnSave.Width = 140;

            // CANCEL BUTTON
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.BackColor = Color.LightGray;
            btnCancel.Font = new Font("Segoe UI", 10);
            btnCancel.Height = 40;
            btnCancel.Width = 120;

            // SPACING BETWEEN BUTTONS
            btnSave.Location = new Point(70, 240);
            btnCancel.Location = new Point(btnSave.Right + 20, 240);

            // ensure cancel works
            btnCancel.Click += btnCancel_Click;
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
            this.Close();
        }
    }
}