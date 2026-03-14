using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Butcher_shop
{
    public partial class AddCustomerForm : Form
    {
        Butcher db = new Butcher();

        public AddCustomerForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;

            RoundFormCorners(20);

            // Use your existing textbox names
            RoundControl(txtName, 10);
            RoundControl(txtAddress, 10);
            RoundControl(txtContact, 10);

            RoundControl(btnSave, 12);
            RoundControl(btnCancel, 12);

            StyleControls();
        }

        private void StyleControls()
        {
            txtName.Font = new Font("Segoe UI", 11);
            txtAddress.Font = new Font("Segoe UI", 11);
            txtContact.Font = new Font("Segoe UI", 11);

            btnSave.BackColor = Color.ForestGreen;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;

            btnCancel.BackColor = Color.Firebrick;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
        }

        private void RoundFormCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();

            control.Region = new Region(path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RoundFormCorners(20);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;

            if (name == "")
            {
                MessageBox.Show("Customer name is required.");
                return;
            }

            string query = "INSERT INTO CUSTOMER (customer_name, customer_address, customer_contact) " +
                           "VALUES ('" + name + "', '" + address + "', '" + contact + "')";

            db.sqlManager(query);

            MessageBox.Show("Customer added successfully!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}