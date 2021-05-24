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
        TravelExpertsContext context = new TravelExpertsContext();
        //public TravelExpertsContext context { get; set; }
       
        public Product currentProduct { get; set; }
        public bool buttonstatusadd { get; set; }
        private Product product = null;

        public AddProductfrm()
        {
            InitializeComponent();
        }

        private void AddProductfrm_Load(object sender, EventArgs e)
        {
            if (buttonstatusadd == true) //User Clicked Add
            {
                IDtxt.Enabled = false;
                IDtxt.Text = "0";
                productnameTxt.Text = " ";
            }

            else  // user clicked Modify
            {
                IDtxt.Enabled = false;
                IDtxt.Text = currentProduct.ProductId.ToString();
                productnameTxt.Text = currentProduct.ProdName;
             
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            product = new Product
            {
                ProductId = Convert.ToInt32(IDtxt.Text),
                ProdName = productnameTxt.Text
            };


            if (buttonstatusadd == true)  // user clicked Add button
                context.Products.Add(product);

            else
                context.Products.Update(product);

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
