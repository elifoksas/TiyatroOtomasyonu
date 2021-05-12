namespace SanatTiyatrosu
{
    partial class frmSeansListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeansListele));
            this.tiyatro = new SanatTiyatrosu.tiyatro();
            this.seansBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansBilgileriTableAdapter = new SanatTiyatrosu.tiyatroTableAdapters.SeansBilgileriTableAdapter();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.grdSeans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tiyatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeans)).BeginInit();
            this.SuspendLayout();
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
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Location = new System.Drawing.Point(634, 380);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(148, 53);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // grdSeans
            // 
            this.grdSeans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeans.Location = new System.Drawing.Point(21, 27);
            this.grdSeans.Name = "grdSeans";
            this.grdSeans.RowTemplate.Height = 24;
            this.grdSeans.Size = new System.Drawing.Size(761, 347);
            this.grdSeans.TabIndex = 2;
            // 
            // frmSeansListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 457);
            this.Controls.Add(this.grdSeans);
            this.Controls.Add(this.btnListele);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSeansListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Listele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeansListele_FormClosing);
            this.Load += new System.EventHandler(this.frmSeansListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiyatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private tiyatro tiyatro;
        private System.Windows.Forms.BindingSource seansBilgileriBindingSource;
        private tiyatroTableAdapters.SeansBilgileriTableAdapter seansBilgileriTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private System.Windows.Forms.DataGridView grdSeans;
    }
}