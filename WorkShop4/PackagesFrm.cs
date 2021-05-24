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

        Package currentPackage;

        public bool buttonstatadd = false;

        public PackagesFrm()
        {
            InitializeComponent();
        }

        private void Display()
        {
            context = new TravelExpertsContext();
            dataGridpakage.AutoGenerateColumns = true;
            dataGridpakage.DataSource = context.Packages.ToList();
        }

        public void PackagesFrm_Load(object sender, EventArgs e)
        {
            //context = new TravelExpertsContext();
            //dataGridpakage.AutoGenerateColumns = true;
            //dataGridpakage.DataSource = context.Packages.ToList();
            Display();
            
        }

        private Package package = null;
        
        private void dataGridpakage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridpakage_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridpakage.SelectedRows.Count > 0)
            {
                currentPackage = (Package)dataGridpakage.SelectedRows[0].DataBoundItem;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            buttonstatadd = true;
            AddPackagesfrm addPackage = new AddPackagesfrm();
            addPackage.buttonstatadd = buttonstatadd;
            addPackage.ShowDialog();
            Display();
        }


        private void modifyBtn_Click(object sender, EventArgs e)
        {
            AddPackagesfrm addPackage = new AddPackagesfrm();
            //PackagesFrm addPackage = new PackagesFrm();

            addPackage.currentPackage = currentPackage;
            addPackage.buttonstatadd = false;
            addPackage.ShowDialog();
            //context.SaveChanges();
            Display();
        }


        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            context.Packages.Remove(currentPackage);
            context.SaveChanges();
            Display();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
