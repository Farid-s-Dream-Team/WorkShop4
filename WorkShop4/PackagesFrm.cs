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
    public partial class PackagesFrm : Form
    {
        TravelExpertsContext context;

        public Package currentPackage { get; set; }

        public bool viewpackage { get; set; }

        public PackagesFrm()
        {
            InitializeComponent();
        }

        public void Display()
        {
            context = new TravelExpertsContext();
            dataGridpakage.AutoGenerateColumns = true;
            dataGridpakage.DataSource = context.Packages.ToList();
        }

        private void PackagesFrm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridpakage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
