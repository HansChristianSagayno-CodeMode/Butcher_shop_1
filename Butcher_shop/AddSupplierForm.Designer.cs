namespace Butcher_shop
{
    partial class AddSupplierForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            lblAddress = new Label();
            lblContact = new Label();

            txtName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();

            btnSave = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // Label Name
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 20);
            lblName.Text = "Supplier Name";

            // txtName
            txtName.Location = new Point(30, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);

            // Label Address
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(30, 100);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.Text = "Address";

            // txtAddress
            txtAddress.Location = new Point(30, 125);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 27);

            // Label Contact
            lblContact.AutoSize = true;
            lblContact.Location = new Point(30, 170);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(60, 20);
            lblContact.Text = "Contact";

            // txtContact
            txtContact.Location = new Point(30, 195);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(300, 27);

            // btnSave
            btnSave.Location = new Point(60, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            // btnCancel
            btnCancel.Location = new Point(180, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;

            // AddSupplierForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 320);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddSupplierForm";
            Text = "Add Supplier";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}