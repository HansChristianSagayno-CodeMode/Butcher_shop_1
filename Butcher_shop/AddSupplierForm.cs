using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Butcher_shop
{
    public partial class AddSupplierForm : Form
    {
        Butcher db = new Butcher();

        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;

            string query = $"INSERT INTO SUPPLIER (supplier_name, supplier_address, supplier_contact) " +
                           $"VALUES ('{name}','{address}','{contact}')";

            db.sqlManager(query);

            MessageBox.Show("Supplier added successfully.");

            this.Close();
        }
    }
}