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
    public partial class ProductFrm : Form
    {
        TravelExpertsContext context;

        Product currentProduct;

        public bool buttonstatusadd = false;

        public bool viewpackage = false;

        public ProductFrm()
        {
            InitializeComponent();
        }

        private void Display()
        {
            context = new TravelExpertsContext();
            dataGridproduct.AutoGenerateColumns = true;
            dataGridproduct.DataSource = context.Products.ToList();
            //Display();
        }
        private void dataGridproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridproduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridproduct.SelectedRows.Count > 0)
            {
                currentProduct = (Product)dataGridproduct.SelectedRows[0].DataBoundItem;
            }
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            context = new TravelExpertsContext();
            dataGridproduct.AutoGenerateColumns = true;
            dataGridproduct.DataSource = context.Products.ToList();
            Display();
        }

        private Product product = null;

        private void addBtn_Click(object sender, EventArgs e)
        {
            buttonstatusadd = true;

            AddProductfrm addProduct = new AddProductfrm();
            addProduct.buttonstatusadd = buttonstatusadd;
            addProduct.ShowDialog();
            Display();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            context.Products.Remove(currentProduct);
            context.SaveChanges();
            Display();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            //AddProductfrm addProduct = new AddProductfrm();
            ProductFrm addProduct = new ProductFrm();
            addProduct.currentProduct = currentProduct;
            addProduct.buttonstatusadd = false;
            addProduct.ShowDialog();
            context.SaveChanges();
            Display();
        }
    }
    
}
