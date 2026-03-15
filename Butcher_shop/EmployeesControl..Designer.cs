namespace Butcher_shop
{
    partial class EmployeesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            custColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            custColCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlCustomersToolbar = new System.Windows.Forms.Panel();
            btnCustomerRefresh = new System.Windows.Forms.Button();
            btnCustomerDelete = new System.Windows.Forms.Button();
            btnCustomerAdd = new System.Windows.Forms.Button();
            lblCustomersTitle = new System.Windows.Forms.Label();
            pnlCustomersList = new System.Windows.Forms.Panel();
            dgvCustomers = new System.Windows.Forms.DataGridView();
            custColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            custColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            custColContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlCustomersToolbar.SuspendLayout();
            pnlCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // custColAddress
            // 
            custColAddress.DataPropertyName = "employee_name";
            custColAddress.HeaderText = "Employee Name";
            custColAddress.MinimumWidth = 6;
            custColAddress.Name = "custColAddress";
            custColAddress.ReadOnly = true;
            // 
            // custColCreated
            // 
            custColCreated.DataPropertyName = "employee_role";
            custColCreated.HeaderText = "Role";
            custColCreated.MinimumWidth = 6;
            custColCreated.Name = "custColCreated";
            custColCreated.ReadOnly = true;
            // 
            // pnlCustomersToolbar
            // 
            pnlCustomersToolbar.BackColor = System.Drawing.Color.White;
            pnlCustomersToolbar.Controls.Add(btnCustomerRefresh);
            pnlCustomersToolbar.Controls.Add(btnCustomerDelete);
            pnlCustomersToolbar.Controls.Add(btnCustomerAdd);
            pnlCustomersToolbar.Controls.Add(lblCustomersTitle);
            pnlCustomersToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlCustomersToolbar.Location = new System.Drawing.Point(0, 0);
            pnlCustomersToolbar.Name = "pnlCustomersToolbar";
            pnlCustomersToolbar.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            pnlCustomersToolbar.Size = new System.Drawing.Size(1200, 70);
            pnlCustomersToolbar.TabIndex = 1;
            // 
            // btnCustomerRefresh
            // 
            btnCustomerRefresh.BackColor = System.Drawing.Color.SteelBlue;
            btnCustomerRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomerRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCustomerRefresh.ForeColor = System.Drawing.Color.White;
            btnCustomerRefresh.Location = new System.Drawing.Point(901, 22);
            btnCustomerRefresh.Name = "btnCustomerRefresh";
            btnCustomerRefresh.Size = new System.Drawing.Size(202, 35);
            btnCustomerRefresh.TabIndex = 4;
            btnCustomerRefresh.Text = "Refresh";
            btnCustomerRefresh.UseVisualStyleBackColor = false;
            btnCustomerRefresh.Click += btnCustomerRefresh_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.BackColor = System.Drawing.Color.Firebrick;
            btnCustomerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomerDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCustomerDelete.ForeColor = System.Drawing.Color.White;
            btnCustomerDelete.Location = new System.Drawing.Point(703, 22);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new System.Drawing.Size(159, 35);
            btnCustomerDelete.TabIndex = 3;
            btnCustomerDelete.Text = "Delete Employee";
            btnCustomerDelete.UseVisualStyleBackColor = false;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.BackColor = System.Drawing.Color.ForestGreen;
            btnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomerAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCustomerAdd.ForeColor = System.Drawing.Color.White;
            btnCustomerAdd.Location = new System.Drawing.Point(507, 22);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new System.Drawing.Size(170, 35);
            btnCustomerAdd.TabIndex = 2;
            btnCustomerAdd.Text = "+ Add Employee";
            btnCustomerAdd.UseVisualStyleBackColor = false;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblCustomersTitle.ForeColor = System.Drawing.Color.Black;
            lblCustomersTitle.Location = new System.Drawing.Point(20, 15);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new System.Drawing.Size(136, 32);
            lblCustomersTitle.TabIndex = 0;
            lblCustomersTitle.Text = "Employees";
            // 
            // pnlCustomersList
            // 
            pnlCustomersList.Controls.Add(dgvCustomers);
            pnlCustomersList.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCustomersList.Location = new System.Drawing.Point(0, 70);
            pnlCustomersList.Name = "pnlCustomersList";
            pnlCustomersList.Padding = new System.Windows.Forms.Padding(20);
            pnlCustomersList.Size = new System.Drawing.Size(1200, 630);
            pnlCustomersList.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;

            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.AutoGenerateColumns = false;

            // Maintained from original setup
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeRows = false;

            // Styling for readability
            dgvCustomers.EnableHeadersVisualStyles = false;

            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvCustomers.ColumnHeadersHeight = 45;

            dgvCustomers.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvCustomers.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvCustomers.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvCustomers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvCustomers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvCustomers.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            dgvCustomers.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvCustomers.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            // IMPORTANT: add the columns
            dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
            custColID,
            custColName,
            custColAddress,
            custColContact,
            custColCreated
            });

            // Center important columns (Maintained)
            custColID.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            custColName.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // custColID
            // 
            custColID.DataPropertyName = "employee_id";
            custColID.HeaderText = "Employee ID";
            custColID.MinimumWidth = 6;
            custColID.Name = "custColID";
            custColID.ReadOnly = true;
            // 
            // custColName
            // 
            custColName.DataPropertyName = "owner_id";
            custColName.HeaderText = "Owner ID";
            custColName.MinimumWidth = 6;
            custColName.Name = "custColName";
            custColName.ReadOnly = true;
            // 
            // custColContact
            // 
            custColContact.DataPropertyName = "employee_contact";
            custColContact.HeaderText = "Contact";
            custColContact.MinimumWidth = 6;
            custColContact.Name = "custColContact";
            custColContact.ReadOnly = true;
            // 
            // EmployeesControl
            // 
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(pnlCustomersList);
            Controls.Add(pnlCustomersToolbar);
            Name = "EmployeesControl";
            Size = new System.Drawing.Size(1200, 700);
            pnlCustomersToolbar.ResumeLayout(false);
            pnlCustomersToolbar.PerformLayout();
            pnlCustomersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomersToolbar;
        private System.Windows.Forms.Label lblCustomersTitle;
        private System.Windows.Forms.Panel pnlCustomersList;
        private System.Windows.Forms.DataGridView dgvCustomers;

        private System.Windows.Forms.DataGridViewTextBoxColumn custColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn custColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custColContact;
        private System.Windows.Forms.Button btnCustomerRefresh;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn custColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn custColCreated;
    }
}