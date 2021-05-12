namespace SanatTiyatrosu
{
    partial class frmSalonEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalonEkle));
            this.lblSalonAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtSalonAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnSalonEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalonAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.Appearance.Options.UseFont = true;
            this.lblSalonAdi.Location = new System.Drawing.Point(95, 61);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(120, 22);
            this.lblSalonAdi.TabIndex = 0;
            this.lblSalonAdi.Text = "Salon Adı:";
            // 
            // txtSalonAdi
            // 
            this.txtSalonAdi.Location = new System.Drawing.Point(211, 58);
            this.txtSalonAdi.Name = "txtSalonAdi";
            this.txtSalonAdi.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalonAdi.Properties.Appearance.Options.UseFont = true;
            this.txtSalonAdi.Size = new System.Drawing.Size(209, 28);
            this.txtSalonAdi.TabIndex = 1;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.Appearance.Options.UseFont = true;
            this.btnSalonEkle.Location = new System.Drawing.Point(238, 111);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(144, 56);
            this.btnSalonEkle.TabIndex = 2;
            this.btnSalonEkle.Text = "Ekle";
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // frmSalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 238);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.txtSalonAdi);
            this.Controls.Add(this.lblSalonAdi);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSalonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Salon Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalonEkle_FormClosing);
            
            ((System.ComponentModel.ISupportInitialize)(this.txtSalonAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSalonAdi;
        private DevExpress.XtraEditors.TextEdit txtSalonAdi;
        private DevExpress.XtraEditors.SimpleButton btnSalonEkle;
    }
}