
namespace OtoParkProject
{
    partial class AracBul
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.aracTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoPark_DatabaseDataSet5 = new OtoParkProject.OtoPark_DatabaseDataSet5();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRenk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTipId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbonelikId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEhliyetSinifi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKmUcret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCekiciFirmaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYediEminMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYediEminGirisKayitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.arac_TBTableAdapter = new OtoParkProject.OtoPark_DatabaseDataSet5TableAdapters.Arac_TBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoPark_DatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.aracTBBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MaximumSize = new System.Drawing.Size(1200, 700);
            this.gridControl1.MinimumSize = new System.Drawing.Size(1200, 700);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1200, 700);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // aracTBBindingSource
            // 
            this.aracTBBindingSource.DataMember = "Arac_TB";
            this.aracTBBindingSource.DataSource = this.otoPark_DatabaseDataSet5;
            // 
            // otoPark_DatabaseDataSet5
            // 
            this.otoPark_DatabaseDataSet5.DataSetName = "OtoPark_DatabaseDataSet5";
            this.otoPark_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAracTanim,
            this.colMarka,
            this.colModel,
            this.colRenk,
            this.colPlaka,
            this.colAracTipId,
            this.colCariId,
            this.colAbonelikId,
            this.colEhliyetSinifi,
            this.colKmUcret,
            this.colCekiciFirmaId,
            this.colAciklama,
            this.colYediEminMi,
            this.colYediEminGirisKayitId,
            this.colAktifMi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colAracTanim
            // 
            this.colAracTanim.FieldName = "AracTanim";
            this.colAracTanim.MinWidth = 25;
            this.colAracTanim.Name = "colAracTanim";
            this.colAracTanim.Visible = true;
            this.colAracTanim.VisibleIndex = 1;
            this.colAracTanim.Width = 94;
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.MinWidth = 25;
            this.colMarka.Name = "colMarka";
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 2;
            this.colMarka.Width = 94;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.MinWidth = 25;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 3;
            this.colModel.Width = 94;
            // 
            // colRenk
            // 
            this.colRenk.FieldName = "Renk";
            this.colRenk.MinWidth = 25;
            this.colRenk.Name = "colRenk";
            this.colRenk.Visible = true;
            this.colRenk.VisibleIndex = 4;
            this.colRenk.Width = 94;
            // 
            // colPlaka
            // 
            this.colPlaka.FieldName = "Plaka";
            this.colPlaka.MinWidth = 25;
            this.colPlaka.Name = "colPlaka";
            this.colPlaka.Visible = true;
            this.colPlaka.VisibleIndex = 5;
            this.colPlaka.Width = 94;
            // 
            // colAracTipId
            // 
            this.colAracTipId.FieldName = "AracTipId";
            this.colAracTipId.MinWidth = 25;
            this.colAracTipId.Name = "colAracTipId";
            this.colAracTipId.Visible = true;
            this.colAracTipId.VisibleIndex = 6;
            this.colAracTipId.Width = 94;
            // 
            // colCariId
            // 
            this.colCariId.FieldName = "CariId";
            this.colCariId.MinWidth = 25;
            this.colCariId.Name = "colCariId";
            this.colCariId.Visible = true;
            this.colCariId.VisibleIndex = 7;
            this.colCariId.Width = 94;
            // 
            // colAbonelikId
            // 
            this.colAbonelikId.FieldName = "AbonelikId";
            this.colAbonelikId.MinWidth = 25;
            this.colAbonelikId.Name = "colAbonelikId";
            this.colAbonelikId.Visible = true;
            this.colAbonelikId.VisibleIndex = 8;
            this.colAbonelikId.Width = 94;
            // 
            // colEhliyetSinifi
            // 
            this.colEhliyetSinifi.FieldName = "EhliyetSinifi";
            this.colEhliyetSinifi.MinWidth = 25;
            this.colEhliyetSinifi.Name = "colEhliyetSinifi";
            this.colEhliyetSinifi.Visible = true;
            this.colEhliyetSinifi.VisibleIndex = 9;
            this.colEhliyetSinifi.Width = 94;
            // 
            // colKmUcret
            // 
            this.colKmUcret.FieldName = "KmUcret";
            this.colKmUcret.MinWidth = 25;
            this.colKmUcret.Name = "colKmUcret";
            this.colKmUcret.Visible = true;
            this.colKmUcret.VisibleIndex = 10;
            this.colKmUcret.Width = 94;
            // 
            // colCekiciFirmaId
            // 
            this.colCekiciFirmaId.FieldName = "CekiciFirmaId";
            this.colCekiciFirmaId.MinWidth = 25;
            this.colCekiciFirmaId.Name = "colCekiciFirmaId";
            this.colCekiciFirmaId.Visible = true;
            this.colCekiciFirmaId.VisibleIndex = 11;
            this.colCekiciFirmaId.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 12;
            this.colAciklama.Width = 94;
            // 
            // colYediEminMi
            // 
            this.colYediEminMi.FieldName = "YediEminMi";
            this.colYediEminMi.MinWidth = 25;
            this.colYediEminMi.Name = "colYediEminMi";
            this.colYediEminMi.Visible = true;
            this.colYediEminMi.VisibleIndex = 13;
            this.colYediEminMi.Width = 94;
            // 
            // colYediEminGirisKayitId
            // 
            this.colYediEminGirisKayitId.FieldName = "YediEminGirisKayitId";
            this.colYediEminGirisKayitId.MinWidth = 25;
            this.colYediEminGirisKayitId.Name = "colYediEminGirisKayitId";
            this.colYediEminGirisKayitId.Visible = true;
            this.colYediEminGirisKayitId.VisibleIndex = 14;
            this.colYediEminGirisKayitId.Width = 94;
            // 
            // colAktifMi
            // 
            this.colAktifMi.FieldName = "AktifMi";
            this.colAktifMi.MinWidth = 25;
            this.colAktifMi.Name = "colAktifMi";
            this.colAktifMi.Visible = true;
            this.colAktifMi.VisibleIndex = 15;
            this.colAktifMi.Width = 94;
            // 
            // arac_TBTableAdapter
            // 
            this.arac_TBTableAdapter.ClearBeforeFill = true;
            // 
            // AracBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 660);
            this.Controls.Add(this.gridControl1);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "AracBul";
            this.Text = "AracBul";
            this.Load += new System.EventHandler(this.AracBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoPark_DatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private OtoPark_DatabaseDataSet5 otoPark_DatabaseDataSet5;
        private System.Windows.Forms.BindingSource aracTBBindingSource;
        private OtoPark_DatabaseDataSet5TableAdapters.Arac_TBTableAdapter arac_TBTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAracTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colRenk;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colAracTipId;
        private DevExpress.XtraGrid.Columns.GridColumn colCariId;
        private DevExpress.XtraGrid.Columns.GridColumn colAbonelikId;
        private DevExpress.XtraGrid.Columns.GridColumn colEhliyetSinifi;
        private DevExpress.XtraGrid.Columns.GridColumn colKmUcret;
        private DevExpress.XtraGrid.Columns.GridColumn colCekiciFirmaId;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colYediEminMi;
        private DevExpress.XtraGrid.Columns.GridColumn colYediEminGirisKayitId;
        private DevExpress.XtraGrid.Columns.GridColumn colAktifMi;
    }
}