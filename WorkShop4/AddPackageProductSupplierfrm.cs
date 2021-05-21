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
    public partial class AddPackageProductSupplierfrm : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();

        public PackagesProductsSupplier currentPPS { get; set; }

        public bool buttonstatusadd { get; set; }

        public AddPackageProductSupplierfrm()
        {
            InitializeComponent();
        }

        private PackagesProductsSupplier pps = null;

        private void AddPackageProductSupplierfrm_Load(object sender, EventArgs e)
        {
            //if (buttonstatusadd == true)
            //{
            //    IDPackagetxt.Text = " ";
            //    IDProductSuppliertxt.Text = " ";
            //}

            //else
            //{
            //    IDPackagetxt.Enabled = false;
            //    IDProductSuppliertxt.Text = Convert.ToString(currentPPS.ProductSupplierId);

            //}
        }
    }
}
