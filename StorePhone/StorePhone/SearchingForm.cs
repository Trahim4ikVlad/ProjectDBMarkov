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
    public partial class SearchingForm : Form
    {
        public SearchingForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void SearchingForm_Load(object sender, EventArgs e)
        {
            
        }

        StorePhoneEntities _entities = new StorePhoneEntities();
        public void SearhClient(string str)
        {
            if (_entities != null)
            {
                var clients = _entities.Client.Where(x=>x.SecondName==str || x.FirstName == str || x.City == str || x.PassportData==str).Select(x=>new
                {
                    fullName = x.SecondName + " " + x.FirstName,
                    passport = x.PassportData,
                    sity = x.City,
                    street= x.Street
                }).ToList();
                this.dataGridView1.DataSource = clients;
            }

            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "Пасспорт";
            dataGridView1.Columns[2].HeaderText = "Город";
            dataGridView1.Columns[3].HeaderText = "Улица";
        }

        public void SearhModel(string str)
        {
            if (_entities != null)
            {
                var clients = _entities.Model.Where(x =>x.Producer1.Name == str ||x.Model1 == str || x.OperationSystem == str).Select(x => new
                {
                    prod = x.Producer1.Name,
                    name = x.Model1,
                    os = x.OperationSystem,
                    camera = x.Camera,
                    price = x.Price
                    
                }).ToList();
                this.dataGridView1.DataSource = clients;
            }
            dataGridView1.Columns[0].HeaderText = "Производитель";
            dataGridView1.Columns[1].HeaderText = "Модель";
            dataGridView1.Columns[2].HeaderText = "Система";
            dataGridView1.Columns[3].HeaderText = "Камера";
            dataGridView1.Columns[4].HeaderText = "Цена";

        }

        public void SearhOrder(string str)
        {
            if (_entities != null)
            {
                var orders = _entities.Order.Where(x=>x.Client1.SecondName == str|| x.Employee1.SecondName == str || x.FormOfPayment == str).Select(x => new
                {
                    prod = x.OrderDate,
                    name = x.Client1.SecondName + " " + x.Client1.FirstName,
                    emp = x.Employee1.SecondName + " " + x.Employee1.FirstName,
                    pay = x.FormOfPayment
                  
                }).ToList();
                this.dataGridView1.DataSource = orders;
            }
            dataGridView1.Columns[0].HeaderText = "Дата";
            dataGridView1.Columns[1].HeaderText = "Клиент";
            dataGridView1.Columns[2].HeaderText = "Сотрудник";
            dataGridView1.Columns[2].HeaderText = "Форма оплаты";
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


    }
}
