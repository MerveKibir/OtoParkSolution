using DevExpress.XtraEditors;
using OtoParkProject.Classes;
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
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            AnaFrm frm = new AnaFrm();
            FormKontrol(frm);
            

        }
        public void FormKontrol(Form AcilanForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (AcilanForm.Name == MdiChildren[i].Name)
                {
                    MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilanForm.MdiParent = this;
                AcilanForm.WindowState = FormWindowState.Maximized;
                AcilanForm.Show();
            }
            else
            {
                AcilanForm.Refresh();
                AcilanForm.Activate();
            }
        }

        private void AboneEkleBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void CariEkleBtn_Click(object sender, EventArgs e)
        {
            CariEkleFrm frm = new CariEkleFrm();
            FormKontrol(frm);
        }

        private void AracEkleBtn_Click(object sender, EventArgs e)
        {
            AracEkleFrm frm = new AracEkleFrm();
            FormKontrol(frm);
        }

        private void CksBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void AbonelikEkleBtn_Click(object sender, EventArgs e)
        {
            AboneFrm frm = new AboneFrm();
            FormKontrol(frm);
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            TarifeAyarları frm = new TarifeAyarları();
            FormKontrol(frm);
        }
    }
}