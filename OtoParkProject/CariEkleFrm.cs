using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using OtoParkProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoParkProject
{
    public partial class CariEkleFrm : DevExpress.XtraEditors.XtraForm
    {
        DatabaseContext context = new DatabaseContext();
        bool kontrol = false;

        public CariEkleFrm()
        {
            InitializeComponent();
        }
        public CariEkleFrm(string[] liste)
        {
            InitializeComponent();
            TCNoTE.Text = liste[0];
        }

        private void CariEkleFrm_Load(object sender, EventArgs e)
        {
            string AboneNo = RKod();
            aboneNoTE.Text = AboneNo;
            aracListe.Visible = false;
            aracEkle.Visible = false;
        }
        public int idBul(string tcNo)
        {
            int id = (from a in context.Cari_TB
                      where a.TCNo == tcNo
                      select a.ID).Single();
            return id;
        }
        public string RKod()
        {

            Random rastgele = new Random();
            //string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            string uret = "";
            for (int i = 0; i < 6; i++)
            {
                uret += ((char)rastgele.Next('A', 'Z')).ToString();
            }
            kontrol = context.Cari_TB.Any(x => x.AboneNo == uret);

            if (!kontrol)
                return uret;
            else
                return RKod();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string resimPath;
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Resim Seçiniz";
                op.Filter = "Resim Dosyaları(*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";
                op.RestoreDirectory = true;

                if (op.ShowDialog() == DialogResult.OK)
                {
                    pictureEdit1.Image = Image.FromFile(openFileDialog1.FileName);
                    resimPath = openFileDialog1.FileName.ToString();

                    FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    byte[] resim = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem Gerçekleştirilemedi...");
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int id = idBul(TCNoTE.Text);
            AracEkleFrm frm = new AracEkleFrm(id);
            frm.ShowDialog();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.arac_TBTableAdapter1.FillBy1(this.otoPark_DatabaseDataSet1.Arac_TB, new System.Nullable<int>(((int)(System.Convert.ChangeType(cariidToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.arac_TBTableAdapter1.FillBy(this.otoPark_DatabaseDataSet1.Arac_TB);
        }

        private void cariEkle_Click(object sender, EventArgs e)
        {
            if (adresTE != null && adTE != null && soyadTE != null && TCNoTE != null && dgmTE != null && cepTelTE != null)
            {
                Cari_TB newCari = new Cari_TB();
                if (!context.Cari_TB.Any(x => x.AboneNo == aboneNoTE.Text))
                {
                    try
                    {
                        newCari.Ad = adTE.Text;
                        newCari.Soyad = soyadTE.Text;
                        newCari.TCNo = TCNoTE.Text;
                        newCari.DogumTar = dgmTE.Text;
                        newCari.IsTel = isTelTE.Text;
                        newCari.CepTel = cepTelTE.Text;
                        newCari.EvTel = evTelTE.Text;
                        newCari.IsYer = isYerTE.Text;
                        newCari.AboneNo = aboneNoTE.Text;
                        newCari.Adres = adresTE.Text;
                        newCari.AktifMi = true;

                        context.Cari_TB.Add(newCari);
                        context.SaveChanges();
                        MessageBox.Show("Kullanıcı Ekleme İşlemi Başarılı...");
                        aracListe.Visible = true;
                        aracEkle.Visible = true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Kullanıcı ekleme başarısız!");
                    }

                }
                else
                {
                    try
                    {
                        var liste2 = from upCari in context.Cari_TB
                                                  where upCari.TCNo == TCNoTE.Text
                                                  select upCari;
                        foreach(Cari_TB cari in liste2)
                        {
                            cari.Ad = adTE.Text;
                            cari.Soyad = soyadTE.Text;
                            cari.TCNo = TCNoTE.Text;
                            cari.DogumTar = dgmTE.Text;
                            cari.IsTel = isTelTE.Text;
                            cari.CepTel = cepTelTE.Text;
                            cari.EvTel = evTelTE.Text;
                            cari.IsYer = isYerTE.Text;
                            cari.AboneNo = aboneNoTE.Text;
                            cari.Adres = adresTE.Text;
                            cari.AktifMi = aktiflik.Checked;
                        }
                        context.SaveChanges();
                        MessageBox.Show("Kullanıcı Güncelleme İşlemi Başarılı...");
                        aracListe.Visible = true;
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

        private void aracListe_Click(object sender, EventArgs e)
        {
            if (TCNoTE.Text != "")
            {
                try
                {
                    int cariid = idBul(TCNoTE.Text);
                    this.arac_TBTableAdapter1.FillBy1(this.otoPark_DatabaseDataSet1.Arac_TB, cariid);
                }
                catch (Exception)
                {

                    MessageBox.Show("İşlem Başarısız!");
                }
            }
            else
            {
                MessageBox.Show("Araçlarını görmek istediğiniz carinin kimlik bilgisini giriniz...");
            }
        }

        private void aracEkle_Click(object sender, EventArgs e)
        {
            int cariid = idBul(TCNoTE.Text);
            AracEkleFrm frm = new AracEkleFrm(cariid);
            frm.ShowDialog();
        }

        private void cariBul_Click(object sender, EventArgs e)
        {
            using (var form = new CariFrm())
            {
                var sonuc = form.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    int deger1 = Convert.ToInt32(form.donecekDeger1);
                    var liste = (from c in context.Cari_TB
                                 where c.ID == deger1
                                 select new
                                 {
                                     c.Ad,
                                     c.Soyad,
                                     c.TCNo,
                                     c.IsYer,
                                     c.IsTel,
                                     c.CepTel,
                                     c.DogumTar,
                                     c.Adres,
                                     c.AboneNo,
                                     c.EvTel
                                 }).SingleOrDefault();
                    adTE.Text = liste.Ad;
                    adresTE.Text = liste.Adres;
                    aboneNoTE.Text = liste.AboneNo;
                    soyadTE.Text = liste.Soyad;
                    TCNoTE.Text = liste.TCNo;
                    isYerTE.Text = liste.IsYer;
                    isTelTE.Text = liste.IsTel;
                    cepTelTE.Text = liste.CepTel;
                    dgmTE.Text = liste.DogumTar;
                    evTelTE.Text = liste.EvTel;
                }
            }
        }
    }
}
