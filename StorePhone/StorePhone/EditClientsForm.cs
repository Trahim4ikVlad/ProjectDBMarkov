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
    public partial class EditClientsForm : Form
    {
        public EditClientsForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        StorePhoneEntities _entities = new StorePhoneEntities();

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storePhoneDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.storePhoneDataSet.Client);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.storePhoneDataSet.Client);
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storePhoneDataSet);

        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storePhoneDataSet);

        }
        private void InitializeDataGridView()
        {
            // Initialize basic DataGridView properties.
            clientDataGridView.Dock = DockStyle.Bottom;
            clientDataGridView.BackgroundColor = Color.LightGray;
            clientDataGridView.BorderStyle = BorderStyle.Fixed3D;
            clientDataGridView.RowHeadersVisible = false;
            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            clientDataGridView.AllowUserToAddRows = false;
            clientDataGridView.AllowUserToDeleteRows = false;
            clientDataGridView.AllowUserToOrderColumns = true;
            clientDataGridView.ReadOnly = true;
            clientDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientDataGridView.MultiSelect = false;
            clientDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            clientDataGridView.AllowUserToResizeColumns = false;
            clientDataGridView.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            clientDataGridView.AllowUserToResizeRows = false;
            clientDataGridView.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            clientDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            clientDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            clientDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            clientDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
            clientDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            // Set the row and column header styles.
            clientDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            clientDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            clientDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
        }

       
       
    }
}
