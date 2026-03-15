namespace ButcherShopSystem
{
    partial class AddEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblRole;

        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtRole;

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
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();

            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Note: Exact positions, sizing, and fonts are managed dynamically in ApplyStylesAndLayout()
            // Instantiation is kept here to prevent null references and preserve original event wires.
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Add New Employee";
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

            // AddEmployeeForm Configuration
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Increased height from 320 to 380 to cleanly fit 4 input rows plus the title
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(420, 350);

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);

            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}