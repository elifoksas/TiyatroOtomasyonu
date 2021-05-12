namespace SanatTiyatrosu
{
    partial class frmSeansEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeansEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblOyun = new DevExpress.XtraEditors.LabelControl();
            this.lblSalon = new DevExpress.XtraEditors.LabelControl();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.lblSeans = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.dateTarih = new DevExpress.XtraEditors.DateEdit();
            this.timeSeans = new DevExpress.XtraEditors.TimeEdit();
            this.cmbOyun = new System.Windows.Forms.ComboBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.tiyatro = new SanatTiyatrosu.tiyatro();
            this.seansBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansBilgileriTableAdapter = new SanatTiyatrosu.tiyatroTableAdapters.SeansBilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiyatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 0;
            // 
            // lblOyun
            // 
            this.lblOyun.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyun.Appearance.Options.UseFont = true;
            this.lblOyun.Location = new System.Drawing.Point(127, 76);
            this.lblOyun.Name = "lblOyun";
            this.lblOyun.Size = new System.Drawing.Size(60, 22);
            this.lblOyun.TabIndex = 1;
            this.lblOyun.Text = "Oyun:";
            // 
            // lblSalon
            // 
            this.lblSalon.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalon.Appearance.Options.UseFont = true;
            this.lblSalon.Location = new System.Drawing.Point(115, 142);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(72, 22);
            this.lblSalon.TabIndex = 3;
            this.lblSalon.Text = "Salon:";
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Location = new System.Drawing.Point(115, 210);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(72, 22);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblSeans
            // 
            this.lblSeans.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeans.Appearance.Options.UseFont = true;
            this.lblSeans.Location = new System.Drawing.Point(115, 276);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(72, 22);
            this.lblSeans.TabIndex = 7;
            this.lblSeans.Text = "Seans:";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Location = new System.Drawing.Point(193, 343);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(212, 56);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dateTarih
            // 
            this.dateTarih.EditValue = null;
            this.dateTarih.Location = new System.Drawing.Point(193, 211);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTarih.Properties.Appearance.Options.UseFont = true;
            this.dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarih.Size = new System.Drawing.Size(212, 24);
            this.dateTarih.TabIndex = 10;
            // 
            // timeSeans
            // 
            this.timeSeans.EditValue = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.timeSeans.Location = new System.Drawing.Point(193, 277);
            this.timeSeans.Name = "timeSeans";
            this.timeSeans.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeSeans.Properties.Appearance.Options.UseFont = true;
            this.timeSeans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSeans.Size = new System.Drawing.Size(212, 24);
            this.timeSeans.TabIndex = 11;
            // 
            // cmbOyun
            // 
            this.cmbOyun.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOyun.FormattingEnabled = true;
            this.cmbOyun.Location = new System.Drawing.Point(193, 77);
            this.cmbOyun.Name = "cmbOyun";
            this.cmbOyun.Size = new System.Drawing.Size(212, 25);
            this.cmbOyun.TabIndex = 12;
            // 
            // cmbSalon
            // 
            this.cmbSalon.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(193, 143);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(212, 25);
            this.cmbSalon.TabIndex = 13;
            // 
            // tiyatro
            // 
            this.tiyatro.DataSetName = "tiyatro";
            this.tiyatro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seansBilgileriBindingSource
            // 
            this.seansBilgileriBindingSource.DataMember = "SeansBilgileri";
            this.seansBilgileriBindingSource.DataSource = this.tiyatro;
            // 
            // seansBilgileriTableAdapter
            // 
            this.seansBilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 462);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.cmbOyun);
            this.Controls.Add(this.timeSeans);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblSeans);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSalon);
            this.Controls.Add(this.lblOyun);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSeansEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeansEkle_FormClosing);
            this.Load += new System.EventHandler(this.frmSeansEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiyatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgileriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblOyun;
        private DevExpress.XtraEditors.LabelControl lblSalon;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.LabelControl lblSeans;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private DevExpress.XtraEditors.TimeEdit timeSeans;
        private System.Windows.Forms.ComboBox cmbOyun;
        private System.Windows.Forms.ComboBox cmbSalon;
        private tiyatro tiyatro;
        private System.Windows.Forms.BindingSource seansBilgileriBindingSource;
        private tiyatroTableAdapters.SeansBilgileriTableAdapter seansBilgileriTableAdapter;
    }
}