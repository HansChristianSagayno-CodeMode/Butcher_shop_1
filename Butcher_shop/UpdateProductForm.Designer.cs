namespace Butcher_shop
{
    partial class UpdateProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        // Added labels to match reference styling structure
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.CheckBox chkActive;

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();

            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Note: Exact positions, sizing, and fonts are managed dynamically in ApplyStylesAndLayout()
            // Instantiation is kept here to prevent null references and preserve original event wires.

            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Update Product";
            this.lblTitle.AutoSize = true;

            this.chkActive.Name = "chkActive";
            this.chkActive.Text = "Product Active";

            // btnUpdate
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnCancel
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // UpdateProductForm Configuration
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Increased height to cleanly fit 5 inputs + checkbox + title + buttons
            this.ClientSize = new System.Drawing.Size(450, 460);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(420, 420);

            // Add Controls
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);

            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);

            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtUnit);

            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);

            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);

            this.Name = "UpdateProductForm";
            this.Text = "Update Product";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}