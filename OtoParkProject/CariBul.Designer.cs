
namespace OtoParkProject
{
    partial class CariFrm
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
            this.cariTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otoPark_DatabaseDataSet4 = new OtoParkProject.OtoPark_DatabaseDataSet4();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogumTar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsYer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAboneNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cariTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoPark_DatabaseDataSet3 = new OtoParkProject.OtoPark_DatabaseDataSet3();
            this.cari_TBTableAdapter = new OtoParkProject.OtoPark_DatabaseDataSet3TableAdapters.Cari_TBTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.cari_TBTableAdapter1 = new OtoParkProject.OtoPark_DatabaseDataSet4TableAdapters.Cari_TBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoPark_DatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoPark_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cariTBBindingSource1;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(1, 48);
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
            // cariTBBindingSource1
            // 
            this.cariTBBindingSource1.DataMember = "Cari_TB";
            this.cariTBBindingSource1.DataSource = this.otoPark_DatabaseDataSet4;
            // 
            // otoPark_DatabaseDataSet4
            // 
            this.otoPark_DatabaseDataSet4.DataSetName = "OtoPark_DatabaseDataSet4";
            this.otoPark_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAd,
            this.colSoyad,
            this.colTCNo,
            this.colDogumTar,
            this.colIsTel,
            this.colEvTel,
            this.colCepTel,
            this.colIsYer,
            this.colAboneNo,
            this.colAdres,
            this.gridColumn1});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1201, 609, 314, 325);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.MinWidth = 25;
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            this.colAd.Width = 94;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.MinWidth = 25;
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 2;
            this.colSoyad.Width = 94;
            // 
            // colTCNo
            // 
            this.colTCNo.FieldName = "TCNo";
            this.colTCNo.MinWidth = 25;
            this.colTCNo.Name = "colTCNo";
            this.colTCNo.Visible = true;
            this.colTCNo.VisibleIndex = 3;
            this.colTCNo.Width = 94;
            // 
            // colDogumTar
            // 
            this.colDogumTar.FieldName = "DogumTar";
            this.colDogumTar.MinWidth = 25;
            this.colDogumTar.Name = "colDogumTar";
            this.colDogumTar.Visible = true;
            this.colDogumTar.VisibleIndex = 4;
            this.colDogumTar.Width = 94;
            // 
            // colIsTel
            // 
            this.colIsTel.FieldName = "IsTel";
            this.colIsTel.MinWidth = 25;
            this.colIsTel.Name = "colIsTel";
            this.colIsTel.Visible = true;
            this.colIsTel.VisibleIndex = 5;
            this.colIsTel.Width = 94;
            // 
            // colEvTel
            // 
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.MinWidth = 25;
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.Visible = true;
            this.colEvTel.VisibleIndex = 6;
            this.colEvTel.Width = 94;
            // 
            // colCepTel
            // 
            this.colCepTel.FieldName = "CepTel";
            this.colCepTel.MinWidth = 25;
            this.colCepTel.Name = "colCepTel";
            this.colCepTel.Visible = true;
            this.colCepTel.VisibleIndex = 7;
            this.colCepTel.Width = 94;
            // 
            // colIsYer
            // 
            this.colIsYer.FieldName = "IsYer";
            this.colIsYer.MinWidth = 25;
            this.colIsYer.Name = "colIsYer";
            this.colIsYer.Visible = true;
            this.colIsYer.VisibleIndex = 8;
            this.colIsYer.Width = 94;
            // 
            // colAboneNo
            // 
            this.colAboneNo.FieldName = "AboneNo";
            this.colAboneNo.MinWidth = 25;
            this.colAboneNo.Name = "colAboneNo";
            this.colAboneNo.Visible = true;
            this.colAboneNo.VisibleIndex = 9;
            this.colAboneNo.Width = 94;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.MinWidth = 25;
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 10;
            this.colAdres.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // cariTBBindingSource
            // 
            this.cariTBBindingSource.DataMember = "Cari_TB";
            this.cariTBBindingSource.DataSource = this.otoPark_DatabaseDataSet3;
            // 
            // otoPark_DatabaseDataSet3
            // 
            this.otoPark_DatabaseDataSet3.DataSetName = "OtoPark_DatabaseDataSet3";
            this.otoPark_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cari_TBTableAdapter
            // 
            this.cari_TBTableAdapter.ClearBeforeFill = true;
            // 
            // cari_TBTableAdapter1
            // 
            this.cari_TBTableAdapter1.ClearBeforeFill = true;
            // 
            // CariFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 760);
            this.Controls.Add(this.gridControl1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "CariFrm";
            this.Text = "CARİ";
            this.Load += new System.EventHandler(this.cariBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoPark_DatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoPark_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private OtoPark_DatabaseDataSet3 otoPark_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource cariTBBindingSource;
        private OtoPark_DatabaseDataSet3TableAdapters.Cari_TBTableAdapter cari_TBTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTCNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDogumTar;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEvTel;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTel;
        private DevExpress.XtraGrid.Columns.GridColumn colIsYer;
        private DevExpress.XtraGrid.Columns.GridColumn colAboneNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private OtoPark_DatabaseDataSet4 otoPark_DatabaseDataSet4;
        private System.Windows.Forms.BindingSource cariTBBindingSource1;
        private OtoPark_DatabaseDataSet4TableAdapters.Cari_TBTableAdapter cari_TBTableAdapter1;
    }
}