using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop4.Models;


namespace WorkShop4
{
    public partial class AddSuppliersFrm : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();
        Supplier supplier { get; set; }
       
        public AddSuppliersFrm()
        {
            InitializeComponent();
        }

        //private Supplier supplier;

        private void saveSupplierBtn_Click(object sender, EventArgs e)
        {
            supplier = new Supplier();

            supplier.SupplierId = Convert.ToInt32(SupplierIdTxt.Text);
            supplier.SupName = supNameTxt.Text;

            context.Suppliers.Add(supplier);
            MessageBox.Show("Supplier added");

            context.SaveChanges();
            
            this.Close();
        }

        private void cancelSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSuppliersFrm_Load(object sender, EventArgs e)
        {
       
        }

    }
}
