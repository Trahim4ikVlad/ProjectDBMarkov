using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace StorePhone
{
    public partial class ExecuteOrderForm : Form
    {

        IList<Warehouse> _warehouse = new List<Warehouse>();
 
        public ExecuteOrderForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            foreach (var count in _entities.Model)
            {
               _warehouse.Add(new Warehouse()
               {
                   Id = count.ID,
                   Residue = 20
               });
            }
        }
      
        private void ExecuteOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storePhoneDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.storePhoneDataSet1.Employee);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.storePhoneDataSet.Model);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.storePhoneDataSet.Employee);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.storePhoneDataSet.Order);
            // TODO: This line of code loads data into the 'storePhoneDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.storePhoneDataSet.Client);
            BindingList();
        }

        private  StorePhoneEntities _entities = new StorePhoneEntities();

        private  void BindingList()
        {

            IList<Client> clients = _entities.Client.ToList();

            var client = clients.Select(cl => new
            {
                Name = cl.SecondName +" "+ cl.FirstName,
                cl.ID
            }).ToList();

            this.comboBox3.DataSource = client;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.ValueMember = "ID";

            IList<Employee> employees = _entities.Employee.ToList();


            var emploee = employees.Select(x => new
            {
                Name = x.SecondName + " " + x.FirstName, x.ID
            }).ToList();

            this.comboBox2.DataSource = emploee;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.ValueMember = "ID";


            IList<Model> models = _entities.Model.ToList();

            var model = models.Select(x => new
            {
                Name = x.Model1, x.ID
            }).ToList();

            this.comboBox1.DataSource = model;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "ID";
            textBox2.Text = ((int)_entities.Model.First(x => x.ID == (int)comboBox1.SelectedValue).Price*1.4).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditClientsForm form = new EditClientsForm();
            form.ShowDialog();
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

        IList<Specification> specifications = new List<Specification>();

        private Order order;
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (_warehouse.First(x => x.Id == (int) comboBox1.SelectedValue).Residue - int.Parse(textBox1.Text) >= 0)
                {
                    var spec = new Specification()
                    {
                        ModelId = (int)comboBox1.SelectedValue,
                        Count = int.Parse(textBox1.Text),
                        PriceModel = double.Parse(textBox2.Text)
                    };

                    specifications.Add(spec);
                }
                else
                {
                    MessageBox.Show("В наличие не хватает \n" + Math.Abs(
                                    (_warehouse.First(x => x.Id == (int) comboBox1.SelectedValue).Residue -
                                     int.Parse(textBox1.Text))) + " моделей");
                }        
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
            var sp = specifications.Select(x => new
            {
                model = _entities.Model.First(y => y.ID == x.ModelId).Model1,
                count = x.Count,
                price = x.PriceModel

            }).ToList();

            this.dataGridView1.DataSource = sp;
            this.dataGridView1.Columns[0].HeaderText = "Модель";
            this.dataGridView1.Columns[1].HeaderText = "Количество";
            this.dataGridView1.Columns[2].HeaderText = "Цена, $";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order = new Order
            {
                OrderDate = DateTime.Now,

                Employee = (int)comboBox2.SelectedValue,
                Client = (int)comboBox3.SelectedValue,
                FormOfPayment = textBox3.Text
            };
            _entities.Order.Add(order);
            _entities.SaveChanges();


            foreach (Specification spec in specifications)
            {
                spec.OrderId = order.ID;
                spec.Order = order;
                spec.Model = _entities.Model.First(x => x.ID == spec.ModelId);
                String query = "INSERT INTO Specification (OrderId, ModelId, Count, PriceModel)     VALUES  (" +spec.OrderId+"," +spec.ModelId+","+spec.Count+","+spec.PriceModel+")";
                _entities.Database.ExecuteSqlCommand(query);
                _entities.SaveChanges();
            }
            MessageBox.Show("Заказ успешно оформлен!!");
        }

     
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox2.Text = (_entities.Model.First(x => x.ID == (int) comboBox1.SelectedValue).Price*1.4).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Vlad\Documents\Visual Studio 2012\Projects\StorePhone\Reports\ByOrder\" + order.Client1.SecondName + "&&" + order.Employee1.SecondName + ".pdf", FileMode.Create));
            doc.Open();
          //  iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\");
           // jpg.Alignment = Element.ALIGN_CENTER;
           // doc.Add(jpg);

            Paragraph paragraph = new Paragraph("Order  number :" + order.ID);
            doc.Add(paragraph);
            doc.Add(new Paragraph("     "));

            Paragraph p0 = new Paragraph("Shop in the face of employee :");
            doc.Add(p0);

            Paragraph p1 = new Paragraph(order.Employee1.SecondName + " " +order.Employee1.FirstName);
            doc.Add(p1);

            Paragraph p4 = new Paragraph(" on the one hand and client :");
            doc.Add(p4);

            Paragraph p5 = new Paragraph(order.Client1.SecondName + " " + order.Client1.FirstName +" passport data:"+ order.Client1.PassportData);
            doc.Add(p5);

            Paragraph p6 = new Paragraph(" on the other hand entered into this agreement.");
            doc.Add(p6);

            PdfPTable table = new PdfPTable(3);
            PdfPCell cell = new PdfPCell(new Phrase("The contents of the order:",
              new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
              iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));
          
            cell.BackgroundColor = new BaseColor(Color.Wheat);
            cell.Padding = 5;
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
           
            table.AddCell(cell);
            table.AddCell("Model");
            table.AddCell("Count, units");
            table.AddCell("Amount per, $");

            doc.Add(new Paragraph("  "));
            Paragraph p2 = new Paragraph("The date of conclusion of the contract " + order.OrderDate);
            doc.Add(p2);
            Paragraph p7 = new Paragraph("  ");
            doc.Add(p7);

            foreach (Specification specification in specifications)
            {
                table.AddCell(specification.Model.Model1);
                table.AddCell(specification.Count.ToString());
                table.AddCell(specification.PriceModel.ToString());
            }
           
            PdfPCell cell1 = new PdfPCell(new Phrase("The total value of the contract: "));
            cell1.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell1.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            cell1.BackgroundColor = new BaseColor(Color.Wheat);
            table.AddCell(cell1);

            PdfPCell cell3 = new PdfPCell(new Phrase(" - "));
            cell3.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell3.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell3);
           
            PdfPCell cell2 = new PdfPCell(new Phrase("Total: " + specifications.Sum(x=>x.PriceModel) + " $"));
            cell2.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            cell2.BackgroundColor = new BaseColor(Color.OrangeRed);
            table.AddCell(cell2);
     
            doc.Add(table);
            doc.Close();
        }
    }

    internal class Warehouse
    {
        public int Id { get; set; }
        public int Residue { get; set; }
    }
}
