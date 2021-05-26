
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
            this.button4 = new System.Windows.Forms.Button();
            this.exitSupplierBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupName});
            this.dataGridViewSupplier.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowTemplate.Height = 25;
            this.dataGridViewSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(775, 221);
            this.dataGridViewSupplier.TabIndex = 0;
            this.dataGridViewSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellContentClick);
            this.dataGridViewSupplier.SelectionChanged += new System.EventHandler(this.dataGridViewSupplier_SelectionChanged);
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "SupName";
            this.SupName.Name = "SupName";
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.Location = new System.Drawing.Point(38, 290);
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.addSupplierBtn.TabIndex = 1;
            this.addSupplierBtn.Text = "&Add";
            this.addSupplierBtn.UseVisualStyleBackColor = true;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // modifySupplierBtn
            // 
            this.modifySupplierBtn.Location = new System.Drawing.Point(150, 290);
            this.modifySupplierBtn.Name = "modifySupplierBtn";
            this.modifySupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.modifySupplierBtn.TabIndex = 1;
            this.modifySupplierBtn.Text = "Modify";
            this.modifySupplierBtn.UseVisualStyleBackColor = true;
            this.modifySupplierBtn.Click += new System.EventHandler(this.modifySupplierBtn_Click);
            // 
            // removeSupplierBtn
            // 
            this.removeSupplierBtn.Location = new System.Drawing.Point(253, 290);
            this.removeSupplierBtn.Name = "removeSupplierBtn";
            this.removeSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.removeSupplierBtn.TabIndex = 1;
            this.removeSupplierBtn.Text = "&Remove";
            this.removeSupplierBtn.UseVisualStyleBackColor = true;
            this.removeSupplierBtn.Click += new System.EventHandler(this.removeSupplierBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(359, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // exitSupplierBtn
            // 
            this.exitSupplierBtn.Location = new System.Drawing.Point(359, 290);
            this.exitSupplierBtn.Name = "exitSupplierBtn";
            this.exitSupplierBtn.Size = new System.Drawing.Size(75, 23);
            this.exitSupplierBtn.TabIndex = 1;
            this.exitSupplierBtn.Text = "Exit";
            this.exitSupplierBtn.UseVisualStyleBackColor = true;
            this.exitSupplierBtn.Click += new System.EventHandler(this.exitSupplierBtn_Click);
            // 
            // SupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitSupplierBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.removeSupplierBtn);
            this.Controls.Add(this.modifySupplierBtn);
            this.Controls.Add(this.addSupplierBtn);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Name = "SupplierFrm";
            this.Text = "SupplierFrm";
            this.Load += new System.EventHandler(this.SupplierFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.Button addSupplierBtn;
        private System.Windows.Forms.Button modifySupplierBtn;
        private System.Windows.Forms.Button removeSupplierBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button exitSupplierBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
    }
}