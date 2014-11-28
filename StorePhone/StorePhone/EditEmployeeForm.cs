using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorePhone
{
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storePhoneDataSet);

        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storePhoneDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.storePhoneDataSet.Employee);

        }
    }
}
