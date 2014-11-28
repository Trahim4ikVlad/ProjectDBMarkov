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
    public partial class EditSpecForm : Form
    {
        public  int OrderId { get; set; }
        StorePhoneEntities _entieties = new StorePhoneEntities();
        public IList<Specification> specifications = new List<Specification>(); 

        public EditSpecForm()
        {
            InitializeComponent();
   
        }

        private void EditSpecForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storePhoneDataSet3.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter1.Fill(this.storePhoneDataSet3.Model);


            this.specificationDataGridView.DataSource = _entieties.Specification.Where(x => x.OrderId == OrderId).Select(x => new
            {

                model = x.Model.Model1,
                price = x.PriceModel,
                count = x.Count

            }).ToList();

        }

    }
}
