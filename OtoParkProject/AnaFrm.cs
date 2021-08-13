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

    public partial class AnaFrm : DevExpress.XtraEditors.XtraForm
    {
        DatabaseContext context = new DatabaseContext();
        public AnaFrm()
        {
            InitializeComponent();
        }

        private void AnaFrm_Load(object sender, EventArgs e)
        {

        }

        private void plakaTE_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void aracekleme_Click(object sender, EventArgs e)
        {

        }

        private void plakaTE_Click(object sender, EventArgs e)
        {
            plakaTE.Text = " ";
        }

        private void plakaTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DatabaseContext context = new DatabaseContext();

                if (context.Arac_TB.Any(x => x.Plaka == plakaTE.Text))
                {
                    MessageBox.Show("Araç Kayıtlı");
                    var liste = context.Arac_TB.Where(x => x.Plaka == plakaTE.Text).Single();        
                        aracTanim.Text = liste.AracTanim;
                        ehliyetSinifi.Text = liste.EhliyetSinifi;
                        marka.Text = liste.Marka;
                        model.Text = liste.Model;
                        renk.Text = liste.Renk;
                        aciklama.Text = liste.Aciklama;
                        tarifeTip.Text = context.TarifeTip_TB.SingleOrDefault(x => x.ID == liste.AbonelikId).TarifeTip;
                        tarifeBilgi.Text = (from tb in context.TarifeTip_TB
                                            join t in context.Tarife_TB
                                            on tb.ID equals t.TarifeTipId
                                            select t.TarifeAd).Single();
                }
                else
                {
                    MessageBox.Show("Araç Kayıtlı Değil...");
                }

            }
        }

        private void plakaTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´' || e.KeyChar == ' ')
            {
                e.Handled = true;
                MessageBox.Show("Harf ve Rakam Kullanınız...");
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
                MessageBox.Show("Harf ve Rakam Kullanınız...");
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
                MessageBox.Show("Harf ve Rakam Kullanınız...");
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
                MessageBox.Show("Harf ve Rakam Kullanınız...");
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
                MessageBox.Show("Harf ve Rakam Kullanınız...");
            }
        }
    }
}
