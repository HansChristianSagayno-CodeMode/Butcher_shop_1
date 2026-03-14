using Butcher_shop;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ButcherShopSystem
{
    public partial class AddEmployeeForm : Form
    {
        Butcher db = new Butcher();

        public AddEmployeeForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            RoundFormCorners(20);

            RoundControl(txtOwnerID, 10);
            RoundControl(txtEmployeeName, 10);
            RoundControl(txtContact, 10);
            RoundControl(txtRole, 10);

            RoundControl(btnSave, 12);
            RoundControl(btnCancel, 12);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string owner = txtOwnerID.Text;
            string name = txtEmployeeName.Text;
            string contact = txtContact.Text;
            string role = txtRole.Text;

            if (name == "")
            {
                MessageBox.Show("Employee name is required.");
                return;
            }

            string query = "INSERT INTO EMPLOYEE (owner_id, employee_name, employee_contact, employee_role) " +
                           "VALUES ('" + owner + "', '" + name + "', '" + contact + "', '" + role + "')";

            db.sqlManager(query);

            MessageBox.Show("Employee added successfully!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RoundFormCorners(20);
        }
    }
}