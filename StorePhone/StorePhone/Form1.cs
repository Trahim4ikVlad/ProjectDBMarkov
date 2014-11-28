using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace StorePhone
{
    public partial class Form1 : Form
    {
        public delegate void DelegateForTime(Label label);
        // поле типа делегата  
        private DelegateForTime DelTime;

        private Thread t1;  

        private StorePhoneEntities _entities  = new StorePhoneEntities();

        public Form1()
        {
            InitializeComponent();
            DelTime = new DelegateForTime(StartTime);// указываем метод делегату  
            comboBox1.Items.Add("Клиенты");
            comboBox1.Items.Add("Телефоны");
            comboBox1.Items.Add("Сотрудники");
            comboBox1.Items.Add("Заказы");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1 = new Thread(LabelTime); // создаем поток  
            t1.IsBackground = true; // задаем фоновый режым  
            t1.Priority = ThreadPriority.Lowest; // указываем свмый низкий приоритет  
            t1.Start(); // стартуем  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewForm form = new ViewForm();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    form.ShowClients();
                    form.ShowDialog();
                    break;
                case 1:
                    form.ShowModelsPhone();
                    form.ShowDialog();
                    break;
                case 2:
                    form.ShowEmployee();
                    form.ShowDialog();
                    break;
                case 3:
                    form.ShowOrders();
                    form.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Выберите критерий!");
                    break;
            }
        }

        void StartTime(Label label)
        {
            string s = DateTime.Now.Hour.ToString("00");
            s += " : ";
            s += DateTime.Now.Minute.ToString("00");

            s += " : " + DateTime.Now.Second.ToString("00");
            label.Text = s;
        }

        void LabelTime()
        {  
            while (true)
            {
                Invoke(DelTime, _dataLabel);       
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExecuteOrderForm form = new ExecuteOrderForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecuteOrderForm form = new ExecuteOrderForm();
            form.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                {
                    EditClientsForm form = new EditClientsForm();
                    form.ShowDialog();   
                }
                    break;
                case 1:
                {
                    EditPhonesForm form = new EditPhonesForm();
                    form.ShowDialog();
                }
                    break;
                case 2:
                    {
                        EditEmployeeForm form = new EditEmployeeForm();
                        form.ShowDialog();
                    }

                    break;
                case 3:
                    {
                        EditOrdersForm form = new EditOrdersForm();
                        form.ShowDialog();
                    }

                    break;
                default:
                    MessageBox.Show("Выберите критерий!");
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchingForm form = new SearchingForm();
            string searchSting = textBox1.Text;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    form.SearhClient(searchSting);
                    form.ShowDialog();
                    break;
                case 1:
                    form.SearhModel(searchSting);
                    form.ShowDialog();
                    break;
                case 3:
                    form.SearhOrder(searchSting);
                    form.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Выберите критерий!");
                    break;
            }
        }

       
        private void button6_Click_1(object sender, EventArgs e)
        {

            var orderss = _entities.Order.Where(x => x.OrderDate.Day == monthCalendar1.SelectionStart.Day).Select(x => new
            {
                x.OrderDate,
                Employe = x.Employee1.SecondName + " " + x.Employee1.FirstName,
                Client = x.Client1.SecondName + " " + x.Client1.FirstName,
                SumCount = x.Specification.Sum(y => y.Count),
                Sum = x.Specification.Sum(y => y.PriceModel),

            }).ToList();

            int caunt = orderss.Count();
            double sum = orderss.Sum(x => x.Sum);


            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Vlad\Documents\Visual Studio 2012\Projects\StorePhone\Reports\ByDay\" + "Result by " + monthCalendar1.SelectionStart.Day + ".pdf", FileMode.Create));
            doc.Open();


            Paragraph paragraph = new Paragraph("Results sales of the " + monthCalendar1.SelectionStart.Day + "  day ");
            doc.Add(paragraph);
            doc.Add(new Paragraph("     "));

            PdfPTable table = new PdfPTable(2);

            PdfPCell cell = new PdfPCell(new Phrase("Sales for the day:",
              new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
              iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));

            cell.BackgroundColor = new BaseColor(Color.Wheat);
            cell.Padding = 5;
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            table.AddCell(cell);
            table.AddCell("Count, units");
            table.AddCell("Total, $");

            PdfPCell cell1 = new PdfPCell(new Phrase(caunt.ToString()));
            cell1.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            table.AddCell(cell1);

            PdfPCell cell3 = new PdfPCell(new Phrase(sum.ToString()));
            cell3.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell3.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell3);

            doc.Add(table);
            doc.Add(new Paragraph("     "));
            doc.Add(new Paragraph("Detailed annual report..."));
            doc.Add(new Paragraph("     "));
            PdfPTable table2 = new PdfPTable(5);

            PdfPCell c = new PdfPCell(new Phrase("Report sales for the day: ",
              new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
              iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));
            c.Colspan = 5;
            table2.AddCell(c);

            table2.AddCell("Order date:");
            table2.AddCell("Employee:");
            table2.AddCell("Client:");
            table2.AddCell("Caunt phones:");
            table2.AddCell("Total cost:");

            foreach (var order in orderss)
            {
                table2.AddCell(order.OrderDate.ToShortDateString());
                table2.AddCell(order.Employe);
                table2.AddCell(order.Client);
                table2.AddCell(order.SumCount.ToString());
                table2.AddCell(order.Sum.ToString());
            }

            doc.Add(table2);
            doc.Close();


            MessageBox.Show("Отчет  успешно сформирован!\n Количество заказов : " + caunt + "\nОбщая сумма: " + sum + "$");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

            var orderss = _entities.Order.Where(x => x.OrderDate.Month ==  monthCalendar1.SelectionStart.Month).Select(x => new
            {
                x.OrderDate,
                Employe = x.Employee1.SecondName + " " + x.Employee1.FirstName,
                Client = x.Client1.SecondName + " " + x.Client1.FirstName,
                SumCount = x.Specification.Sum(y => y.Count),
                Sum = x.Specification.Sum(y => y.PriceModel),

            }).ToList();

            int caunt = orderss.Count();
            double sum = orderss.Sum(x => x.Sum);


            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Vlad\Documents\Visual Studio 2012\Projects\StorePhone\Reports\ByMonth\" + "Result by " + monthCalendar1.SelectionStart.Month + ".pdf", FileMode.Create));
            doc.Open();


            Paragraph paragraph = new Paragraph("Results sales of the " + monthCalendar1.SelectionStart.Month + "  month ");
            doc.Add(paragraph);
            doc.Add(new Paragraph("     "));

            PdfPTable table = new PdfPTable(2);

            PdfPCell cell = new PdfPCell(new Phrase("Sales for the month:",
              new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
              iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));

            cell.BackgroundColor = new BaseColor(Color.Wheat);
            cell.Padding = 5;
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            table.AddCell(cell);
            table.AddCell("Count, units");
            table.AddCell("Total, $");

            PdfPCell cell1 = new PdfPCell(new Phrase(caunt.ToString()));
            cell1.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            table.AddCell(cell1);

            PdfPCell cell3 = new PdfPCell(new Phrase(sum.ToString()));
            cell3.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell3.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell3);



            doc.Add(table);
            doc.Add(new Paragraph("     "));
            doc.Add(new Paragraph("Detailed annual report..."));
            doc.Add(new Paragraph("     "));
            PdfPTable table2 = new PdfPTable(5);

            PdfPCell c = new PdfPCell(new Phrase("Report sales for the month: ",
              new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
              iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));
            c.Colspan = 5;
            table2.AddCell(c);

            table2.AddCell("Order date:");
            table2.AddCell("Employee:");
            table2.AddCell("Client:");
            table2.AddCell("Caunt phones:");
            table2.AddCell("Total cost:");

            


            foreach (var order in orderss)
            {
                table2.AddCell(order.OrderDate.ToShortDateString());
                table2.AddCell(order.Employe);
                table2.AddCell(order.Client);
                table2.AddCell(order.SumCount.ToString());
                table2.AddCell(order.Sum.ToString());
            }

            doc.Add(table2);
            doc.Close();
    

            MessageBox.Show("Отчет  успешно сформирован!\n Количество заказов : " + caunt + "\nОбщая сумма: " + sum + "$");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IList<Specification> orders = _entities.Specification.Where(x => x.Order.OrderDate.Year == monthCalendar1.SelectionStart.Year).ToList();


            var orderss = _entities.Order.Where(x => x.OrderDate.Year == monthCalendar1.SelectionStart.Year).Select(x => new
            {
                x.OrderDate,
                Employe = x.Employee1.SecondName + " " + x.Employee1.FirstName,
                Client = x.Client1.SecondName + " " + x.Client1.FirstName,
                SumCount = x.Specification.Sum(y => y.Count),
                Sum = x.Specification.Sum(y => y.PriceModel),

            }).ToList();

            int? caunt = orderss.Count();
            double sum = orderss.Sum(x => x.Sum);

                var doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Vlad\Documents\Visual Studio 2012\Projects\StorePhone\Reports\ByYear\" + "Result by " + monthCalendar1.SelectionStart.Year + ".pdf", FileMode.Create));
                doc.Open();


                Paragraph paragraph = new Paragraph("Results sales of the " + monthCalendar1.SelectionStart.Year + " year");
                doc.Add(paragraph);
                doc.Add(new Paragraph("     "));

                PdfPTable table = new PdfPTable(2);

                PdfPCell cell = new PdfPCell(new Phrase("Sales for the year:",
                  new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
                  iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));

                cell.BackgroundColor = new BaseColor(Color.Wheat);
                cell.Padding = 5;
                cell.Colspan = 2;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;

                table.AddCell(cell);
                table.AddCell("Count, units");
                table.AddCell("Total, $");

                PdfPCell cell1 = new PdfPCell(new Phrase(caunt.ToString()));
                cell1.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

                table.AddCell(cell1);

                PdfPCell cell3 = new PdfPCell(new Phrase(sum.ToString()));
                cell3.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell3.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                table.AddCell(cell3);

 
                doc.Add(table);
                doc.Add(new Paragraph("     "));
                doc.Add(new Paragraph("Detailed annual report..."));
                doc.Add(new Paragraph("     "));

                PdfPTable table2 = new PdfPTable(5);
                
                PdfPCell c = new PdfPCell(new Phrase("Report sales for the year: ",
                  new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
                  iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));
                c.Colspan = 5; 
                table2.AddCell(c);
                
                table2.AddCell("Order date:");
                table2.AddCell("Employee:");
                table2.AddCell("Client:");
                table2.AddCell("Caunt models:");
                table2.AddCell("Total cost:");
                
               foreach (var order in orderss)
               {
                   table2.AddCell(order.OrderDate.ToShortDateString());
                   table2.AddCell(order.Employe);
                   table2.AddCell(order.Client);
                   table2.AddCell(order.SumCount.ToString());
                   table2.AddCell(order.Sum.ToString());
               }

                doc.Add(table2);
                doc.Close();

                MessageBox.Show("Отчет  успешно сформирован!\n Количество заказов : " + caunt + "\nОбщая сумма: " + sum + "$");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var orders = _entities.Specification.GroupBy(x=>x.Order.Employee1.ID);


            var orderss = _entities.Order.Where(x => x.OrderDate.Year == monthCalendar1.SelectionStart.Year).Select(x => new
            {
                x.OrderDate,
                Employe = x.Employee1.SecondName + " " + x.Employee1.FirstName,
                Client = x.Client1.SecondName + " " + x.Client1.FirstName,
                SumCount = x.Specification.Sum(y => y.Count),
                Sum = x.Specification.Sum(y => y.PriceModel * y.Count),

            }).ToList();

            int? caunt = orderss.Count();
            double sum = orderss.Sum(x => x.Sum);

            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Vlad\Documents\Visual Studio 2012\Projects\StorePhone\Reports\ByEmploee\" + "Result by " + monthCalendar1.SelectionStart.Year + ".pdf", FileMode.Create));
            doc.Open();


            Paragraph paragraph = new Paragraph("Results sales of the " + monthCalendar1.SelectionStart.Year + " year by employee");
            doc.Add(paragraph);
            doc.Add(new Paragraph("     "));

            PdfPTable table = new PdfPTable(2);

            PdfPCell cell = new PdfPCell(new Phrase(" Total sales :",
              new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
              iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));

            cell.BackgroundColor = new BaseColor(Color.Wheat);
            cell.Padding = 5;
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;

            table.AddCell(cell);
            table.AddCell("Count order, units");
            table.AddCell("Total, $");

            PdfPCell cell1 = new PdfPCell(new Phrase(caunt.ToString()));
            cell1.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

            table.AddCell(cell1);

            PdfPCell cell3 = new PdfPCell(new Phrase(sum.ToString()));
            cell3.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell3.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell3);


            doc.Add(table);
            doc.Add(new Paragraph("     "));
            doc.Add(new Paragraph("Detailed annual report..."));
            doc.Add(new Paragraph("     "));

            PdfPTable table2 = new PdfPTable(3);

            PdfPCell c = new PdfPCell(new Phrase("Report sales for the year by employee: ",
              new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16,
              iTextSharp.text.Font.NORMAL, new BaseColor(Color.Orange))));
            c.Colspan = 5;
            table2.AddCell(c);
 
            table2.AddCell("Employee:");
          
            table2.AddCell("Caunt phones:");
            table2.AddCell("Total cost:");

            foreach (var order in orders)
            {
                Employee employee = _entities.Employee.First(x => x.ID == order.Key);

                table2.AddCell(employee.SecondName +" " +employee.FirstName);
                table2.AddCell(order.Sum(x => x.Count).ToString());
                table2.AddCell(order.Sum(x => x.PriceModel*x.Count).ToString());

                /*
                table2.AddCell(order.OrderDate.ToShortDateString());
                table2.AddCell(order.Employe);
                table2.AddCell(order.Client);
                table2.AddCell(order.SumCount.ToString());
                table2.AddCell(order.Sum.ToString());*/
            }

            doc.Add(table2);
            doc.Close();

            MessageBox.Show("Отчет  успешно сформирован!\n Количество заказов : " + caunt + "\nОбщая сумма: " + sum + "$");

        }
    

    }
}
