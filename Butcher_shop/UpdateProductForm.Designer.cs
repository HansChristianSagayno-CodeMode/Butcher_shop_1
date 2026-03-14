namespace Butcher_shop
{
    partial class UpdateProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new Panel();
            this.btnUpdate = new Button();
            this.btnCancel = new Button();
            this.txtName = new TextBox();
            this.txtCategory = new TextBox();
            this.txtUnit = new TextBox();
            this.txtPrice = new TextBox();
            this.txtStock = new TextBox();
            this.chkActive = new CheckBox();

            this.lblTitle = new Label();

            SuspendLayout();

            // FORM
            this.BackColor = Color.White;
            this.ClientSize = new Size(420, 420);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;

            // TITLE
            lblTitle.Text = "Update Product";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.AutoSize = true;

            // TEXTBOXES
            txtName.PlaceholderText = "Product Name";
            txtName.Location = new Point(40, 90);
            txtName.Size = new Size(330, 30);

            txtCategory.PlaceholderText = "Category";
            txtCategory.Location = new Point(40, 140);
            txtCategory.Size = new Size(330, 30);

            txtUnit.PlaceholderText = "Unit (kg, pcs)";
            txtUnit.Location = new Point(40, 190);
            txtUnit.Size = new Size(330, 30);

            txtPrice.PlaceholderText = "Price";
            txtPrice.Location = new Point(40, 240);
            txtPrice.Size = new Size(330, 30);

            txtStock.PlaceholderText = "Stock Level";
            txtStock.Location = new Point(40, 290);
            txtStock.Size = new Size(330, 30);

            // CHECKBOX
            chkActive.Text = "Product Active";
            chkActive.Location = new Point(40, 330);

            // BUTTON UPDATE
            btnUpdate.Text = "Update";
            btnUpdate.BackColor = Color.FromArgb(30, 144, 255);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.Location = new Point(70, 360);
            btnUpdate.Click += btnUpdate_Click;

            // BUTTON CANCEL
            btnCancel.Text = "Cancel";
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Size = new Size(120, 40);
            btnCancel.Location = new Point(220, 360);
            btnCancel.Click += btnCancel_Click;

            // ADD CONTROLS
            Controls.Add(lblTitle);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Controls.Add(txtUnit);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(chkActive);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);

            ResumeLayout(false);
        }

        private Panel pnlMain;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtUnit;
        private TextBox txtPrice;
        private TextBox txtStock;
        private CheckBox chkActive;

        private Button btnUpdate;
        private Button btnCancel;

        private Label lblTitle;
    }
}