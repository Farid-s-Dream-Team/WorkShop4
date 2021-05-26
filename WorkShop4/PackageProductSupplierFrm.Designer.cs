
namespace WorkShop4
{
    partial class PackageProductSupplierFrm
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
            this.dataGridPPS = new System.Windows.Forms.DataGridView();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPPS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPPS
            // 
            this.dataGridPPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPPS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.ProductSupplierId});
            this.dataGridPPS.Location = new System.Drawing.Point(69, 29);
            this.dataGridPPS.Name = "dataGridPPS";
            this.dataGridPPS.RowTemplate.Height = 25;
            this.dataGridPPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPPS.Size = new System.Drawing.Size(421, 220);
            this.dataGridPPS.TabIndex = 1;
            // 
            // PackageId
            // 
            this.PackageId.DataPropertyName = "PackageId";
            this.PackageId.HeaderText = "PackageId";
            this.PackageId.Name = "PackageId";
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.ProductSupplierId.HeaderText = "ProductSupplierId";
            this.ProductSupplierId.Name = "ProductSupplierId";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(210, 274);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PackageProductSupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.dataGridPPS);
            this.Name = "PackageProductSupplierFrm";
            this.Text = "Package Product Supplier";
            this.Load += new System.EventHandler(this.PackageProductSupplierFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridpakage;
        private System.Windows.Forms.DataGridView dataGridPPS;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
    }
}