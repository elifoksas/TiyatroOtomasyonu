namespace SanatTiyatrosu
{
    partial class frmSatisListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisListele));
            this.grdSatis = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSatis
            // 
            this.grdSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatis.Location = new System.Drawing.Point(12, 12);
            this.grdSatis.Name = "grdSatis";
            this.grdSatis.RowTemplate.Height = 24;
            this.grdSatis.Size = new System.Drawing.Size(812, 409);
            this.grdSatis.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(640, 439);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(163, 58);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamSatis.Location = new System.Drawing.Point(251, 451);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(116, 31);
            this.lblToplamSatis.TabIndex = 2;
            this.lblToplamSatis.Text = "label1";
            // 
            // frmSatisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 534);
            this.Controls.Add(this.lblToplamSatis);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.grdSatis);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSatisListele";
            this.Text = "SatisListesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSatisListele_FormClosing);
            this.Load += new System.EventHandler(this.SatisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSatis;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblToplamSatis;
    }
}