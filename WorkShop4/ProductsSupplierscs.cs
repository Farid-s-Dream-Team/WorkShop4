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
        public ProductsSupplier currentPs{ get; set; }
        TravelExpertsContext context = new TravelExpertsContext();
        public bool buttonStatusAdd { get; set; }

        public ProductsSupplierscs()
        {
            InitializeComponent();
        }

        private void ProductsSupplierscs_Load(object sender, EventArgs e)
        {
            if (buttonStatusAdd == false) //Modify Selected 
            {
                productSupplierIdTxt.Enabled = false;
                productSupplierIdTxt.Text = currentPs.ProductSupplierId.ToString();
                productIdTxt.Text = currentPs.ProductId.ToString();
                supplierIdTxt.Text = currentPs.SupplierId.ToString();
                productTxt.Text = currentPs.Product.ToString();
                supplierTxt.Text = currentPs.Supplier.ToString();
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            currentPs = new ProductsSupplier();
            {
                currentPs.ProductSupplierId = Convert.ToInt32(productSupplierIdTxt.Text);
                currentPs.ProductId = Convert.ToInt32(productIdTxt.Text);
                currentPs.SupplierId = Convert.ToInt32(supplierIdTxt.Text);
                currentPs.Product = productTxt.Text;
                currentPs.Supplier = supplierTxt.Text;

            };

            if (buttonStatusAdd == true)
            {
                context.ProductsSuppliers.Add(currentPs);

            }
            else
            {
                context.ProductsSuppliers.Update(currentPs);
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
