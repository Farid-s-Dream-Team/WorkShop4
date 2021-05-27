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
        ProductsSupplier currentProductSupplier;
        public bool AddButton = false;
        private ProductsSupplier productsupplier = null;
        public ProductSupplierFrm()
        {
            InitializeComponent();
        }

        private void Display()
        {
            context = new TravelExpertsContext();
            dataGridProdSup.AutoGenerateColumns = false;
            dataGridProdSup.DataSource = context.ProductsSuppliers.ToList();
        }
        private void ProductSupplierFrm_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            AddButton = true;
            AddProductSupplierFrm addProdSup = new AddProductSupplierFrm ();
            addProdSup.AddButton = AddButton;
            addProdSup.ShowDialog();
            Display();
        }

        private void dataGridProdSup_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridProdSup.SelectedRows.Count > 0)
            {
                currentProductSupplier = (ProductsSupplier)dataGridProdSup.SelectedRows[0].DataBoundItem;
            }
        }

        private void modifySupplierBtn_Click(object sender, EventArgs e)
        {
            AddProductSupplierFrm modProdSup = new AddProductSupplierFrm();
            modProdSup.currentProductSupplier = currentProductSupplier;
            modProdSup.AddButton = false;
            modProdSup.ShowDialog();
            Display();
        }

        private void removeSupplierBtn_Click(object sender, EventArgs e)
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
                context.ProductsSuppliers.Remove(currentProductSupplier);
                context.SaveChanges();
                Display();
            }
        }

        private void exitSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
