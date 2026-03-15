namespace Butcher_shop
{
    partial class AddSupplyForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbProduct;

        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtQuantity;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblQty;

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

            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();

            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Note: Exact positions, sizing, and fonts are managed dynamically in ApplyStylesAndLayout()
            // Instantiation is kept here to prevent null references and preserve original event wires.
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Record Supply";
            this.lblTitle.AutoSize = true;

            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.txtCost.Name = "txtCost";
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

            // AddSupplyForm Configuration
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Size scaled to neatly fit the 4 inputs plus title and buttons
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(420, 350);

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);

            this.Name = "AddSupplyForm";
            this.Text = "Add Supply";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}