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
    public partial class PackageProductSupplierFrm : Form
    {
        TravelExpertsContext context;

        PackagesProductsSupplier currentPPS;

        public bool buttonstatusadd = false;

        public bool viewPPS = false;

        public PackageProductSupplierFrm()
        {
            InitializeComponent();
        }

        private void Display()
        {
            context = new TravelExpertsContext();
            dataGridPPS.AutoGenerateColumns = true;
            dataGridPPS.DataSource = context.PackagesProductsSuppliers.ToList();
        }

        private void PackageProductSupplierFrm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            context.PackagesProductsSuppliers.Remove(currentPPS);
            context.SaveChanges();
            Display();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
