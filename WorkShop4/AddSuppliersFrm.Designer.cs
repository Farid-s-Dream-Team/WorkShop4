
namespace WorkShop4
{
    partial class AddSuppliersFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierIdTxt = new System.Windows.Forms.TextBox();
            this.supNameTxt = new System.Windows.Forms.TextBox();
            this.saveSupplierBtn = new System.Windows.Forms.Button();
            this.cancelSupplierBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name:";
            // 
            // SupplierIdTxt
            // 
            this.SupplierIdTxt.Location = new System.Drawing.Point(151, 20);
            this.SupplierIdTxt.Name = "SupplierIdTxt";
            this.SupplierIdTxt.Size = new System.Drawing.Size(100, 23);
            this.SupplierIdTxt.TabIndex = 2;
            // 
            // supNameTxt
            // 
            this.supNameTxt.Location = new System.Drawing.Point(151, 60);
            this.supNameTxt.Name = "supNameTxt";
            this.supNameTxt.Size = new System.Drawing.Size(100, 23);
            this.supNameTxt.TabIndex = 3;
            // 
            // saveSupplierBtn
            // 
            this.saveSupplierBtn.Location = new System.Drawing.Point(44, 126);
            this.saveSupplierBtn.Name = "saveSupplierBtn";
            this.saveSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.saveSupplierBtn.TabIndex = 4;
            this.saveSupplierBtn.Text = "Save";
            this.saveSupplierBtn.UseVisualStyleBackColor = true;
            this.saveSupplierBtn.Click += new System.EventHandler(this.saveSupplierBtn_Click);
            // 
            // cancelSupplierBtn
            // 
            this.cancelSupplierBtn.Location = new System.Drawing.Point(151, 126);
            this.cancelSupplierBtn.Name = "cancelSupplierBtn";
            this.cancelSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelSupplierBtn.TabIndex = 4;
            this.cancelSupplierBtn.Text = "Cancel";
            this.cancelSupplierBtn.UseVisualStyleBackColor = true;
            this.cancelSupplierBtn.Click += new System.EventHandler(this.cancelSupplierBtn_Click);
            // 
            // AddSuppliersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 187);
            this.Controls.Add(this.cancelSupplierBtn);
            this.Controls.Add(this.saveSupplierBtn);
            this.Controls.Add(this.supNameTxt);
            this.Controls.Add(this.SupplierIdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSuppliersFrm";
            this.Text = "AddSuppliersFrm";
            this.Load += new System.EventHandler(this.AddSuppliersFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SupplierIdTxt;
        private System.Windows.Forms.TextBox supNameTxt;
        private System.Windows.Forms.Button saveSupplierBtn;
        private System.Windows.Forms.Button cancelSupplierBtn;
    }
}