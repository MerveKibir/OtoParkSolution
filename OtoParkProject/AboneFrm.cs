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
    public partial class AboneFrm : DevExpress.XtraEditors.XtraForm
    {
        DatabaseContext context = new DatabaseContext();
        public AboneFrm()
        {
            InitializeComponent();
        }

        private void AboneFrm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            pnlDty.Visible = false;
            pnlCari.Visible = false;
            aracTipCB.Properties.DataSource = (from ll in context.AracTip_TB
                                               select new
                                               {
                                                   ID = ll.ID,
                                                   AracTip = ll.AracTip
                                               }).ToList();

            tarifeCB.Properties.DataSource = (from ll in context.TarifeTip_TB
                                              select new
                                              {
                                                  ID = ll.ID,
                                                  TarifeTip = ll.TarifeTip
                                              }).ToList();
            aboneNo.Enabled = false;
            adTE.Enabled = false;
            adresTE.Enabled = false;
            soyadTE.Enabled = false;
            cepTelTE.Enabled = false;
            evTelTE.Enabled = false;
            isTelTE.Enabled = false;
            ekBilgi.Enabled = false;
            dgmTE.Enabled = false;
            TCNoTE.Enabled = false; icYkm.Enabled = false;
            disYkm.Enabled = false;
            icDisYkm.Enabled = false;
            ucret1.Enabled = false;
            ucret2.Enabled = false;
            ucret3.Enabled = false;
            adet2.Enabled = false;
            adet3.Enabled = false;
            adet4.Enabled = false;
            adet5.Enabled = false;
            adet6.Enabled = false;
            adet1.Enabled = false;
            uDisYkm.Enabled = false;
            uIcDisYkm.Enabled = false;
            uicYkm.Enabled = false;
        }

        private void cariBul_Click(object sender, EventArgs e)
        {
            using (var form = new CariFrm())
            {
                var sonuc = form.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    pnlCari.Visible = true;
                    int deger1 = Convert.ToInt32(form.donecekDeger1);
                    Cari_TB cari = new Cari_TB();
                    cari = context.Cari_TB.Where(c => c.ID == deger1).SingleOrDefault();
                    aboneNo.Text = cari.AboneNo;
                    adTE.Text = cari.Ad;
                    soyadTE.Text = cari.Soyad;
                    cepTelTE.Text = cari.CepTel;
                    isTelTE.Text = cari.IsTel;
                    ekBilgi.Text = cari.IsYer;
                    evTelTE.Text = cari.EvTel;
                    adresTE.Text = cari.Adres;
                    TCNoTE.Text = cari.TCNo;
                    dgmTE.Text = cari.DogumTar;
                    int tipid = Convert.ToInt32(aracTipCB.Text);

                    cariAraclar.Properties.DataSource = (from ll in context.Arac_TB
                                                         where ll.CariId == cari.ID && ll.AracTipId == tipid
                                                         select new
                                                         {
                                                             ID = ll.ID,
                                                             Plaka = ll.Plaka
                                                         }).ToList();

                }
            }
        }

        List<Arac_TB> Araclar = new List<Arac_TB>();
        private void aracSecim_Click(object sender, EventArgs e)
        {
            pnlDty.Visible = true;
            if (cariAraclar.Text == "")
            {
                MessageBox.Show("Lütfen önce seçim yapınız...");
            }
            else
            {
                var aracid = Convert.ToInt32(cariAraclar.Text);
                Araclar.Add(context.Arac_TB.Where(p => p.ID == aracid).Single());
                gridControl1.DataSource = (from arac in Araclar

                                           select new
                                           {
                                               arac.ID,
                                               arac.Marka,
                                               arac.Model,
                                               arac.Plaka
                                           }).ToList();
                gridControl1.RefreshDataSource();
            }

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            var uyariSonuc = MessageBox.Show("Yapılan değişikliler kaydedilsin mi?", "Onay", MessageBoxButtons.YesNo);
            if (uyariSonuc == DialogResult.Yes)
            {
                int cariid = Convert.ToInt32(context.Cari_TB.Where(p => p.TCNo == TCNoTE.Text).Single().ID);

                AbonelikArac_TB[] araclar = new AbonelikArac_TB[gridView1.RowCount];

                int abonelikId = 0;
                if (checkEdit3.Checked)
                {
                    abonelikId = 1;
                }
                if (checkEdit4.Checked)
                {
                    abonelikId = 2;
                }

                List<Arac_TB> arac = new List<Arac_TB>();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    int id = Convert.ToInt32(gridView1.GetRowCellValue(i, "ID"));
                    if (context.AbonelikArac_TB.Where(p => p.aracId == id).Any(p => p.AktifMi == true))//ARACIN ABONELİĞİ VAR MI ???
                    {
                        string tarife = tarifeeCB.EditValue.ToString();
                        string plaka = gridView1.GetRowCellValue(i, "Plaka").ToString();
                        string tarifeid = (context.Tarife_TB.Where(p => p.TarifeAd == tarife).SingleOrDefault().ID).ToString();
                        AbonelikArac_TB abonearac = context.AbonelikArac_TB.First(p => p.aracId == id && p.AktifMi == true);
                        DateTime bugun = DateTime.Now;
                        TimeSpan gun = Convert.ToDateTime(abonearac.bitis) - bugun;
                        int kalan = Convert.ToInt32(gun.TotalDays);
                        DateTime bitti = Convert.ToDateTime(abonearac.bitis);
                        var result = MessageBox.Show("Aracın aboneliği bulunmaktadır ve " + kalan + " sonra bitmektedir... Abonelik uzatma işlemini onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)//VAR
                        {

                            try
                            {
                                abonearac.AktifMi = false;
                                araclar[i] = new AbonelikArac_TB();
                                araclar[i].AktifMi = true;
                                araclar[i].aracId = id;
                                araclar[i].cariId = (context.Arac_TB.Where(p => p.Plaka == plaka).Single().CariId);
                                araclar[i].tarifeId = Convert.ToInt32(tarifeid);
                                araclar[i].abonelikId = abonelikId;
                                araclar[i].baslangic = bugun;
                                #region SaatBilgileri
                                if (gsaat.Text != "")
                                {
                                    araclar[i].GirisSaat = gsaat.Text;
                                }
                                if (csaat.Text != "")
                                {
                                    araclar[i].CikisSaat = csaat.Text;
                                }
                                #endregion
                                #region AbonelikBitis
                                var bitiss = Convert.ToDateTime(araclar[i].baslangic);
                                if (abonelikId == 1) { araclar[i].bitis = bugun.AddMonths(1); }
                                else if (abonelikId == 2) { araclar[i].bitis = bitiss.AddYears(1); }
                                else MessageBox.Show("Abonelik Seçiniz...");
                                #endregion
                                #region CheckEdit
                                if (disYkm.Checked) { araclar[i].disYkmAdet = Convert.ToInt32(adet2.Text); }
                                if (icDisYkm.Checked) { araclar[i].icDisYkmAdet = Convert.ToInt32(adet3.Text); }
                                if (icYkm.Checked) { araclar[i].icYkmAdet = Convert.ToInt32(adet1.Text); }
                                if (uDisYkm.Checked) { araclar[i].disYkmUcretsizAdet = Convert.ToInt32(adet2.Text); }
                                if (uIcDisYkm.Checked) { araclar[i].icDisYkmUcretsizAdet = Convert.ToInt32(adet3.Text); }
                                if (uicYkm.Checked) { araclar[i].icYkmUcretsizAdet = Convert.ToInt32(adet1.Text); }
                                if (topYkmUc.Text != "" && topYkmUc.Text != "0") { araclar[i].toplamYkmUcret = Convert.ToInt32(topYkmUc.Text); }
                                #endregion
                                #region AboneHaftalikDetay
                                if (tum.Checked)
                                {
                                    araclar[i].HaftalikGirisDetay = 1;
                                }
                                else if (hi.Checked)
                                {
                                    araclar[i].HaftalikGirisDetay = 2;
                                }
                                else if (hs.Checked)
                                {
                                    araclar[i].HaftalikGirisDetay = 3;
                                }
                                else if (cy.Checked)
                                {
                                    araclar[i].HaftalikGirisDetay = 4;
                                }
                                else if (py.Checked)
                                {
                                    araclar[i].HaftalikGirisDetay = 5;
                                }
                                else { }
                                #endregion
                                #region AboneGunlukDetay
                                if (tamgun.Checked)
                                {
                                    araclar[i].GunlukGirisDetay = 3;
                                }
                                else if (gece.Checked)
                                {
                                    araclar[i].GunlukGirisDetay = 2;
                                }
                                else if (gunduz.Checked)
                                {
                                    araclar[i].GunlukGirisDetay = 1;
                                }
                                else { }
                                #endregion
                                context.AbonelikArac_TB.Add(araclar[i]);
                                context.SaveChanges();
                                MessageBox.Show("Araç aboneliği güncellendi...");
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("Araç aboneliği güncellenemedi...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Abonelik ekleme işlemi iptal edildi...");
                        }
                    }

                    else
                    {
                        string tarife = tarifeeCB.EditValue.ToString();
                        string plaka = gridView1.GetRowCellValue(i, "Plaka").ToString();
                        string tarifeid = (context.Tarife_TB.Where(p => p.TarifeAd == tarife).SingleOrDefault().ID).ToString();
                        int tarifeIdd = Convert.ToInt32(tarifeid);
                        DateTime bugun = DateTime.Now;

                        araclar[i] = new AbonelikArac_TB();
                        araclar[i].AktifMi = true;
                        araclar[i].aracId = id;
                        araclar[i].cariId = (context.Arac_TB.Where(p => p.Plaka == plaka).Single().CariId);
                        araclar[i].tarifeId = Convert.ToInt32(tarifeid);
                        araclar[i].abonelikId = abonelikId;
                        araclar[i].baslangic = bugun;
                        #region SaatBilgileri
                        if (gsaat.Text != "")
                        {
                            araclar[i].GirisSaat = gsaat.Text;
                        }
                        if (csaat.Text != "")
                        {
                            araclar[i].CikisSaat = csaat.Text;
                        }
                        #endregion
                        #region AbonelikBitis
                        var bitiss = Convert.ToDateTime(araclar[i].baslangic);
                        if (abonelikId == 1) { araclar[i].bitis = bugun.AddMonths(1); }
                        else if (abonelikId == 2) { araclar[i].bitis = bitiss.AddYears(1); }
                        else MessageBox.Show("Abonelik Seçiniz...");
                        #endregion
                        #region CheckEdit
                        if (disYkm.Checked) { araclar[i].disYkmAdet = Convert.ToInt32(adet2.Text); }
                        if (icDisYkm.Checked) { araclar[i].icDisYkmAdet = Convert.ToInt32(adet3.Text); }
                        if (icYkm.Checked) { araclar[i].icYkmAdet = Convert.ToInt32(adet1.Text); }
                        if (uDisYkm.Checked) { araclar[i].disYkmUcretsizAdet = Convert.ToInt32(adet2.Text); }
                        if (uIcDisYkm.Checked) { araclar[i].icDisYkmUcretsizAdet = Convert.ToInt32(adet3.Text); }
                        if (uicYkm.Checked) { araclar[i].icYkmUcretsizAdet = Convert.ToInt32(adet1.Text); }
                        if (topYkmUc.Text != "" && topYkmUc.Text != "0") { araclar[i].toplamYkmUcret = Convert.ToInt32(topYkmUc.Text); }
                        #endregion
                        #region AboneHaftalikDetay
                        if (tum.Checked)
                        {
                            araclar[i].HaftalikGirisDetay = 1;
                        }
                        else if (hi.Checked)
                        {
                            araclar[i].HaftalikGirisDetay = 2;
                        }
                        else if (hs.Checked)
                        {
                            araclar[i].HaftalikGirisDetay = 3;
                        }
                        else if (cy.Checked)
                        {
                            araclar[i].HaftalikGirisDetay = 4;
                        }
                        else if (py.Checked)
                        {
                            araclar[i].HaftalikGirisDetay = 5;
                        }
                        else { }
                        #endregion
                        #region AboneGunlukDetay
                        if (tamgun.Checked)
                        {
                            araclar[i].GunlukGirisDetay = 3;
                        }
                        else if (gece.Checked)
                        {
                            araclar[i].GunlukGirisDetay = 2;
                        }
                        else if (gunduz.Checked)
                        {
                            araclar[i].GunlukGirisDetay = 1;
                        }
                        else { }
                        #endregion
                        context.AbonelikArac_TB.Add(araclar[i]);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Araçlar için abonelikler eklendi...");
                }
            }
            else
            {
                MessageBox.Show("Değişiklikler iptal edildi...");
            }
        }
        private void aracEkle_Click(object sender, EventArgs e)
        {
            int cariid = Convert.ToInt32(context.Cari_TB.Where(p => p.TCNo == TCNoTE.Text).Single().ID);
            AracEkleFrm frm = new AracEkleFrm(cariid);
            frm.ShowDialog();
        }

        private void tarifeSec_Click(object sender, EventArgs e)
        {
            if (tarifeCB.Text != "" && tarifeeCB.Text != "" && aracTipCB.Text != "")
            {
                pnlCari.Visible = true;
            }
        }

        private void tarifeCB_EditValueChanged(object sender, EventArgs e)
        {
            AboneFrm frm = new AboneFrm();
            frm.Refresh();
            string tip = aracTipCB.EditValue.ToString();
            if (tarifeCB.Text != "")
            {
                int abonelikId = 0;
                if (checkEdit3.Checked)
                {
                    abonelikId = 1;
                }
                else if (checkEdit4.Checked)
                {
                    abonelikId = 2;
                }
                else
                    MessageBox.Show("Lütfen abonelik tipi seçiniz...");
                int tarife = Convert.ToInt32(tarifeCB.Text);
                tarifeeCB.Properties.DataSource = (from ll in context.Tarife_TB
                                                   where (ll.AracTip == tip && ll.TarifeTipId == tarife && ll.AbonelikId == abonelikId)
                                                   select new
                                                   {
                                                       ID = ll.ID,
                                                       TarifeAd = ll.TarifeAd
                                                   }).ToList();
            }
        }

        private void cariEkle_Click(object sender, EventArgs e)
        {
            CariEkleFrm frm = new CariEkleFrm();
            frm.ShowDialog();
        }

        private void ucretlendirme_EditValueChanged(object sender, EventArgs e)
        {

            if (ucretlendirme.Text == "İndirimli Ücretlendirme")
            {
                icYkm.Enabled = true;
                disYkm.Enabled = true;
                icDisYkm.Enabled = true;
                ucret1.Enabled = true;
                ucret2.Enabled = true;
                ucret3.Enabled = true;
                adet2.Enabled = false;
                adet3.Enabled = false;
                adet4.Enabled = false;
                adet5.Enabled = false;
                adet6.Enabled = false;
                adet1.Enabled = false;
                uDisYkm.Enabled = true;
                uIcDisYkm.Enabled = true;
                uicYkm.Enabled = true;
            }
            else if (ucretlendirme.Text == "Tarife Ücretlendirmesi")
            {
                icYkm.Enabled = true;
                disYkm.Enabled = true;
                icDisYkm.Enabled = true;
                ucret1.Enabled = false;
                ucret2.Enabled = false;
                ucret3.Enabled = false;
                adet2.Enabled = false;
                adet3.Enabled = false;
                adet4.Enabled = false;
                adet5.Enabled = false;
                adet6.Enabled = false;
                adet1.Enabled = false;
                uDisYkm.Enabled = true;
                uIcDisYkm.Enabled = true;
                uicYkm.Enabled = true;
                ucret1.Text = (context.Tarife_TB.Where(p => p.YıkamaTip == "İç Yıkama").SingleOrDefault().YıkamaFiyat).ToString();
                ucret2.Text = (context.Tarife_TB.Where(p => p.YıkamaTip == "Dış Yıkama").SingleOrDefault().YıkamaFiyat).ToString();
                ucret3.Text = (context.Tarife_TB.Where(p => p.YıkamaTip == "İç Dış Yıkama").SingleOrDefault().YıkamaFiyat).ToString();
            }
        }

        private void yikamaHesapla_Click(object sender, EventArgs e)
        {
            int aracSayi = gridView1.RowCount;
            decimal toplam = 0;
            if (icYkm.Checked && disYkm.Checked && icDisYkm.Checked)
            {
                toplam += (Convert.ToInt32(adet1.Text) * Convert.ToDecimal(ucret1.Text));
                toplam += (Convert.ToInt32(adet2.Text) * Convert.ToDecimal(ucret2.Text));
                toplam += (Convert.ToInt32(adet3.Text) * Convert.ToDecimal(ucret3.Text));
            }
            else if (icYkm.Checked && disYkm.Checked)
            {
                toplam += (Convert.ToInt32(adet1.Text) * Convert.ToDecimal(ucret1.Text));
                toplam += (Convert.ToInt32(adet2.Text) * Convert.ToDecimal(ucret2.Text));
            }
            else if (disYkm.Checked && icDisYkm.Checked)
            {
                toplam += (Convert.ToInt32(adet2.Text) * Convert.ToDecimal(ucret2.Text));
                toplam += (Convert.ToInt32(adet3.Text) * Convert.ToDecimal(ucret3.Text));
            }
            else if (icYkm.Checked && icDisYkm.Checked)
            {
                toplam += (Convert.ToInt32(adet1.Text) * Convert.ToDecimal(ucret1.Text));
                toplam += (Convert.ToInt32(adet3.Text) * Convert.ToDecimal(ucret3.Text));
            }
            else if (icYkm.Checked)
            {
                toplam += (Convert.ToInt32(adet1.Text) * Convert.ToDecimal(ucret1.Text));
            }
            else if (disYkm.Checked)
            {
                toplam += (Convert.ToInt32(adet2.Text) * Convert.ToDecimal(ucret2.Text));
            }
            else if (icDisYkm.Checked)
            {
                toplam += (Convert.ToInt32(adet3.Text) * Convert.ToDecimal(ucret3.Text));
            }
            else
            {
                toplam = 0;
                hesapYkm.Text = toplam.ToString();
            }
            int tarifeid = Convert.ToInt32(tarifeeCB.Text);
            hesapYkm.Text = toplam.ToString();
            topYkmUc.Text = (toplam * aracSayi).ToString();
            tarifeUcret.Text = (context.Tarife_TB.Where(p => p.ID == tarifeid).SingleOrDefault().TarifeFiyat).ToString();
            aracAdet.Text = aracSayi.ToString();
            topTarUC.Text = (aracSayi * Convert.ToDecimal(tarifeUcret.Text)).ToString();
            decimal topTar = Convert.ToDecimal(topTarUC.Text);
            decimal topYkm = Convert.ToDecimal(topYkmUc.Text);
            total.Text = (topTar + topYkm).ToString();
        }

        #region YikamaEnable
        private void icYkm_CheckedChanged(object sender, EventArgs e)
        {
            adet1.Enabled = true;
            if (ucretlendirme.Text == "İndirimli Ücretlendirme")
            {
                ucret1.Enabled = true;
            }
        }

        private void disYkm_CheckedChanged(object sender, EventArgs e)
        {
            adet2.Enabled = true;
            if (ucretlendirme.Text == "İndirimli Ücretlendirme")
            {
                ucret2.Enabled = true;
            }
        }

        private void icDisYkm_CheckedChanged(object sender, EventArgs e)
        {
            adet3.Enabled = true;
            if (ucretlendirme.Text == "İndirimli Ücretlendirme")
            {
                ucret3.Enabled = true;
            }
        }

        private void uicYkm_CheckedChanged(object sender, EventArgs e)
        {
            adet4.Enabled = true;
        }

        private void uDisYkm_CheckedChanged(object sender, EventArgs e)
        {
            adet5.Enabled = true;
        }

        private void uIcDisYkm_CheckedChanged(object sender, EventArgs e)
        {
            adet6.Enabled = true;
        }
        #endregion

        #region CheckedChanged
        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            checkEdit4.Checked = false;
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            checkEdit3.Checked = false;
        }

        private void gunduz_CheckedChanged(object sender, EventArgs e)
        {
            gunduz.Checked = false;
            tamgun.Checked = false;
        }

        private void gece_CheckedChanged(object sender, EventArgs e)
        {
            tamgun.Checked = false;
            gece.Checked = false;
        }

        private void tamgun_CheckedChanged(object sender, EventArgs e)
        {
            gunduz.Checked = false;
            gece.Checked = false;
        }
        private void tum_CheckedChanged(object sender, EventArgs e)
        {
            hs.Checked = false;
            hi.Checked = false;
            cy.Checked = false;
            py.Checked = false;
        }

        private void hi_CheckedChanged(object sender, EventArgs e)
        {
            tum.Checked = false;
            hs.Checked = false;
            cy.Checked = false;
            py.Checked = false;
        }

        private void hs_CheckedChanged(object sender, EventArgs e)
        {
            tum.Checked = false;
            hi.Checked = false;
            cy.Checked = false;
            py.Checked = false;
        }

        private void cy_CheckedChanged(object sender, EventArgs e)
        {
            tum.Checked = false;
            hi.Checked = false;
            hs.Checked = false;
            py.Checked = false;
        }

        private void py_CheckedChanged(object sender, EventArgs e)
        {
            tum.Checked = false;
            hi.Checked = false;
            cy.Checked = false;
            hs.Checked = false;
        }
        #endregion



        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mesaj"></param>
        /// <param name="Baslik"></param>
        public void mesajgoster(string Mesaj, string Baslik)
        {
            MessageBox.Show(Mesaj, Baslik);
        }
    }
}
