
namespace WorkShop4
{
    partial class PackagesFrm
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
            this.dataGridpakage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpakage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridpakage
            // 
            this.dataGridpakage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpakage.Location = new System.Drawing.Point(51, 22);
            this.dataGridpakage.Name = "dataGridpakage";
            this.dataGridpakage.RowTemplate.Height = 25;
            this.dataGridpakage.Size = new System.Drawing.Size(570, 218);
            this.dataGridpakage.TabIndex = 0;
            this.dataGridpakage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpakage_CellContentClick);
            // 
            // PackagesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridpakage);
            this.Name = "PackagesFrm";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.PackagesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpakage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridpakage;
    }
}