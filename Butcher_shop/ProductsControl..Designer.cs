namespace Butcher_shop
{
    partial class ProductsControl
    {
        private System.ComponentModel.IContainer components = null;
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
            pnlProductsToolbar = new System.Windows.Forms.Panel();
            btnProductDelete = new System.Windows.Forms.Button();
            btnProductEdit = new System.Windows.Forms.Button();
            btnProductRefresh = new System.Windows.Forms.Button();
            btnProductAdd = new System.Windows.Forms.Button();
            lblProductsTitle = new System.Windows.Forms.Label();
            pnlProductsList = new System.Windows.Forms.Panel();
            dgvProducts = new System.Windows.Forms.DataGridView();
            prodColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodColUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlProductsToolbar.SuspendLayout();
            pnlProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlProductsToolbar
            // 
            pnlProductsToolbar.BackColor = System.Drawing.Color.White;
            pnlProductsToolbar.Controls.Add(btnProductDelete);
            pnlProductsToolbar.Controls.Add(btnProductEdit);
            pnlProductsToolbar.Controls.Add(btnProductRefresh);
            pnlProductsToolbar.Controls.Add(btnProductAdd);
            pnlProductsToolbar.Controls.Add(lblProductsTitle);
            pnlProductsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlProductsToolbar.Location = new System.Drawing.Point(0, 0);
            pnlProductsToolbar.Name = "pnlProductsToolbar";
            pnlProductsToolbar.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            pnlProductsToolbar.Size = new System.Drawing.Size(1200, 70);
            pnlProductsToolbar.TabIndex = 1;
            // 
            // btnProductDelete
            // 
            btnProductDelete.BackColor = System.Drawing.Color.Firebrick;
            btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnProductDelete.ForeColor = System.Drawing.Color.White;
            btnProductDelete.Location = new System.Drawing.Point(984, 16);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new System.Drawing.Size(120, 35);
            btnProductDelete.TabIndex = 4;
            btnProductDelete.Text = "Delete Product";
            btnProductDelete.UseVisualStyleBackColor = false;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // btnProductEdit
            // 
            btnProductEdit.BackColor = System.Drawing.Color.DarkOrange;
            btnProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnProductEdit.ForeColor = System.Drawing.Color.White;
            btnProductEdit.Location = new System.Drawing.Point(840, 16);
            btnProductEdit.Name = "btnProductEdit";
            btnProductEdit.Size = new System.Drawing.Size(120, 35);
            btnProductEdit.TabIndex = 3;
            btnProductEdit.Text = "Edit Product";
            btnProductEdit.UseVisualStyleBackColor = false;
            btnProductEdit.Click += btnProductEdit_Click;
            // 
            // btnProductRefresh
            // 
            btnProductRefresh.BackColor = System.Drawing.Color.SteelBlue;
            btnProductRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnProductRefresh.ForeColor = System.Drawing.Color.White;
            btnProductRefresh.Location = new System.Drawing.Point(694, 16);
            btnProductRefresh.Name = "btnProductRefresh";
            btnProductRefresh.Size = new System.Drawing.Size(120, 35);
            btnProductRefresh.TabIndex = 0;
            btnProductRefresh.Text = "Refresh";
            btnProductRefresh.UseVisualStyleBackColor = false;
            btnProductRefresh.Click += btnProductRefresh_Click;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = System.Drawing.Color.ForestGreen;
            btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnProductAdd.ForeColor = System.Drawing.Color.White;
            btnProductAdd.Location = new System.Drawing.Point(541, 16);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new System.Drawing.Size(120, 35);
            btnProductAdd.TabIndex = 1;
            btnProductAdd.Text = "Add Product";
            btnProductAdd.UseVisualStyleBackColor = false;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblProductsTitle.ForeColor = System.Drawing.Color.Black;
            lblProductsTitle.Location = new System.Drawing.Point(20, 15);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new System.Drawing.Size(263, 32);
            lblProductsTitle.TabIndex = 2;
            lblProductsTitle.Text = "Product Management";
            // 
            // pnlProductsList
            // 
            pnlProductsList.Controls.Add(dgvProducts);
            pnlProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlProductsList.Location = new System.Drawing.Point(0, 70);
            pnlProductsList.Name = "pnlProductsList";
            pnlProductsList.Padding = new System.Windows.Forms.Padding(20);
            pnlProductsList.Size = new System.Drawing.Size(1200, 630);
            pnlProductsList.TabIndex = 0;
            // 
            // dgvProducts
            // 
            // --- UI UPDATE: NEW STANDARDIZED DESIGN SYSTEM APPLIED HERE ---
            dgvProducts.BackgroundColor = System.Drawing.Color.White;
            dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;

            // Maintained from original setup
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoGenerateColumns = false; // Added to prevent duplicate columns

            // Styling for readability
            dgvProducts.EnableHeadersVisualStyles = false;

            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            dgvProducts.ColumnHeadersHeight = 45;

            dgvProducts.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvProducts.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dgvProducts.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F);
            dgvProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            dgvProducts.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvProducts.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            dgvProducts.GridColor = System.Drawing.Color.FromArgb(235, 235, 235);
            dgvProducts.RowTemplate.Height = 45;
            // -------------------------------------------------------------

            dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { prodColID, prodColName, prodColCategory, prodColUnit, prodColPrice, prodColStock, prodColStatus });
            dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProducts.Location = new System.Drawing.Point(20, 20);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new System.Drawing.Size(1160, 590);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // prodColID
            // 
            prodColID.DataPropertyName = "product_id";
            prodColID.HeaderText = "product_id";
            prodColID.MinimumWidth = 6;
            prodColID.Name = "prodColID";
            prodColID.ReadOnly = true;
            // 
            // prodColName
            // 
            prodColName.DataPropertyName = "product_name";
            prodColName.HeaderText = "product_name";
            prodColName.MinimumWidth = 6;
            prodColName.Name = "prodColName";
            prodColName.ReadOnly = true;
            // 
            // prodColCategory
            // 
            prodColCategory.DataPropertyName = "product_cat_type";
            prodColCategory.HeaderText = "Category";
            prodColCategory.MinimumWidth = 6;
            prodColCategory.Name = "prodColCategory";
            prodColCategory.ReadOnly = true;
            // 
            // prodColUnit
            // 
            prodColUnit.DataPropertyName = "product_unit";
            prodColUnit.HeaderText = "product_unit";
            prodColUnit.MinimumWidth = 6;
            prodColUnit.Name = "prodColUnit";
            prodColUnit.ReadOnly = true;
            // 
            // prodColPrice
            // 
            prodColPrice.DataPropertyName = "product_price";
            prodColPrice.HeaderText = "product_price";
            prodColPrice.MinimumWidth = 6;
            prodColPrice.Name = "prodColPrice";
            prodColPrice.ReadOnly = true;
            // 
            // prodColStock
            // 
            prodColStock.DataPropertyName = "product_stock_level";
            prodColStock.HeaderText = "Stock";
            prodColStock.MinimumWidth = 6;
            prodColStock.Name = "prodColStock";
            prodColStock.ReadOnly = true;
            // 
            // prodColStatus
            // 
            prodColStatus.DataPropertyName = "is_active";
            prodColStatus.HeaderText = "is_active";
            prodColStatus.MinimumWidth = 6;
            prodColStatus.Name = "prodColStatus";
            prodColStatus.ReadOnly = true;
            // 
            // ProductsControl
            // 
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(pnlProductsList);
            Controls.Add(pnlProductsToolbar);
            Name = "ProductsControl";
            Size = new System.Drawing.Size(1200, 700);
            pnlProductsToolbar.ResumeLayout(false);
            pnlProductsToolbar.PerformLayout();
            pnlProductsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlProductsToolbar;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductRefresh;
        private System.Windows.Forms.Panel pnlProductsList;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColPrice;

        private System.Windows.Forms.DataGridViewTextBoxColumn prodColUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColStatus;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColStock;
    }
}