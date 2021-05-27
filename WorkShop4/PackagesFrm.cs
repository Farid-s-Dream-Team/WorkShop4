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
            dataGridpakage.AutoGenerateColumns = false;
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
                int index = dataGridpakage.SelectedCells[0].RowIndex;
                int PackageId = (int)dataGridpakage.Rows[index].Cells[0].Value;

             //   currentPackage = context.Packages.Find(PackageId);
             //   dataGridpakage.DataSource = currentPackage.PackagesProductsSuppliers.ToList();

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
            DialogResult button =
                MessageBox.Show(
                    "Are you sure that you want to remove the selected record?",
                    "Remove Item",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            if (button == DialogResult.OK)
            {
                context.Packages.Remove(currentPackage);
                context.SaveChanges();
                Display();

            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
