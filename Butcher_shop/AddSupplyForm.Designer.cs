namespace Butcher_shop
{
    partial class AddSupplyForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;

        private ComboBox cmbSupplier;
        private ComboBox cmbProduct;

        private TextBox txtCost;
        private TextBox txtQuantity;

        private Button btnSave;
        private Button btnCancel;

        private Label lblSupplier;
        private Label lblProduct;
        private Label lblCost;
        private Label lblQty;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();

            cmbSupplier = new ComboBox();
            cmbProduct = new ComboBox();

            txtCost = new TextBox();
            txtQuantity = new TextBox();

            btnSave = new Button();
            btnCancel = new Button();

            lblSupplier = new Label();
            lblProduct = new Label();
            lblCost = new Label();
            lblQty = new Label();

            SuspendLayout();

            // Header Panel
            pnlHeader.BackColor = Color.FromArgb(45, 45, 48);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 50;
            pnlHeader.MouseDown += pnlHeader_MouseDown;

            // Title
            lblTitle.Text = "Record Supply";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 15);

            pnlHeader.Controls.Add(lblTitle);

            // Supplier
            lblSupplier.Text = "Supplier";
            lblSupplier.Font = new Font("Segoe UI", 10F);
            lblSupplier.Location = new Point(30, 70);

            cmbSupplier.Location = new Point(30, 95);
            cmbSupplier.Width = 260;
            cmbSupplier.Font = new Font("Segoe UI", 10F);

            // Product
            lblProduct.Text = "Product";
            lblProduct.Font = new Font("Segoe UI", 10F);
            lblProduct.Location = new Point(30, 135);

            cmbProduct.Location = new Point(30, 160);
            cmbProduct.Width = 260;
            cmbProduct.Font = new Font("Segoe UI", 10F);

            // Unit Cost
            lblCost.Text = "Unit Cost";
            lblCost.Font = new Font("Segoe UI", 10F);
            lblCost.Location = new Point(30, 200);

            txtCost.Location = new Point(30, 225);
            txtCost.Width = 260;
            txtCost.Font = new Font("Segoe UI", 10F);

            // Quantity
            lblQty.Text = "Quantity";
            lblQty.Font = new Font("Segoe UI", 10F);
            lblQty.Location = new Point(30, 265);

            txtQuantity.Location = new Point(30, 290);
            txtQuantity.Width = 260;
            txtQuantity.Font = new Font("Segoe UI", 10F);

            // Save Button
            btnSave.Text = "Save";
            btnSave.BackColor = Color.ForestGreen;
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(30, 340);
            btnSave.Width = 120;
            btnSave.Height = 40;
            btnSave.Click += btnSave_Click;

            // Cancel Button
            btnCancel.Text = "Cancel";
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(170, 340);
            btnCancel.Width = 120;
            btnCancel.Height = 40;
            btnCancel.Click += btnCancel_Click;

            // Form
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(330, 420);
            Controls.Add(pnlHeader);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblProduct);
            Controls.Add(cmbProduct);
            Controls.Add(lblCost);
            Controls.Add(txtCost);
            Controls.Add(lblQty);
            Controls.Add(txtQuantity);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);

            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
        }
    }
}