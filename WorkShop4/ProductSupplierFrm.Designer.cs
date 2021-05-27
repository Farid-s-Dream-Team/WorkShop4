
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
            this.dataGridProdSup = new System.Windows.Forms.DataGridView();
            this.ProductSupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitSupplierBtn = new System.Windows.Forms.Button();
            this.removeSupplierBtn = new System.Windows.Forms.Button();
            this.modifySupplierBtn = new System.Windows.Forms.Button();
            this.addSupplierBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProdSup
            // 
            this.dataGridProdSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdSup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductSupplierId,
            this.ProductId,
            this.SupplierId});
            this.dataGridProdSup.Location = new System.Drawing.Point(57, 84);
            this.dataGridProdSup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridProdSup.Name = "dataGridProdSup";
            this.dataGridProdSup.RowHeadersWidth = 51;
            this.dataGridProdSup.RowTemplate.Height = 25;
            this.dataGridProdSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdSup.Size = new System.Drawing.Size(433, 260);
            this.dataGridProdSup.TabIndex = 0;
            this.dataGridProdSup.SelectionChanged += new System.EventHandler(this.dataGridProdSup_SelectionChanged);
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.ProductSupplierId.HeaderText = "ProductSupplierId";
            this.ProductSupplierId.MinimumWidth = 6;
            this.ProductSupplierId.Name = "ProductSupplierId";
            this.ProductSupplierId.Width = 125;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Width = 125;
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.MinimumWidth = 6;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.Width = 125;
            // 
            // exitSupplierBtn
            // 
            this.exitSupplierBtn.Location = new System.Drawing.Point(404, 381);
            this.exitSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitSupplierBtn.Name = "exitSupplierBtn";
            this.exitSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.exitSupplierBtn.TabIndex = 2;
            this.exitSupplierBtn.Text = "Go Back";
            this.exitSupplierBtn.UseVisualStyleBackColor = true;
            this.exitSupplierBtn.Click += new System.EventHandler(this.exitSupplierBtn_Click);
            // 
            // removeSupplierBtn
            // 
            this.removeSupplierBtn.Location = new System.Drawing.Point(282, 381);
            this.removeSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeSupplierBtn.Name = "removeSupplierBtn";
            this.removeSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.removeSupplierBtn.TabIndex = 4;
            this.removeSupplierBtn.Text = "&Remove";
            this.removeSupplierBtn.UseVisualStyleBackColor = true;
            this.removeSupplierBtn.Click += new System.EventHandler(this.removeSupplierBtn_Click);
            // 
            // modifySupplierBtn
            // 
            this.modifySupplierBtn.Location = new System.Drawing.Point(156, 381);
            this.modifySupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifySupplierBtn.Name = "modifySupplierBtn";
            this.modifySupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.modifySupplierBtn.TabIndex = 5;
            this.modifySupplierBtn.Text = "Modify";
            this.modifySupplierBtn.UseVisualStyleBackColor = true;
            this.modifySupplierBtn.Click += new System.EventHandler(this.modifySupplierBtn_Click);
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.Location = new System.Drawing.Point(34, 381);
            this.addSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.addSupplierBtn.TabIndex = 6;
            this.addSupplierBtn.Text = "&Add";
            this.addSupplierBtn.UseVisualStyleBackColor = true;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Suppliers";
            // 
            // ProductSupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(550, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitSupplierBtn);
            this.Controls.Add(this.removeSupplierBtn);
            this.Controls.Add(this.modifySupplierBtn);
            this.Controls.Add(this.addSupplierBtn);
            this.Controls.Add(this.dataGridProdSup);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductSupplierFrm";
            this.Text = "ProductSupplierFrm";
            this.Load += new System.EventHandler(this.ProductSupplierFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProdSup;
        private System.Windows.Forms.Button exitSupplierBtn;
        private System.Windows.Forms.Button removeSupplierBtn;
        private System.Windows.Forms.Button modifySupplierBtn;
        private System.Windows.Forms.Button addSupplierBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.Label label1;
    }
}