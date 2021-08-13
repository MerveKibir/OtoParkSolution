using DevExpress.XtraEditors;
using OtoParkProject.Classes;
using OtoParkProject.Models;
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

    public partial class AracEkleFrm : DevExpress.XtraEditors.XtraForm
    {
        DatabaseContext context = new DatabaseContext();
        public static int id = 0;
        public AracEkleFrm()
        {
            InitializeComponent();
        }
        public AracEkleFrm(int id)
        {
            InitializeComponent();
            string liste = context.Cari_TB.Single(x => x.ID == id).TCNo;
            cariCB.Text = liste;
        }

        private void AracEkleFrm_Load(object sender, EventArgs e)
        {
            aracEkle.Visible = false;
            aracListeBtn.Visible = false;
            var liste1 = (from at in context.AracTip_TB
                          where at.AktifMi == true
                          select at.AracTip).ToList();
            aracTipi.Properties.Items.AddRange(liste1);

        }
        public int idBul(string tcNo)
        {
            int id = (from a in context.Cari_TB
                      where a.TCNo == tcNo
                      select a.ID).Single();
            return id;
        }
        private void aracEkle_Click(object sender, EventArgs e)
        {
            var id = (from a in context.Arac_TB
                      join at in context.AracTip_TB
                      on a.AracTipId equals at.ID
                      where at.AracTip == aracTipi.Text
                      select a.AracTipId).Single();
            var firmaid = (from a in context.Arac_TB
                           join cf in context.CekiciFirma_TB
                           on a.CekiciFirmaId equals cf.ID
                           where cf.FirmaAd == cekiciFirmaTE.Text
                           select a.CekiciFirmaId).Single();
            if (plakaTE != null && cariCB != null && aracTipi != null)
            {
                Arac newArac = new Arac();
                if (!context.Arac_TB.Any(x => x.Plaka == plakaTE.Text))
                {
                    try
                    {
                        newArac.CariId = idBul(cariCB.Text);
                        newArac.Marka = markaTE.Text;
                        newArac.Model = modelTE.Text;
                        newArac.Aciklama = aciklamaTE.Text;
                        newArac.AracTanim = aracTanimTE.Text;
                        newArac.Renk = renkTE.Text;
                        newArac.EhliyetSinifi = ehliyetSinifiTE.Text;
                        newArac.AracTipId = id;
                        newArac.Plaka = plakaTE.Text;
                        if (cekiciMi.Checked && cekiciFirmaTE != null)
                        {
                            newArac.CekiciFirmaId = firmaid;
                            newArac.KmUcret = Convert.ToDecimal(kmUcretTE.Text);
                        }
                        else if (cekiciMi.Checked && cekiciFirmaTE == null)
                        {
                            MessageBox.Show("Lütfen firma bilgisini giriniz...");
                        }
                        else if (cekiciMi.Checked == false && cekiciFirmaTE != null || kmUcretTE.Text != null)
                        {
                            MessageBox.Show("Çekici firma bilgisi girebilmek için lütfen çekici tanımlaması yapınız...");
                        }
                        else
                        { }
                        newArac.YediEminMi = yediEminMi.Checked;
                        newArac.AktifMi = true;

                        context.Arac_TB.Add(newArac);
                        context.SaveChanges();
                        MessageBox.Show("Araç Ekleme İşlemi Başarılı...");
                        aracListeBtn.Visible = true;
                        aracEkle.Visible = true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Araç ekleme başarısız!");
                    }

                }
                else
                {
                    try
                    {
                        var liste2 = from upArac in context.Arac_TB
                                     where upArac.Plaka == plakaTE.Text
                                     select upArac;
                        foreach (Arac arac in liste2)
                        {
                            arac.CariId = idBul(cariCB.Text);
                            arac.Marka = markaTE.Text;
                            arac.Model = modelTE.Text;
                            arac.Aciklama = aciklamaTE.Text;
                            arac.AracTanim = aracTanimTE.Text;
                            arac.Renk = renkTE.Text;
                            arac.EhliyetSinifi = ehliyetSinifiTE.Text;
                            arac.AracTipId = id;
                            arac.Plaka = plakaTE.Text;
                            if (cekiciMi.Checked && cekiciFirmaTE != null)
                            {
                                arac.CekiciFirmaId = firmaid;
                                arac.KmUcret = Convert.ToDecimal(kmUcretTE.Text);
                            }
                            else if (cekiciMi.Checked && cekiciFirmaTE == null)
                            {
                                MessageBox.Show("Lütfen firma bilgisini giriniz...");
                            }
                            else if (cekiciMi.Checked == false && cekiciFirmaTE != null || kmUcretTE.Text != null)
                            {
                                MessageBox.Show("Çekici firma bilgisi girebilmek için lütfen çekici tanımlaması yapınız...");
                            }
                            else
                            { }
                            arac.YediEminMi = yediEminMi.Checked;
                            arac.AktifMi = aktiflik.Checked;
                        }
                        context.SaveChanges();
                        MessageBox.Show("Araç Güncelleme İşlemi Başarılı...");
                        aracListeBtn.Visible = true;
                        aracEkle.Visible = true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Kullanıcı Güncelleme Başarısız!");
                    }
                }
            }
            else
                MessageBox.Show("Gerekli alanları doldurunuz...");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.arac_TBTableAdapter.FillBy(this.otoPark_DatabaseDataSet2.Arac_TB, new System.Nullable<int>(((int)(System.Convert.ChangeType(cariToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.arac_TBTableAdapter.FillBy1(this.otoPark_DatabaseDataSet2.Arac_TB);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aracListeBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sorgulamayı plakaya göre mi yapmak istersiniz?", "Seçim", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (plakaTE.Text != "")
                {
                    try
                    {
                        string plaka = plakaTE.Text;
                        this.arac_TBTableAdapter.FillBy2(this.otoPark_DatabaseDataSet2.Arac_TB, plaka);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("İşlem Başarısız!", "Sonuç");
                    }
                }
                else
                    MessageBox.Show("Bilgilerini almak istediğiniz aracın plakasını giriniz...");

            }

            else if (result == DialogResult.No)
            {
                MessageBox.Show("Sorgulama cariye göre yapılacaktır...", "Sonuç");
                if (cariCB.Text != "")
                {
                    try
                    {
                        int id = idBul(cariCB.Text);
                        this.arac_TBTableAdapter.FillBy(this.otoPark_DatabaseDataSet2.Arac_TB, id);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("İşlem Başarısız!", "Sonuç");
                    }
                }
                else
                {
                    MessageBox.Show("Araçlarını görmek istediğiniz carinin kimlik bilgisini giriniz...", "Sonuç");
                }
            }
            else if (result == DialogResult.Cancel)
            {

            }
            else
                MessageBox.Show("İşlem Başarısız...", "Sonuç");

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.arac_TBTableAdapter.FillBy2(this.otoPark_DatabaseDataSet2.Arac_TB, plakaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void aracKaydet_Click(object sender, EventArgs e)
        {
            aracEkle.Visible = true;
            aracListeBtn.Visible = true;
            var result = MessageBox.Show("Başka araç eklemek istiyor musunuz?", "Araç Ekle", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (TextEdit txt in this.Controls.OfType<TextEdit>())
                {
                    txt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("İşleminiz tamamlandı.");
                this.Close();
            }
        }

        private void aracBulBtn_Click(object sender, EventArgs e)
        {
            using (var form = new AracBul())
            {
                var sonuc = form.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    int deger1 = Convert.ToInt32(form.donecekDeger1);
                    Model1 db = new Model1();
                    var listesi = db.Arac_TB.ToList();
                    var Aracim = context.Arac_TB.Where(p => p.ID == deger1).SingleOrDefault();
                    if (Aracim != null)
                    {
                       
                        markaTE.Text = Aracim.Marka;
                        modelTE.Text = Aracim.Model;
                        aciklamaTE.Text = Aracim.Aciklama;
                        aracTanimTE.Text = Aracim.AracTanim;
                        renkTE.Text = Aracim.Renk;
                        ehliyetSinifiTE.Text = Aracim.EhliyetSinifi;
                        plakaTE.Text = Aracim.Plaka;

                        aracTipi.Text = (context.AracTip_TB.Where(p => p.ID == Aracim.AracTipId).SingleOrDefault() != null) ? context.AracTip_TB.Where(p => p.ID == Aracim.AracTipId).SingleOrDefault().AracTip : "";
                        cekiciFirma.Text = (context.CekiciFirma_TB.Where(p => p.ID == Aracim.CekiciFirmaId).SingleOrDefault() != null) ? context.CekiciFirma_TB.Where(p => p.ID == Aracim.CekiciFirmaId).SingleOrDefault().FirmaAd : ""; ;
                        kmUcretTE.Text = (Aracim.KmUcret).ToString();
                        yediEminMi.Checked = (bool)Aracim.YediEminMi;
                        aktiflik.Checked = (bool)Aracim.AktifMi;
                        Cari carim = context.Cari_TB.Where(p => p.ID == Aracim.CariId).SingleOrDefault();
                        if (carim != null)
                        {
                            cariCB.Text = carim.TCNo;
                        }
                        else
                        {
                            cariCB.Text = "";
                        }
                    }







                }
            }
        }
    }
}