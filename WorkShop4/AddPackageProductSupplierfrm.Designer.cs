
namespace WorkShop4
{
    partial class AddPackageProductSupplierfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDProductSuppliertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDPackagetxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(160, 115);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(68, 115);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Supplier ID:";
            // 
            // IDProductSuppliertxt
            // 
            this.IDProductSuppliertxt.Location = new System.Drawing.Point(135, 76);
            this.IDProductSuppliertxt.Name = "IDProductSuppliertxt";
            this.IDProductSuppliertxt.Size = new System.Drawing.Size(100, 23);
            this.IDProductSuppliertxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Package ID:";
            // 
            // IDPackagetxt
            // 
            this.IDPackagetxt.Location = new System.Drawing.Point(135, 24);
            this.IDPackagetxt.Name = "IDPackagetxt";
            this.IDPackagetxt.Size = new System.Drawing.Size(100, 23);
            this.IDPackagetxt.TabIndex = 13;
            // 
            // AddPackageProductSupplierfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 232);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDProductSuppliertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDPackagetxt);
            this.Name = "AddPackageProductSupplierfrm";
            this.Text = "AddPackageProductSupplierfrm";
            this.Load += new System.EventHandler(this.AddPackageProductSupplierfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDProductSuppliertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDPackagetxt;
    }
}