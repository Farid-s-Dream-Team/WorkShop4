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

namespace WorkShop4
{
    public partial class AddPackagesfrm : Form
    {
        TravelExpertsContext context = new TravelExpertsContext();

        public Package currentPackage { get; set; }
        private Package package = null;
                
        public bool buttonstatadd { get; set; }

        public AddPackagesfrm()
        {
            InitializeComponent();
        }


        private void AddPackagesfrm_Load(object sender, EventArgs e)

        {
            //package = new Package();

            if (buttonstatadd == true) //user clicked Add
            {
                IDtxt.Enabled = false;
                IDtxt.Text = "0";
                nameTxt.Text = " ";
                startDateTxt.Text = " ";
                endDateTxt.Text = " ";
                descriptionTxt.Text = " ";
                packagebasepriceTxt.Text = " ";
                commissionTxt.Text = " ";

            }

            else // user clicked modify
            {
                IDtxt.Enabled = false;
                IDtxt.Text = currentPackage.PackageId.ToString();
                nameTxt.Text = currentPackage.PkgName;
                startDateTxt.Text = currentPackage.PkgStartDate.ToString();
                endDateTxt.Text = currentPackage.PkgEndDate.ToString();
                descriptionTxt.Text = currentPackage.PkgDesc;
                packagebasepriceTxt.Text = currentPackage.PkgBasePrice.ToString();
                commissionTxt.Text = currentPackage.PkgAgencyCommission.ToString();

            }


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            package = new Package();

            package.PackageId = Convert.ToInt32(IDtxt.Text);
            package.PkgName = nameTxt.Text;
            package.PkgStartDate = Convert.ToDateTime(startDateTxt.Text);
            package.PkgEndDate = Convert.ToDateTime(endDateTxt.Text);
            package.PkgDesc = descriptionTxt.Text;
            package.PkgBasePrice = Convert.ToDecimal(packagebasepriceTxt.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(commissionTxt.Text);

            if (buttonstatadd == true) //add a package

                context.Packages.Add(package);

            else  //modify a package
                context.Packages.Update(package);

            context.SaveChanges();
            MessageBox.Show("Record Inserted Succefully");
            this.Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
