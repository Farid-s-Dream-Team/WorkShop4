﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop4.Models;
using Microsoft.EntityFrameworkCore;

namespace WorkShop4
{
    public partial class TravelExperts : Form
    {
        TravelExperts context;

        public bool viewpackage = false;

        public TravelExperts()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void instructionLbl_Click(object sender, EventArgs e)
        {

        }

        private void packagesBtn_Click(object sender, EventArgs e)
        {
            PackagesFrm addpackage = new PackagesFrm();
            addpackage.ShowDialog();
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            SupplierFrm SupliersData = new SupplierFrm();
            SupliersData.ShowDialog();
        }

        private void products_suppliersBtn_Click(object sender, EventArgs e)
        {
            ProductSupplierFrm ProdSup = new ProductSupplierFrm();
            ProdSup.ShowDialog();
        }
    }
}
