

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
            custColAddress = new DataGridViewTextBoxColumn();
            custColCreated = new DataGridViewTextBoxColumn();
            pnlCustomersToolbar = new Panel();
            btnCustomerRefresh = new Button();
            btnCustomerDelete = new Button();
            btnCustomerAdd = new Button();
            lblCustomersTitle = new Label();
            pnlCustomersList = new Panel();
            dgvCustomers = new DataGridView();
            custColID = new DataGridViewTextBoxColumn();
            custColName = new DataGridViewTextBoxColumn();
            custColContact = new DataGridViewTextBoxColumn();
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
            pnlCustomersToolbar.BackColor = Color.White;
            pnlCustomersToolbar.Controls.Add(btnCustomerRefresh);
            pnlCustomersToolbar.Controls.Add(btnCustomerDelete);
            pnlCustomersToolbar.Controls.Add(btnCustomerAdd);
            pnlCustomersToolbar.Controls.Add(lblCustomersTitle);
            pnlCustomersToolbar.Dock = DockStyle.Top;
            pnlCustomersToolbar.Location = new Point(0, 0);
            pnlCustomersToolbar.Name = "pnlCustomersToolbar";
            pnlCustomersToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlCustomersToolbar.Size = new Size(1200, 70);
            pnlCustomersToolbar.TabIndex = 1;
            // 
            // btnCustomerRefresh
            // 
            btnCustomerRefresh.BackColor = Color.SteelBlue;
            btnCustomerRefresh.FlatStyle = FlatStyle.Flat;
            btnCustomerRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCustomerRefresh.ForeColor = Color.White;
            btnCustomerRefresh.Location = new Point(901, 22);
            btnCustomerRefresh.Name = "btnCustomerRefresh";
            btnCustomerRefresh.Size = new Size(202, 35);
            btnCustomerRefresh.TabIndex = 4;
            btnCustomerRefresh.Text = "Refresh";
            btnCustomerRefresh.UseVisualStyleBackColor = false;
            btnCustomerRefresh.Click += btnCustomerRefresh_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.BackColor = Color.Firebrick;
            btnCustomerDelete.FlatStyle = FlatStyle.Flat;
            btnCustomerDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCustomerDelete.ForeColor = Color.White;
            btnCustomerDelete.Location = new Point(703, 22);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(159, 35);
            btnCustomerDelete.TabIndex = 3;
            btnCustomerDelete.Text = "Delete Employee";
            btnCustomerDelete.UseVisualStyleBackColor = false;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.BackColor = Color.ForestGreen;
            btnCustomerAdd.FlatStyle = FlatStyle.Flat;
            btnCustomerAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCustomerAdd.ForeColor = Color.White;
            btnCustomerAdd.Location = new Point(507, 22);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(170, 35);
            btnCustomerAdd.TabIndex = 2;
            btnCustomerAdd.Text = "+ Add Employee";
            btnCustomerAdd.UseVisualStyleBackColor = false;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // lblCustomersTitle
            // 
            lblCustomersTitle.AutoSize = true;
            lblCustomersTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCustomersTitle.ForeColor = Color.Black;
            lblCustomersTitle.Location = new Point(20, 15);
            lblCustomersTitle.Name = "lblCustomersTitle";
            lblCustomersTitle.Size = new Size(136, 32);
            lblCustomersTitle.TabIndex = 0;
            lblCustomersTitle.Text = "Employees";
            // 
            // pnlCustomersList
            // 
            pnlCustomersList.Controls.Add(dgvCustomers);
            pnlCustomersList.Dock = DockStyle.Fill;
            pnlCustomersList.Location = new Point(0, 70);
            pnlCustomersList.Name = "pnlCustomersList";
            pnlCustomersList.Padding = new Padding(20);
            pnlCustomersList.Size = new Size(1200, 630);
            pnlCustomersList.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            // =============================
            // DataGridView Styling
            // =============================

            // dgvCustomers
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;

            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.ReadOnly = true;

            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeRows = false;

            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.AutoGenerateColumns = false;

            // Header style
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvCustomers.ColumnHeadersHeight = 35;

            // Row style
            dgvCustomers.DefaultCellStyle.BackColor = Color.White;
            dgvCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dgvCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 11F);

            dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            dgvCustomers.RowTemplate.Height = 40;

            // IMPORTANT: add the columns
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[]
            {
    custColID,
    custColName,
    custColAddress,
    custColContact,
    custColCreated
            });

            // Center important columns
            custColID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            custColName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlCustomersList);
            Controls.Add(pnlCustomersToolbar);
            Name = "EmployeesControl";
            Size = new Size(1200, 700);
            pnlCustomersToolbar.ResumeLayout(false);
            pnlCustomersToolbar.PerformLayout();
            pnlCustomersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCustomersToolbar;
        private Label lblCustomersTitle;
        private Panel pnlCustomersList;
        private DataGridView dgvCustomers;

        private DataGridViewTextBoxColumn custColID;
        private DataGridViewTextBoxColumn custColName;
        private DataGridViewTextBoxColumn custColContact;
        private Button btnCustomerRefresh;
        private Button btnCustomerDelete;
        private Button btnCustomerAdd;
        private DataGridViewTextBoxColumn custColAddress;
        private DataGridViewTextBoxColumn custColCreated;
    }
}
