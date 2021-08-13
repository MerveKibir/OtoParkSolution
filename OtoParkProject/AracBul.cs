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

namespace OtoParkProject
{
    public partial class AracBul : DevExpress.XtraEditors.XtraForm
    {
        public string donecekDeger1 { get; set; }
        public AracBul()
        {
            InitializeComponent();
        }

        private void AracBul_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            this.arac_TBTableAdapter.Fill(this.otoPark_DatabaseDataSet5.Arac_TB);

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            this.donecekDeger1 = B;
            this.DialogResult = DialogResult.OK;
            AracEkleFrm frm = new AracEkleFrm();
            frm.Refresh();
            this.Close();
        }
    }
}