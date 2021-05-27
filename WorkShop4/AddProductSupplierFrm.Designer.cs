
namespace WorkShop4
{
    partial class AddProductSupplierFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierIdTxt = new System.Windows.Forms.TextBox();
            this.ProductIDTxt = new System.Windows.Forms.TextBox();
            this.ProdSupIDTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Supplier ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Supplier ID:";
            // 
            // SupplierIdTxt
            // 
            this.SupplierIdTxt.Location = new System.Drawing.Point(218, 202);
            this.SupplierIdTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SupplierIdTxt.Name = "SupplierIdTxt";
            this.SupplierIdTxt.Size = new System.Drawing.Size(114, 27);
            this.SupplierIdTxt.TabIndex = 10;
            // 
            // ProductIDTxt
            // 
            this.ProductIDTxt.Location = new System.Drawing.Point(218, 145);
            this.ProductIDTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductIDTxt.Name = "ProductIDTxt";
            this.ProductIDTxt.Size = new System.Drawing.Size(114, 27);
            this.ProductIDTxt.TabIndex = 9;
            // 
            // ProdSupIDTxt
            // 
            this.ProdSupIDTxt.Location = new System.Drawing.Point(218, 90);
            this.ProdSupIDTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProdSupIDTxt.Name = "ProdSupIDTxt";
            this.ProdSupIDTxt.Size = new System.Drawing.Size(114, 27);
            this.ProdSupIDTxt.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(218, 272);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 31);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(82, 272);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 31);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(82, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Add Product Supplier";
            // 
            // AddProductSupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(395, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplierIdTxt);
            this.Controls.Add(this.ProductIDTxt);
            this.Controls.Add(this.ProdSupIDTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddProductSupplierFrm";
            this.Text = "AddProductSupplierFrm";
            this.Load += new System.EventHandler(this.AddProductSupplierFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SupplierIdTxt;
        private System.Windows.Forms.TextBox ProductIDTxt;
        private System.Windows.Forms.TextBox ProdSupIDTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
    }
}