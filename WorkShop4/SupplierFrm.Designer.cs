
namespace WorkShop4
{
    partial class SupplierFrm
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
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSupplierBtn = new System.Windows.Forms.Button();
            this.modifySupplierBtn = new System.Windows.Forms.Button();
            this.removeSupplierBtn = new System.Windows.Forms.Button();
            this.exitSupplierBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupName});
            this.dataGridViewSupplier.Location = new System.Drawing.Point(103, 106);
            this.dataGridViewSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowHeadersWidth = 51;
            this.dataGridViewSupplier.RowTemplate.Height = 25;
            this.dataGridViewSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(305, 301);
            this.dataGridViewSupplier.TabIndex = 0;
            this.dataGridViewSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellContentClick);
            this.dataGridViewSupplier.SelectionChanged += new System.EventHandler(this.dataGridViewSupplier_SelectionChanged);
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.MinimumWidth = 6;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            this.SupplierId.Width = 125;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "SupName";
            this.SupName.MinimumWidth = 6;
            this.SupName.Name = "SupName";
            this.SupName.Width = 125;
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addSupplierBtn.Location = new System.Drawing.Point(34, 452);
            this.addSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.addSupplierBtn.TabIndex = 1;
            this.addSupplierBtn.Text = "&Add";
            this.addSupplierBtn.UseVisualStyleBackColor = true;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // modifySupplierBtn
            // 
            this.modifySupplierBtn.Location = new System.Drawing.Point(147, 452);
            this.modifySupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifySupplierBtn.Name = "modifySupplierBtn";
            this.modifySupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.modifySupplierBtn.TabIndex = 1;
            this.modifySupplierBtn.Text = "Modify";
            this.modifySupplierBtn.UseVisualStyleBackColor = true;
            this.modifySupplierBtn.Click += new System.EventHandler(this.modifySupplierBtn_Click);
            // 
            // removeSupplierBtn
            // 
            this.removeSupplierBtn.Location = new System.Drawing.Point(260, 452);
            this.removeSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeSupplierBtn.Name = "removeSupplierBtn";
            this.removeSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.removeSupplierBtn.TabIndex = 1;
            this.removeSupplierBtn.Text = "&Remove";
            this.removeSupplierBtn.UseVisualStyleBackColor = true;
            this.removeSupplierBtn.Click += new System.EventHandler(this.removeSupplierBtn_Click);
            // 
            // exitSupplierBtn
            // 
            this.exitSupplierBtn.Location = new System.Drawing.Point(380, 452);
            this.exitSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitSupplierBtn.Name = "exitSupplierBtn";
            this.exitSupplierBtn.Size = new System.Drawing.Size(86, 31);
            this.exitSupplierBtn.TabIndex = 1;
            this.exitSupplierBtn.Text = "Go Back";
            this.exitSupplierBtn.UseVisualStyleBackColor = true;
            this.exitSupplierBtn.Click += new System.EventHandler(this.exitSupplierBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suppliers";
            // 
            // SupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(514, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitSupplierBtn);
            this.Controls.Add(this.removeSupplierBtn);
            this.Controls.Add(this.modifySupplierBtn);
            this.Controls.Add(this.addSupplierBtn);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupplierFrm";
            this.Text = "SupplierFrm";
            this.Load += new System.EventHandler(this.SupplierFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.Button addSupplierBtn;
        private System.Windows.Forms.Button modifySupplierBtn;
        private System.Windows.Forms.Button removeSupplierBtn;
        private System.Windows.Forms.Button exitSupplierBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.Label label1;
    }
}