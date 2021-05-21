
namespace WorkShop4
{
    partial class ProductSupplierFrm
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
            this.productSupplierGrid = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productSupplierGrid
            // 
            this.productSupplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSupplierGrid.Location = new System.Drawing.Point(43, 30);
            this.productSupplierGrid.Name = "productSupplierGrid";
            this.productSupplierGrid.RowHeadersWidth = 51;
            this.productSupplierGrid.RowTemplate.Height = 29;
            this.productSupplierGrid.Size = new System.Drawing.Size(671, 235);
            this.productSupplierGrid.TabIndex = 1;
            this.productSupplierGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productSupplierGrid_CellContentClick);
            this.productSupplierGrid.SelectionChanged += new System.EventHandler(this.productSupplierGrid_SelectionChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(72, 331);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 29);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(227, 331);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(94, 29);
            this.modifyBtn.TabIndex = 3;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(396, 331);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(94, 29);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(553, 331);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 29);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ProductSupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.productSupplierGrid);
            this.Name = "ProductSupplierFrm";
            this.Text = "ProductSupplierFrm";
            this.Load += new System.EventHandler(this.ProductSupplierFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productSupplierGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}