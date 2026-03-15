namespace Butcher_shop
{
    partial class AddStockOutForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblReason;

        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtReason;

        private System.Windows.Forms.DateTimePicker dtpDate;

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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();

            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();

            this.dtpDate = new System.Windows.Forms.DateTimePicker();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Note: Exact positions, sizing, and fonts are managed dynamically in ApplyStylesAndLayout()
            // Instantiation is kept here to prevent null references and preserve original event wires.
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Record Stock Out";
            this.lblTitle.AutoSize = true;

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

            // AddStockOutForm Configuration
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Size configured to comfortably fit 4 input fields + title + buttons
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(420, 350);

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);

            this.Name = "AddStockOutForm";
            this.Text = "Add Stock Out";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}