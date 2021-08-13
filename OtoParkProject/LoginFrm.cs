using DevExpress.XtraEditors;
using OtoParkProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoParkProject
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            if (Program.ilk)
            {
                uyari.Visible = false;
            }
        }

        private void girisButon_Click(object sender, EventArgs e)
        {

            if (kullaniciAd.Text != "Admin")
            {
                DatabaseContext context = new DatabaseContext();

               if( context.Sirketler_TB.Any(s => s.KullaniciAd == kullaniciAd.Text))
                {
                    AnaFrm anasayfa = new AnaFrm();
                    anasayfa.Show();
                    this.Hide();
                }

            }
        }
        private void cikisButon_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}