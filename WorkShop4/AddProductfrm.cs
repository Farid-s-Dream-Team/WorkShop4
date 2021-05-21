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
    public partial class AddProductfrm : Form

    {
        public TravelExpertsContext context { get; set; }
       
        public Product currentProduct { get; set; }

        public bool buttonstatusadd { get; set; }

        public AddProductfrm()
        {
            InitializeComponent();
        }

        private Product product = null;
        private void AddProductfrm_Load(object sender, EventArgs e)
        {
            if (buttonstatusadd == true)
            {
                IDtxt.Text = " ";
                productnameTxt.Text = " ";
            }

            else
            {
                IDtxt.Enabled = false;
                productnameTxt.Text = currentProduct.ProdName;
             
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // product = new Product();

          //  currentProduct.ProductId = Convert.ToInt32(IDtxt.Text);
            currentProduct.ProdName = productnameTxt.Text;

            if (buttonstatusadd == true)
                context.Products.Add(product);

            else

            //    context.Products.Update(product);
            context.SaveChanges();
            MessageBox.Show("Record Inserted Succefully");
            this.Close();
        }

        private void IDtxt_Validated(object sender, EventArgs e)
        {
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
