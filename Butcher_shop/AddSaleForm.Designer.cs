namespace Butcher_shop
{
    partial class AddSaleForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();

            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Note: Exact positions, sizing, and fonts are managed dynamically in ApplyStylesAndLayout()
            // Instantiation is kept here to prevent null references and preserve original event wires.
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Process New Sale";
            this.lblTitle.AutoSize = true;

            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbProduct.Name = "cbProduct";
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.txtPrice.Name = "txtPrice";
            this.txtQuantity.Name = "txtQuantity";

            // btnSave
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddSaleForm Configuration
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Height to fit 5 inputs cleanly
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(420, 380);

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);

            this.Name = "AddSaleForm";
            this.Text = "Add Sale";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}