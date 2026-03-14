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
            pnlProductsToolbar = new Panel();
            btnProductRefresh = new Button();
            btnProductAdd = new Button();
            lblProductsTitle = new Label();
            pnlProductsList = new Panel();
            dgvProducts = new DataGridView();
            prodColID = new DataGridViewTextBoxColumn();
            prodColName = new DataGridViewTextBoxColumn();
            prodColCategory = new DataGridViewTextBoxColumn();
            prodColUnit = new DataGridViewTextBoxColumn();
            prodColPrice = new DataGridViewTextBoxColumn();
            prodColStock = new DataGridViewTextBoxColumn();
            prodColStatus = new DataGridViewTextBoxColumn();
            btnProductEdit = new Button();
            btnProductDelete = new Button();
            pnlProductsToolbar.SuspendLayout();
            pnlProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlProductsToolbar
            // 
            pnlProductsToolbar.BackColor = Color.White;
            pnlProductsToolbar.Controls.Add(btnProductDelete);
            pnlProductsToolbar.Controls.Add(btnProductEdit);
            pnlProductsToolbar.Controls.Add(btnProductRefresh);
            pnlProductsToolbar.Controls.Add(btnProductAdd);
            pnlProductsToolbar.Controls.Add(lblProductsTitle);
            pnlProductsToolbar.Dock = DockStyle.Top;
            pnlProductsToolbar.Location = new Point(0, 0);
            pnlProductsToolbar.Name = "pnlProductsToolbar";
            pnlProductsToolbar.Padding = new Padding(20, 10, 20, 10);
            pnlProductsToolbar.Size = new Size(1200, 70);
            pnlProductsToolbar.TabIndex = 1;
            // 
            // btnProductRefresh
            // 
            btnProductRefresh.BackColor = Color.SteelBlue;
            btnProductRefresh.FlatStyle = FlatStyle.Flat;
            btnProductRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProductRefresh.ForeColor = Color.White;
            btnProductRefresh.Location = new Point(694, 16);
            btnProductRefresh.Name = "btnProductRefresh";
            btnProductRefresh.Size = new Size(120, 35);
            btnProductRefresh.TabIndex = 0;
            btnProductRefresh.Text = "Refresh";
            btnProductRefresh.UseVisualStyleBackColor = false;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = Color.ForestGreen;
            btnProductAdd.FlatStyle = FlatStyle.Flat;
            btnProductAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProductAdd.ForeColor = Color.White;
            btnProductAdd.Location = new Point(541, 16);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(120, 35);
            btnProductAdd.TabIndex = 1;
            btnProductAdd.Text = "Add Product";
            btnProductAdd.UseVisualStyleBackColor = false;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProductsTitle.ForeColor = Color.Black;
            lblProductsTitle.Location = new Point(20, 15);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(263, 32);
            lblProductsTitle.TabIndex = 2;
            lblProductsTitle.Text = "Product Management";
            // 
            // pnlProductsList
            // 
            pnlProductsList.Controls.Add(dgvProducts);
            pnlProductsList.Dock = DockStyle.Fill;
            pnlProductsList.Location = new Point(0, 70);
            pnlProductsList.Name = "pnlProductsList";
            pnlProductsList.Padding = new Padding(20);
            pnlProductsList.Size = new Size(1200, 630);
            pnlProductsList.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] {
    prodColID,
    prodColName,
    prodColCategory,
    prodColUnit,
    prodColPrice,
    prodColStock,
    prodColStatus
});
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(20, 20);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 30;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1160, 590);
            dgvProducts.TabIndex = 0;
            // 
            // prodColID
            // 
            // product_id
            prodColID.DataPropertyName = "product_id";
            prodColID.HeaderText = "product_id";
            prodColID.MinimumWidth = 6;
            prodColID.Name = "prodColID";
            prodColID.ReadOnly = true;

            // product_name
            prodColName.DataPropertyName = "product_name";
            prodColName.HeaderText = "product_name";
            prodColName.MinimumWidth = 6;
            prodColName.Name = "prodColName";
            prodColName.ReadOnly = true;

            // product_category
            // product_cat_type
            prodColCategory.DataPropertyName = "product_cat_type";
            prodColCategory.HeaderText = "Category";
            prodColCategory.MinimumWidth = 6;
            prodColCategory.Name = "prodColCategory";
            prodColCategory.ReadOnly = true;

            // product_unit
            prodColUnit.DataPropertyName = "product_unit";
            prodColUnit.HeaderText = "product_unit";
            prodColUnit.MinimumWidth = 6;
            prodColUnit.Name = "prodColUnit";
            prodColUnit.ReadOnly = true;

            // product_price
            prodColPrice.DataPropertyName = "product_price";
            prodColPrice.HeaderText = "product_price";
            prodColPrice.MinimumWidth = 6;
            prodColPrice.Name = "prodColPrice";
            prodColPrice.ReadOnly = true;

            // product_stock
            // product_stock_level
            prodColStock.DataPropertyName = "product_stock_level";
            prodColStock.HeaderText = "Stock";
            prodColStock.MinimumWidth = 6;
            prodColStock.Name = "prodColStock";
            prodColStock.ReadOnly = true;

            // is_active
            prodColStatus.DataPropertyName = "is_active";
            prodColStatus.HeaderText = "is_active";
            prodColStatus.MinimumWidth = 6;
            prodColStatus.Name = "prodColStatus";
            prodColStatus.ReadOnly = true;


            btnProductEdit.BackColor = Color.DarkOrange;
            btnProductEdit.FlatStyle = FlatStyle.Flat;
            btnProductEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProductEdit.ForeColor = Color.White;
            btnProductEdit.Location = new Point(840, 16);
            btnProductEdit.Name = "btnProductEdit";
            btnProductEdit.Size = new Size(120, 35);
            btnProductEdit.TabIndex = 3;
            btnProductEdit.Text = "Edit Product";
            btnProductEdit.UseVisualStyleBackColor = false;
            // 
            // btnProductDelete
            // 
            btnProductDelete.BackColor = Color.Firebrick;
            btnProductDelete.FlatStyle = FlatStyle.Flat;
            btnProductDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProductDelete.ForeColor = Color.White;
            btnProductDelete.Location = new Point(984, 16);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(120, 35);
            btnProductDelete.TabIndex = 4;
            btnProductDelete.Text = "Delete Product";
            btnProductDelete.UseVisualStyleBackColor = false;
            // 
            // ProductsControl
            // 
            BackColor = Color.WhiteSmoke;
            Controls.Add(pnlProductsList);
            Controls.Add(pnlProductsToolbar);
            Name = "ProductsControl";
            Size = new Size(1200, 700);
            pnlProductsToolbar.ResumeLayout(false);
            pnlProductsToolbar.PerformLayout();
            pnlProductsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

         
        }

        private Panel pnlProductsToolbar;
        private Label lblProductsTitle;
        private Button btnProductAdd;
        private Button btnProductRefresh;
        private Panel pnlProductsList;
        private DataGridView dgvProducts;

        private DataGridViewTextBoxColumn prodColID;
        private DataGridViewTextBoxColumn prodColName;
        private DataGridViewTextBoxColumn prodColPrice;
      
        private DataGridViewTextBoxColumn prodColUnit;
        private DataGridViewTextBoxColumn prodColStatus;
        private Button btnProductDelete;
        private Button btnProductEdit;

        private DataGridViewTextBoxColumn prodColCategory;
        private DataGridViewTextBoxColumn prodColStock;


    }
}