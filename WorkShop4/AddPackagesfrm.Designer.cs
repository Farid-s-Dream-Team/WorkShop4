
namespace WorkShop4
{
    partial class AddPackagesfrm
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
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.startDateTxt = new System.Windows.Forms.TextBox();
            this.endDateTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.commissionTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.packagebasepriceTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(248, 155);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(114, 27);
            this.IDtxt.TabIndex = 0;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(248, 209);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(252, 27);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxt_Validating);
            this.nameTxt.Validated += new System.EventHandler(this.nameTxt_Validated);
            // 
            // startDateTxt
            // 
            this.startDateTxt.Location = new System.Drawing.Point(248, 267);
            this.startDateTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startDateTxt.Name = "startDateTxt";
            this.startDateTxt.Size = new System.Drawing.Size(252, 27);
            this.startDateTxt.TabIndex = 2;
            this.startDateTxt.TextChanged += new System.EventHandler(this.startDateTxt_TextChanged);
            // 
            // endDateTxt
            // 
            this.endDateTxt.Location = new System.Drawing.Point(248, 325);
            this.endDateTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endDateTxt.Name = "endDateTxt";
            this.endDateTxt.Size = new System.Drawing.Size(252, 27);
            this.endDateTxt.TabIndex = 3;
            this.endDateTxt.Validating += new System.ComponentModel.CancelEventHandler(this.endDateTxt_Validating_1);
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(248, 384);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(407, 27);
            this.descriptionTxt.TabIndex = 4;
            this.descriptionTxt.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTxt_Validating);
            // 
            // commissionTxt
            // 
            this.commissionTxt.Location = new System.Drawing.Point(248, 491);
            this.commissionTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commissionTxt.Name = "commissionTxt";
            this.commissionTxt.Size = new System.Drawing.Size(252, 27);
            this.commissionTxt.TabIndex = 5;
            this.commissionTxt.Validating += new System.ComponentModel.CancelEventHandler(this.commissionTxt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Package Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Commission:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(248, 553);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 31);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(404, 553);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 31);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // packagebasepriceTxt
            // 
            this.packagebasepriceTxt.Location = new System.Drawing.Point(248, 441);
            this.packagebasepriceTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.packagebasepriceTxt.Name = "packagebasepriceTxt";
            this.packagebasepriceTxt.Size = new System.Drawing.Size(252, 27);
            this.packagebasepriceTxt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Package Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(293, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Add Packages";
            // 
            // AddPackagesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(736, 636);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.packagebasepriceTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commissionTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.endDateTxt);
            this.Controls.Add(this.startDateTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.IDtxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPackagesfrm";
            this.Text = "AddPackagesfrm";
            this.Load += new System.EventHandler(this.AddPackagesfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox startDateTxt;
        private System.Windows.Forms.TextBox endDateTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.TextBox commissionTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox packagebasepriceTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}