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
    public partial class EditOrdersForm : Form
    {
        public EditOrdersForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storePhoneDataSet);

        }

        private void EditOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storePhoneDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.storePhoneDataSet.Client);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.storePhoneDataSet.Employee);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Specification' table. You can move, or remove it, as needed.
            this.specificationTableAdapter.Fill(this.storePhoneDataSet.Specification);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.storePhoneDataSet.Order);

        }

        StorePhoneEntities _entities = new StorePhoneEntities();

     

        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.RowHeadersVisible = false;
            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            // Set the row and column header styles.
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
         EditSpecForm form = new EditSpecForm();
         form.OrderId = int.Parse(iDTextBox.Text);
         form.Show();
        }

       
    }
}
