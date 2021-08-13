
namespace OtoParkProject
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.kullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sifre = new DevExpress.XtraEditors.TextEdit();
            this.girisButon = new DevExpress.XtraEditors.SimpleButton();
            this.cikisButon = new DevExpress.XtraEditors.SimpleButton();
            this.uyari = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAd
            // 
            this.kullaniciAd.Location = new System.Drawing.Point(184, 45);
            this.kullaniciAd.Name = "kullaniciAd";
            this.kullaniciAd.Size = new System.Drawing.Size(211, 22);
            this.kullaniciAd.TabIndex = 0;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(413, 23);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(298, 336);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 1;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(28, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Şifre";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(184, 110);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(211, 22);
            this.sifre.TabIndex = 4;
            // 
            // girisButon
            // 
            this.girisButon.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.girisButon.Appearance.Options.UseFont = true;
            this.girisButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.girisButon.Location = new System.Drawing.Point(272, 159);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(121, 51);
            this.girisButon.TabIndex = 5;
            this.girisButon.Text = "Giriş";
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.cikisButon.Appearance.Options.UseFont = true;
            this.cikisButon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.cikisButon.Location = new System.Drawing.Point(272, 231);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(123, 51);
            this.cikisButon.TabIndex = 6;
            this.cikisButon.Text = "İptal";
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // uyari
            // 
            this.uyari.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uyari.Appearance.Options.UseFont = true;
            this.uyari.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.uyari.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.uyari.Location = new System.Drawing.Point(12, 302);
            this.uyari.Name = "uyari";
            this.uyari.Padding = new System.Windows.Forms.Padding(4);
            this.uyari.Size = new System.Drawing.Size(299, 70);
            this.uyari.TabIndex = 7;
            this.uyari.Text = "İlk Kullanım İçin Kullanacağınız Bilgiler :\r\nKullanıcı Adı: Admin\r\nŞifre: admin";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 384);
            this.Controls.Add(this.uyari);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.kullaniciAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginFrm";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit kullaniciAd;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit sifre;
        private DevExpress.XtraEditors.SimpleButton girisButon;
        private DevExpress.XtraEditors.SimpleButton cikisButon;
        private DevExpress.XtraEditors.LabelControl uyari;
    }
}