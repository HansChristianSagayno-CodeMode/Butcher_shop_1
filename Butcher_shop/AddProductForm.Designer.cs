namespace Butcher_shop
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtUnit = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            chkActive = new CheckBox();

            btnAdd = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // FORM
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(420, 420);

            // TITLE
            lblTitle.Text = "Add Product";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.AutoSize = true;

            // NAME
            txtName.PlaceholderText = "Product Name";
            txtName.Location = new Point(40, 80);
            txtName.Size = new Size(330, 30);

            // CATEGORY
            txtCategory.PlaceholderText = "Category (Pork / Beef / Chicken)";
            txtCategory.Location = new Point(40, 130);
            txtCategory.Size = new Size(330, 30);

            // UNIT
            txtUnit.PlaceholderText = "Unit (kg / pcs)";
            txtUnit.Location = new Point(40, 180);
            txtUnit.Size = new Size(330, 30);

            // PRICE
            txtPrice.PlaceholderText = "Price";
            txtPrice.Location = new Point(40, 230);
            txtPrice.Size = new Size(330, 30);

            // STOCK
            txtStock.PlaceholderText = "Stock Level";
            txtStock.Location = new Point(40, 280);
            txtStock.Size = new Size(330, 30);

            // ACTIVE
            chkActive.Text = "Product Active";
            chkActive.Location = new Point(40, 320);
            chkActive.Checked = true;

            // ADD BUTTON
            btnAdd.Text = "Add Product";
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Size = new Size(140, 40);
            btnAdd.Location = new Point(50, 360);
            btnAdd.Click += btnAdd_Click;

            // CANCEL BUTTON
            btnCancel.Text = "Cancel";
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Size = new Size(140, 40);
            btnCancel.Location = new Point(210, 360);
            btnCancel.Click += btnCancel_Click;

            Controls.Add(lblTitle);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Controls.Add(txtUnit);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(chkActive);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);

            ResumeLayout(false);
        }

        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtUnit;
        private TextBox txtPrice;
        private TextBox txtStock;
        private CheckBox chkActive;

        private Button btnAdd;
        private Button btnCancel;
    }
}