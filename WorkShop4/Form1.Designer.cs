
namespace WorkShop4
{
    partial class TravelExperts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.packagesBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.products_suppliersBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.pack_prod_suppBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // packagesBtn
            // 
            this.packagesBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.packagesBtn.Location = new System.Drawing.Point(215, 103);
            this.packagesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.packagesBtn.Name = "packagesBtn";
            this.packagesBtn.Size = new System.Drawing.Size(144, 53);
            this.packagesBtn.TabIndex = 1;
            this.packagesBtn.Text = "Packages";
            this.packagesBtn.UseVisualStyleBackColor = false;
            this.packagesBtn.Click += new System.EventHandler(this.packagesBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.productsBtn.Location = new System.Drawing.Point(215, 184);
            this.productsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(144, 53);
            this.productsBtn.TabIndex = 2;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // products_suppliersBtn
            // 
            this.products_suppliersBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.products_suppliersBtn.Location = new System.Drawing.Point(215, 272);
            this.products_suppliersBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.products_suppliersBtn.Name = "products_suppliersBtn";
            this.products_suppliersBtn.Size = new System.Drawing.Size(144, 53);
            this.products_suppliersBtn.TabIndex = 3;
            this.products_suppliersBtn.Text = " Products Suppliers";
            this.products_suppliersBtn.UseVisualStyleBackColor = false;
            this.products_suppliersBtn.Click += new System.EventHandler(this.products_suppliersBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.suppliersBtn.Location = new System.Drawing.Point(215, 362);
            this.suppliersBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(144, 53);
            this.suppliersBtn.TabIndex = 4;
            this.suppliersBtn.Text = "Suppliers";
            this.suppliersBtn.UseVisualStyleBackColor = false;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // pack_prod_suppBtn
            // 
            this.pack_prod_suppBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pack_prod_suppBtn.Location = new System.Drawing.Point(215, 451);
            this.pack_prod_suppBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pack_prod_suppBtn.Name = "pack_prod_suppBtn";
            this.pack_prod_suppBtn.Size = new System.Drawing.Size(144, 53);
            this.pack_prod_suppBtn.TabIndex = 5;
            this.pack_prod_suppBtn.Text = "Packages Products Suppliers";
            this.pack_prod_suppBtn.UseVisualStyleBackColor = false;
            this.pack_prod_suppBtn.Click += new System.EventHandler(this.pack_prod_suppBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.exitBtn.Location = new System.Drawing.Point(215, 530);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(144, 57);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.instructionLbl.Location = new System.Drawing.Point(47, 27);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(521, 50);
            this.instructionLbl.TabIndex = 7;
            this.instructionLbl.Text = "Choose A Database to Access";
            this.instructionLbl.Click += new System.EventHandler(this.instructionLbl_Click);
            // 
            // TravelExperts
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(611, 600);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.pack_prod_suppBtn);
            this.Controls.Add(this.suppliersBtn);
            this.Controls.Add(this.products_suppliersBtn);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.packagesBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TravelExperts";
            this.Text = "Travel Experts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button packagesBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button products_suppliersBtn;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button pack_prod_suppBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label instructionLbl;
    }
}

