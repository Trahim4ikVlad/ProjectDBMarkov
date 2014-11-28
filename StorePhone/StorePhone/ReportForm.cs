using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorePhone
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private StorePhoneEntities _entities = new StorePhoneEntities();

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportByOrder();
        }

        private void ReportByOrder()
        {
            IList<Specification> spec = _entities.Specification.ToList();

            var report = spec.Select(x => new
            {
                Date = x.Order.OrderDate,
                client = x.Order.Client1.SecondName + " " +x.Order.Client1.FirstName,
                emp = x.Order.Employee1.SecondName + " " + x.Order.Employee1.FirstName,
                Sum = x.Count * x.PriceModel

            }).ToList();

            this.dataGridView1.DataSource = report;
            this.dataGridView1.Columns[0].HeaderText = "Дата";
            this.dataGridView1.Columns[1].HeaderText = "Клиент";
            this.dataGridView1.Columns[2].HeaderText = "Сотрудник";
            this.dataGridView1.Columns[3].HeaderText = "Сумма, $";
        }

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ReportByOrder();
        }

        


    }
}
