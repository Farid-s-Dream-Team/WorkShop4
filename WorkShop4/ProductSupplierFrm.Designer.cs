
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
            this.button4 = new System.Windows.Forms.Button();
            this.removeSupplierBtn = new System.Windows.Forms.Button();
            this.modifySupplierBtn = new System.Windows.Forms.Button();
            this.addSupplierBtn = new System.Windows.Forms.Button();
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
            this.dataGridProdSup.Location = new System.Drawing.Point(12, 6);
            this.dataGridProdSup.Name = "dataGridProdSup";
            this.dataGridProdSup.RowTemplate.Height = 25;
            this.dataGridProdSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdSup.Size = new System.Drawing.Size(448, 150);
            this.dataGridProdSup.TabIndex = 0;
            this.dataGridProdSup.SelectionChanged += new System.EventHandler(this.dataGridProdSup_SelectionChanged);
            // 
            // ProductSupplierId
            // 
            this.ProductSupplierId.DataPropertyName = "ProductSupplierId";
            this.ProductSupplierId.HeaderText = "ProductSupplierId";
            this.ProductSupplierId.Name = "ProductSupplierId";
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.Name = "SupplierId";
            // 
            // exitSupplierBtn
            // 
            this.exitSupplierBtn.Location = new System.Drawing.Point(354, 188);
            this.exitSupplierBtn.Name = "exitSupplierBtn";
            this.exitSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.exitSupplierBtn.TabIndex = 2;
            this.exitSupplierBtn.Text = "Exit";
            this.exitSupplierBtn.UseVisualStyleBackColor = true;
            this.exitSupplierBtn.Click += new System.EventHandler(this.exitSupplierBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // removeSupplierBtn
            // 
            this.removeSupplierBtn.Location = new System.Drawing.Point(248, 188);
            this.removeSupplierBtn.Name = "removeSupplierBtn";
            this.removeSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.removeSupplierBtn.TabIndex = 4;
            this.removeSupplierBtn.Text = "&Remove";
            this.removeSupplierBtn.UseVisualStyleBackColor = true;
            this.removeSupplierBtn.Click += new System.EventHandler(this.removeSupplierBtn_Click);
            // 
            // modifySupplierBtn
            // 
            this.modifySupplierBtn.Location = new System.Drawing.Point(145, 188);
            this.modifySupplierBtn.Name = "modifySupplierBtn";
            this.modifySupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.modifySupplierBtn.TabIndex = 5;
            this.modifySupplierBtn.Text = "Modify";
            this.modifySupplierBtn.UseVisualStyleBackColor = true;
            this.modifySupplierBtn.Click += new System.EventHandler(this.modifySupplierBtn_Click);
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.Location = new System.Drawing.Point(33, 188);
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.addSupplierBtn.TabIndex = 6;
            this.addSupplierBtn.Text = "&Add";
            this.addSupplierBtn.UseVisualStyleBackColor = true;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // ProductSupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 262);
            this.Controls.Add(this.exitSupplierBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.removeSupplierBtn);
            this.Controls.Add(this.modifySupplierBtn);
            this.Controls.Add(this.addSupplierBtn);
            this.Controls.Add(this.dataGridProdSup);
            this.Name = "ProductSupplierFrm";
            this.Text = "ProductSupplierFrm";
            this.Load += new System.EventHandler(this.ProductSupplierFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProdSup;
        private System.Windows.Forms.Button exitSupplierBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button removeSupplierBtn;
        private System.Windows.Forms.Button modifySupplierBtn;
        private System.Windows.Forms.Button addSupplierBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
    }
}