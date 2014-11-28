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
    public partial class ViewForm : Form
    {
        StorePhoneEntities _entities = new StorePhoneEntities();
        public ViewForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            //ShowModelsPhone();
           // ShowOrders();
           // ShowClients();
        }
      
        public void ShowModelsPhone()
        {
           IList<Model> models = _entities.Model.ToList();

           this.Text = "Имеющиеся модели";

           var query =
           from model in models
           select new 
           { 
               model.Producer1.Name,
               model.Model1, 
               model.OperationSystem, 
               model.Price,
               model.Memory,
               model.CountCore,
               model.Camera  
           };
            dataGridView1.DataSource = query.ToList();
            dataGridView1.Columns[0].HeaderText = "Producer";

            dataGridView1.Columns[1].HeaderText = "Model";
            dataGridView1.Columns[2].HeaderText = "System";
            dataGridView1.Columns[3].HeaderText = "Price, $";
            dataGridView1.Columns[4].HeaderText = "Memory, Gb";
            dataGridView1.Columns[5].HeaderText = "Core";
            dataGridView1.Columns[6].HeaderText = "Camera";
        }

        public void ShowOrders()
        {
            IList<Order> orders = _entities.Order.ToList();

            this.Text =  " Наши заказы";

            var query =
            from order in orders 
            select new
            {
               order.OrderDate, 
               emp = order.Employee1.SecondName +" " + order.Employee1.FirstName, 
               client = order.Client1.SecondName+" " +order.Client1.FirstName,
               order.FormOfPayment
            };

            dataGridView1.DataSource = query.ToList();
            dataGridView1.Columns[0].HeaderText = "Date";
            dataGridView1.Columns[1].HeaderText = "Employee";
            dataGridView1.Columns[2].HeaderText = "Client";
            dataGridView1.Columns[3].HeaderText = "Payment";
           
        }

        public void ShowEmployee()
        {
            IList<Employee> employees = _entities.Employee.ToList();

            this.Text = "Наши сотрудники";
            var query =
            from employee in employees
        
            select new
            {
                fullname = employee.SecondName+" "+employee.FirstName,
                employee.PassportData,
                employee.Age,
                employee.Position
            };

            dataGridView1.DataSource = query.ToList();

            dataGridView1.Columns[0].HeaderText = "FullName";
            dataGridView1.Columns[1].HeaderText = "Passport";
            dataGridView1.Columns[2].HeaderText = "Age";
            dataGridView1.Columns[3].HeaderText = "Position";
        }

        public void ShowClients()
        {
            IList<Client> clients = _entities.Client.ToList();
            
            this.Text = "Наши клиенты";
            
            var query =
            from client in clients

            select new
            {
                fullname = client.SecondName +" " + client.FirstName,
                client.PassportData,
                fullAdress =  client.City +" " + client.Street
            };

            dataGridView1.DataSource = query.ToList();

            dataGridView1.Columns[0].HeaderText = "FullName";
            dataGridView1.Columns[1].HeaderText = "Passport";
            dataGridView1.Columns[2].HeaderText = "Address";  
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
