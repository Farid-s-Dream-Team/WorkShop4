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
    public partial class ProductSupplierFrm : Form
    {
        TravelExpertsContext context;
        ProductsSupplier currentPs;

        public bool buttonstattadd = false;
        public bool viewProductsSupplierscs = false;
        
        public ProductSupplierFrm()
        {
            InitializeComponent();
        }
        private void Display()
        {
            context = new TravelExpertsContext();
            productSupplierGrid.AutoGenerateColumns = true;
            productSupplierGrid.DataSource = context.ProductsSuppliers.ToList();
        }
        private void ProductSupplierFrm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductSupplierFrm addProductSupplier = new ProductSupplierFrm();
            addProductSupplier.viewProductsSupplierscs = viewProductsSupplierscs;
            addProductSupplier.ShowDialog();
            Display();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            ProductSupplierFrm addProductSupplier = new ProductSupplierFrm();
            addProductSupplier.currentPs = currentPs;
            addProductSupplier.ShowDialog();
            context.SaveChanges();
            Display();
        }

      

        private void removeBtn_Click(object sender, EventArgs e)
        {
            context.ProductsSuppliers.Remove(currentPs);
            context.SaveChanges();
            Display();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productSupplierGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productSupplierGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productSupplierGrid.SelectedRows.Count > 0)
            {
                currentPs = (ProductsSupplier)productSupplierGrid.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
