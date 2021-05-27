
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
            this.add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(232, 235);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 31);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(89, 235);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 31);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product Supplier ID:";
            // 
            // IDProductSuppliertxt
            // 
            this.IDProductSuppliertxt.Location = new System.Drawing.Point(204, 167);
            this.IDProductSuppliertxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDProductSuppliertxt.Name = "IDProductSuppliertxt";
            this.IDProductSuppliertxt.Size = new System.Drawing.Size(114, 27);
            this.IDProductSuppliertxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Package ID:";
            // 
            // IDPackagetxt
            // 
            this.IDPackagetxt.Location = new System.Drawing.Point(204, 115);
            this.IDPackagetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDPackagetxt.Name = "IDPackagetxt";
            this.IDPackagetxt.Size = new System.Drawing.Size(114, 27);
            this.IDPackagetxt.TabIndex = 13;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(26, 38);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(367, 28);
            this.add.TabIndex = 19;
            this.add.Text = "Add Package and Product Supplier ID";
            // 
            // AddPackageProductSupplierfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(410, 355);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDProductSuppliertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDPackagetxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label add;
    }
}