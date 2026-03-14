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

            this.SuspendLayout();

            // FORM SETTINGS
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock Out";

            // TITLE
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Text = "Record Stock Out";

            // PRODUCT ID LABEL
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProduct.Location = new System.Drawing.Point(40, 90);
            this.lblProduct.Text = "Product ID";

            // PRODUCT ID TEXTBOX
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtProductID.Location = new System.Drawing.Point(40, 115);
            this.txtProductID.Size = new System.Drawing.Size(330, 27);

            // QUANTITY LABEL
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQuantity.Location = new System.Drawing.Point(40, 155);
            this.lblQuantity.Text = "Quantity Out";

            // QUANTITY TEXTBOX
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(40, 180);
            this.txtQuantity.Size = new System.Drawing.Size(330, 27);

            // DATE LABEL
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDate.Location = new System.Drawing.Point(40, 220);
            this.lblDate.Text = "Date";

            // DATE PICKER
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDate.Location = new System.Drawing.Point(40, 245);
            this.dtpDate.Size = new System.Drawing.Size(330, 27);

            // REASON LABEL
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblReason.Location = new System.Drawing.Point(40, 285);
            this.lblReason.Text = "Reason";

            // REASON TEXTBOX
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtReason.Location = new System.Drawing.Point(40, 310);
            this.txtReason.Size = new System.Drawing.Size(330, 27);

            // SAVE BUTTON
            this.btnSave.Text = "Save";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(40, 360);
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // CANCEL BUTTON
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(220, 360);
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ADD CONTROLS
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

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}