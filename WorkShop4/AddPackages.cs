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
    public partial class AddPackages : Form
    {
        public Package currentPackage { get; set; }
        TravelExpertsContext context = new TravelExpertsContext();
        public bool buttonStatusAdd { get; set; }

        private Package package = null;

        public AddPackages()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPackages_Load(object sender, EventArgs e)
        {
            if (buttonStatusAdd == false) //Modify Selected 
            {
                packageIDTxt.Enabled = false;
                packageIDTxt.Text = currentPackage.PackageId.ToString();
                packageNameTxt.Text = currentPackage.PkgName;
                startDateTxt.Text = currentPackage.PkgStartDate.ToString();
                endDateTxt.Text = currentPackage.PkgEndDate.ToString();
                descriptionTxt.Text = currentPackage.PkgDesc;
                basePriceTxt.Text = currentPackage.PkgBasePrice.ToString();
                commissionTxt.Text = currentPackage.PkgAgencyCommission.ToString();
            }

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            package = new Package
            {
                PackageId = Convert.ToInt32(packageIDTxt.Text),
                PkgName = packageNameTxt.Text,
                PkgStartDate = Convert.ToDateTime(startDateTxt.Text),
                PkgEndDate = Convert.ToDateTime(endDateTxt.Text),
                PkgDesc = descriptionTxt.Text,
                PkgBasePrice = Convert.ToDecimal(basePriceTxt.Text),
                PkgAgencyCommission = Convert.ToDecimal(commissionTxt.Text)

            };

            if (buttonStatusAdd == true)
            {
                context.Packages.Add(package);

            }
            else
            {
                context.Packages.Update(package);
            }

            DialogResult Save =
                MessageBox.Show(
                    $"Save this Entry:\nID: {packageIDTxt.Text}\nName: {packageNameTxt.Text}" +
                    $"\nStartDate: {startDateTxt.Text}\nEndDate: {endDateTxt.Text}" +
                    $"\nDesc: {descriptionTxt.Text}\nBasePrice: {basePriceTxt.Text}" +
                    $"\nCommission: {commissionTxt.Text}",
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

        private void goBackbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
