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
    public partial class AddProductSupplierFrm : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();
        public ProductsSupplier currentProductSupplier { get; set; }

        private ProductsSupplier productsupplier = null;
        public bool AddButton { get; set; }
        public AddProductSupplierFrm()
        {
            InitializeComponent();
        }

        private void AddProductSupplierFrm_Load(object sender, EventArgs e)
        {
            if (AddButton == true) // if Add is clicked
            {
                ProdSupIDTxt.Enabled = true;
                ProdSupIDTxt.Text = "0";
                ProductIDTxt.Enabled = true;
                ProductIDTxt.Text = "0";
                SupplierIdTxt.Enabled = true;
                SupplierIdTxt.Text = "0";
            }
            else
            {
                ProdSupIDTxt.Enabled = true;
                ProdSupIDTxt.Text = currentProductSupplier.ProductSupplierId.ToString();
                ProductIDTxt.Enabled = true;
                ProductIDTxt.Text = currentProductSupplier.ProductId.ToString();
                SupplierIdTxt.Enabled = true;
                SupplierIdTxt.Text = currentProductSupplier.SupplierId.ToString();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            productsupplier = new ProductsSupplier();

            productsupplier.ProductSupplierId = Convert.ToInt32(ProdSupIDTxt.Text);
            productsupplier.ProductId = Convert.ToInt32(ProductIDTxt.Text);
            productsupplier.SupplierId = Convert.ToInt32(SupplierIdTxt.Text);

            if (AddButton == true)
            {
                context.ProductsSuppliers.Add(productsupplier);
            }
            else
            {
                context.ProductsSuppliers.Update(productsupplier);
            }
            context.SaveChanges();
            MessageBox.Show("Record inserted succesfully");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
