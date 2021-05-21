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
    public partial class ModifySupplierFrm : Form
    {
        public TravelExpertsContext contextMSF { get; set; }
        public Supplier currentSupplierMSF { get; set; }

        public bool AddButton { get; set; }
        public ModifySupplierFrm()
        {
            InitializeComponent();
        }

        public void Display()
        {
            contextMSF = new TravelExpertsContext();
            dataGridViewModifySupplier.AutoGenerateColumns = false;
            dataGridViewModifySupplier.DataSource = contextMSF.Suppliers.ToList();

        }

        private void ModifySupplierFrm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            currentSupplierMSF.SupplierId = Convert.ToInt32(supplierIdTxt.Text);
            currentSupplierMSF.SupName = supNameTxt.Text;

            if (AddButton == true);
                contextMSF.Suppliers.Add(currentSupplierMSF);
            
            else

            dwd595+95ddd
            //supplier = new Supplier();

            //context.Suppliers.Update(supplier);
            //MessageBox.Show("Supplier details updated");

            //context.SaveChanges();
            //Display();
            //this.Close();
        }
    }
}
