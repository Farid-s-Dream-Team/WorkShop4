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
    public partial class PackProSuppMAIN : Form
    {
        TravelExpertsContext context;
        PackagesProductsSupplier item;

        public bool buttonstattadd = false;
        public PackProSuppMAIN()
        {
            InitializeComponent();
        }

        private void Display()
        {
            context = new TravelExpertsContext();
            packprodsuppGrid.AutoGenerateColumns = true;
            packprodsuppGrid.DataSource = context.PackagesProductsSuppliers.ToList();
            
        }

        private void PackProSuppMAIN_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
