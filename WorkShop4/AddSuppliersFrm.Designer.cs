
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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name:";
            // 
            // SupplierIdTxt
            // 
            this.SupplierIdTxt.Location = new System.Drawing.Point(185, 115);
            this.SupplierIdTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SupplierIdTxt.Name = "SupplierIdTxt";
            this.SupplierIdTxt.Size = new System.Drawing.Size(114, 27);
            this.SupplierIdTxt.TabIndex = 2;
            // 
            // supNameTxt
            // 
            this.supNameTxt.Location = new System.Drawing.Point(185, 174);
            this.supNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supNameTxt.Name = "supNameTxt";
            this.supNameTxt.Size = new System.Drawing.Size(114, 27);
            this.supNameTxt.TabIndex = 3;
            this.supNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.supNameTxt_Validating);
            // 
            // saveSupplierBtn
            // 
            this.saveSupplierBtn.Location = new System.Drawing.Point(50, 233);
            this.saveSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSupplierBtn.Name = "saveSupplierBtn";
            this.saveSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.saveSupplierBtn.TabIndex = 4;
            this.saveSupplierBtn.Text = "Save";
            this.saveSupplierBtn.UseVisualStyleBackColor = true;
            this.saveSupplierBtn.Click += new System.EventHandler(this.saveSupplierBtn_Click);
            // 
            // cancelSupplierBtn
            // 
            this.cancelSupplierBtn.Location = new System.Drawing.Point(201, 233);
            this.cancelSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelSupplierBtn.Name = "cancelSupplierBtn";
            this.cancelSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.cancelSupplierBtn.TabIndex = 4;
            this.cancelSupplierBtn.Text = "Cancel";
            this.cancelSupplierBtn.UseVisualStyleBackColor = true;
            this.cancelSupplierBtn.Click += new System.EventHandler(this.cancelSupplierBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(111, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Supplier";
            // 
            // AddSuppliersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(361, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelSupplierBtn);
            this.Controls.Add(this.saveSupplierBtn);
            this.Controls.Add(this.supNameTxt);
            this.Controls.Add(this.SupplierIdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label label3;
    }
}