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
            lblTitle = new Label();
            lblOwner = new Label();
            lblName = new Label();
            lblContact = new Label();
            lblRole = new Label();
            txtOwnerID = new TextBox();
            txtEmployeeName = new TextBox();
            txtContact = new TextBox();
            txtRole = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(90, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(237, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Employee";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Location = new Point(40, 80);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(71, 20);
            lblOwner.TabIndex = 1;
            lblOwner.Text = "Owner ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(119, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Employee Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(40, 160);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(60, 20);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(40, 200);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role";
            // 
            // txtOwnerID
            // 
            txtOwnerID.Location = new Point(150, 75);
            txtOwnerID.Name = "txtOwnerID";
            txtOwnerID.Size = new Size(180, 27);
            txtOwnerID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(150, 115);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(180, 27);
            txtEmployeeName.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(150, 155);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(180, 27);
            txtContact.TabIndex = 6;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(150, 195);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(180, 27);
            txtRole.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(90, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(210, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 34);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEmployeeForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 350);
            Controls.Add(lblTitle);
            Controls.Add(lblOwner);
            Controls.Add(txtOwnerID);
            Controls.Add(lblName);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblRole);
            Controls.Add(txtRole);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}