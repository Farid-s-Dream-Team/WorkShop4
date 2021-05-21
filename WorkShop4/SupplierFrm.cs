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
    public partial class SupplierFrm : Form
    {
        TravelExpertsContext context;

        Supplier currentSupplier;

        public bool clickAddButton = false;
        public SupplierFrm()
        {
            InitializeComponent();
        }

        public void Display()
        {
            context = new TravelExpertsContext();
            dataGridViewSupplier.AutoGenerateColumns = false;
            dataGridViewSupplier.DataSource = context.Suppliers.ToList();
        }

        private void SupplierFrm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            clickAddButton = true;

            AddSuppliersFrm SupplierData = new AddSuppliersFrm();
            SupplierData.AddButton = clickAddButton;
            SupplierData.ShowDialog();
            Display();
        }

        private void dataGridViewSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewSupplier.SelectedRows.Count > 0)
            {
                currentSupplier = (Supplier)dataGridViewSupplier.SelectedRows[0].DataBoundItem;
            }
        }

        private void removeSupplierBtn_Click(object sender, EventArgs e)
        {
            context.Suppliers.Remove(currentSupplier);
            context.SaveChanges();
            Display();
        }

        private void exitSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifySupplierBtn_Click(object sender, EventArgs e)
        {
            ModifySupplierFrm updateSupplier = new ModifySupplierFrm();
            updateSupplier.contextMSF = context;
            updateSupplier.currentSupplierMSF = currentSupplier;
            updateSupplier.AddButton = false;
            updateSupplier.ShowDialog();
            Display();

            //context.SaveChanges();
            //Display();
        }

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
