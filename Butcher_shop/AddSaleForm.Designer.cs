using System.Drawing.Drawing2D;

namespace Butcher_shop
{
    partial class AddSaleForm
    {
        private ComboBox cbCustomer;
        private ComboBox cbEmployee;
        private ComboBox cbProduct;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnCancel;
        private Panel header;

        private void InitializeComponent()
        {
            header = new Panel();
            cbCustomer = new ComboBox();
            cbEmployee = new ComboBox();
            cbProduct = new ComboBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();

            SuspendLayout();

            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.White;
            Size = new Size(420, 420);

            header.Dock = DockStyle.Top;
            header.Height = 60;
            header.BackColor = Color.FromArgb(45, 45, 48);

            Controls.Add(header);

            cbCustomer.Location = new Point(40, 80);
            cbCustomer.Width = 320;

            cbEmployee.Location = new Point(40, 130);
            cbEmployee.Width = 320;

            cbProduct.Location = new Point(40, 180);
            cbProduct.Width = 320;

            txtPrice.Location = new Point(40, 230);
            txtPrice.Width = 320;
            txtPrice.PlaceholderText = "Unit Price";

            txtQuantity.Location = new Point(40, 280);
            txtQuantity.Width = 320;
            txtQuantity.PlaceholderText = "Quantity";

            btnSave.Text = "Save";
            btnSave.BackColor = Color.ForestGreen;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(40, 330);
            btnSave.Click += btnSave_Click;

            btnCancel.Text = "Cancel";
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(220, 330);
            btnCancel.Click += (s, e) => Close();

            Controls.Add(cbCustomer);
            Controls.Add(cbEmployee);
            Controls.Add(cbProduct);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);

            ResumeLayout(false);
        }
    }
}