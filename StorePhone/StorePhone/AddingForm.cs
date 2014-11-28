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
    public partial class AddingForm : Form
    {

        StorePhoneEntities _entities = new StorePhoneEntities();

        public AddingForm()
        {
            InitializeComponent();
        }

        private void AddingForm_Load(object sender, EventArgs e)
        {
          
        }

        private void AddClient()
        {
           
             Client client = new Client()
             {
                 SecondName = textBox1.Text,
                 FirstName = textBox2.Text,
                 PassportData = textBox3.Text,
                 Street = textBox4.Text,
                 City = textBox5.Text
             };
             
            _entities.Client.Add(client);
            _entities.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClient();
        }


    }


}
