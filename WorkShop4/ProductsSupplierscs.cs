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
    public partial class ProductsSupplierscs : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();
        public ProductsSupplier currentProductSupplier{ get; set; }

        private ProductsSupplier productsupplier = null;
        public bool buttonStatusAdd { get; set; }

        public ProductsSupplierscs()
        {
            InitializeComponent();
        }

        private void ProductsSupplierscs_Load(object sender, EventArgs e)
        {
            if (buttonStatusAdd == true) //Modify Selected 
            {
                productSupplierIdTxt.Enabled = false;
                productSupplierIdTxt.Text = "0";
                productSupplierIdTxt.Text = "";
                productIdTxt.Text = "";
                supplierIdTxt.Text = "";
                productTxt.Text = "";
                supplierTxt.Text = "";
            }

            else
            {
                productSupplierIdTxt.Enabled = false;
                productSupplierIdTxt.Text = currentProductSupplier.ProductSupplierId.ToString();
                productIdTxt.Text = currentProductSupplier.ProductId.ToString();
                supplierIdTxt.Text = currentProductSupplier.SupplierId.ToString();
                productTxt.Text = currentProductSupplier.Product.ToString();
                supplierTxt.Text = currentProductSupplier.Supplier.ToString();
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            productsupplier = new ProductsSupplier();
            {
                productsupplier.ProductSupplierId = Convert.ToInt32(productSupplierIdTxt.Text);
                productsupplier.ProductId = Convert.ToInt32(productIdTxt.Text);
                productsupplier.SupplierId = Convert.ToInt32(supplierIdTxt.Text);
                //productsupplier.Product = productTxt.Text,
                //productsupplier.Supplier = supplierTxt.Text;

            };

            if (buttonStatusAdd == true)
            {
                context.ProductsSuppliers.Add(productsupplier);

            }
            else
            {
                context.ProductsSuppliers.Update(productsupplier);
            }

            DialogResult Save =
                MessageBox.Show(
                    $"Save this Entry:\nID: {productSupplierIdTxt.Text}\nName: {productIdTxt.Text}" +
                    $"\nStartDate: {supplierIdTxt.Text}\nEndDate: {productTxt.Text}" +
                    $"\nDesc: {supplierTxt.Text}",
                    "Confirm Entry",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            if (Save == DialogResult.OK)
            {
                context.SaveChanges();
                Close();
            }

        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            {
                Close();
            }
        }
    }
}
