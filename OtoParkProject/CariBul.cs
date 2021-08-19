using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtoParkProject.Classes;

namespace OtoParkProject
{
    public partial class CariFrm : DevExpress.XtraEditors.XtraForm
    {
        public string donecekDeger1 { get; set; }
        public CariFrm()
        {
            InitializeComponent();
            
        }

        private void cariBul_Load(object sender, EventArgs e)
        {
            //DatabaseContext db = new DatabaseContext();
            //gridControl1.DataSource = db.Cari_TB.ToList();
            gridView1.OptionsBehavior.Editable = false;
            // TODO: Bu kod satırı 'otoPark_DatabaseDataSet4.Cari_TB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cari_TBTableAdapter1.Fill(this.otoPark_DatabaseDataSet4.Cari_TB);
            // TODO: Bu kod satırı 'otoPark_DatabaseDataSet3.Cari_TB' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cari_TBTableAdapter.Fill(this.otoPark_DatabaseDataSet3.Cari_TB);

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            this.donecekDeger1 = B;
            this.DialogResult = DialogResult.OK;
            CariEkleFrm frm = new CariEkleFrm();
            AboneFrm frm2 = new AboneFrm();
            frm2.Refresh();
            frm.Refresh();
            this.Close();
        }

    }
}