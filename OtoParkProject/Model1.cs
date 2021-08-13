using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OtoParkProject
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Abonelik_TB> Abonelik_TB { get; set; }
        public virtual DbSet<Abonelik_Tip> Abonelik_Tip { get; set; }
        public virtual DbSet<Aboneliks> Aboneliks { get; set; }
        public virtual DbSet<AbonelikTip_TB> AbonelikTip_TB { get; set; }
        public virtual DbSet<Arac_TB> Arac_TB { get; set; }
        public virtual DbSet<Arac_Tip> Arac_Tip { get; set; }
        public virtual DbSet<Aracs> Aracs { get; set; }
        public virtual DbSet<AracTip_TB> AracTip_TB { get; set; }
        public virtual DbSet<Cari_TB> Cari_TB { get; set; }
        public virtual DbSet<Caris> Caris { get; set; }
        public virtual DbSet<CekiciFirma_TB> CekiciFirma_TB { get; set; }
        public virtual DbSet<CekiciFirmas> CekiciFirmas { get; set; }
        public virtual DbSet<CekiciHareketleri_TB> CekiciHareketleri_TB { get; set; }
        public virtual DbSet<EhliyetBilgi_TB> EhliyetBilgi_TB { get; set; }
        public virtual DbSet<EkipPolis_TB> EkipPolis_TB { get; set; }
        public virtual DbSet<Fatura_TB> Fatura_TB { get; set; }
        public virtual DbSet<FaturaTip_TB> FaturaTip_TB { get; set; }
        public virtual DbSet<GelirTip_TB> GelirTip_TB { get; set; }
        public virtual DbSet<Gider_TB> Gider_TB { get; set; }
        public virtual DbSet<GiderTip_TB> GiderTip_TB { get; set; }
        public virtual DbSet<KasaHareketleri_TB> KasaHareketleri_TB { get; set; }
        public virtual DbSet<Odeme_TB> Odeme_TB { get; set; }
        public virtual DbSet<Personel_TB> Personel_TB { get; set; }
        public virtual DbSet<Personels> Personels { get; set; }
        public virtual DbSet<Ruhsat1_TB> Ruhsat1_TB { get; set; }
        public virtual DbSet<Ruhsat2_TB> Ruhsat2_TB { get; set; }
        public virtual DbSet<Sirketler_TB> Sirketler_TB { get; set; }
        public virtual DbSet<Sirkets> Sirkets { get; set; }
        public virtual DbSet<Subeler_TB> Subeler_TB { get; set; }
        public virtual DbSet<Subes> Subes { get; set; }
        public virtual DbSet<Surucu_TB> Surucu_TB { get; set; }
        public virtual DbSet<Tarife_TB> Tarife_TB { get; set; }
        public virtual DbSet<Tarife_Tip> Tarife_Tip { get; set; }
        public virtual DbSet<Tarifes> Tarifes { get; set; }
        public virtual DbSet<TarifeTip_TB> TarifeTip_TB { get; set; }
        public virtual DbSet<TrafikEkip_TB> TrafikEkip_TB { get; set; }
        public virtual DbSet<YediEminCikisKayit_TB> YediEminCikisKayit_TB { get; set; }
        public virtual DbSet<YediEminGirisKayit_TB> YediEminGirisKayit_TB { get; set; }
        public virtual DbSet<YediEminHasar_TB> YediEminHasar_TB { get; set; }
        public virtual DbSet<Yetki_TB> Yetki_TB { get; set; }
        public virtual DbSet<YetkiTip_TB> YetkiTip_TB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac_TB>()
                .Property(e => e.Plaka)
                .IsUnicode(false);

            modelBuilder.Entity<Arac_TB>()
                .Property(e => e.KmUcret)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Cari_TB>()
                .Property(e => e.TCNo)
                .IsUnicode(false);

            modelBuilder.Entity<Cari_TB>()
                .Property(e => e.DogumTar)
                .IsUnicode(false);

            modelBuilder.Entity<Cari_TB>()
                .Property(e => e.AboneNo)
                .IsUnicode(false);

            modelBuilder.Entity<CekiciHareketleri_TB>()
                .Property(e => e.Mesafe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CekiciHareketleri_TB>()
                .Property(e => e.EkUcret)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CekiciHareketleri_TB>()
                .Property(e => e.ToplamUcret)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Fatura_TB>()
                .Property(e => e.Nakit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Fatura_TB>()
                .Property(e => e.KKart)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Fatura_TB>()
                .Property(e => e.Toplam)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FaturaTip_TB>()
                .HasMany(e => e.Fatura_TB)
                .WithOptional(e => e.FaturaTip_TB)
                .HasForeignKey(e => e.FaturaTip);

            modelBuilder.Entity<Gider_TB>()
                .Property(e => e.Toplam)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Odeme_TB>()
                .Property(e => e.Odenecek)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Odeme_TB>()
                .Property(e => e.Odenen)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Odeme_TB>()
                .Property(e => e.Kalan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Odeme_TB>()
                .Property(e => e.KKart)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Odeme_TB>()
                .Property(e => e.Nakit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Personel_TB>()
                .Property(e => e.TCNo)
                .IsUnicode(false);

            modelBuilder.Entity<Personel_TB>()
                .Property(e => e.SicilNo)
                .IsUnicode(false);

            modelBuilder.Entity<Personel_TB>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Personel_TB>()
                .Property(e => e.PerNo)
                .IsUnicode(false);

            modelBuilder.Entity<Ruhsat1_TB>()
                .Property(e => e.Plaka)
                .IsUnicode(false);

            modelBuilder.Entity<Ruhsat1_TB>()
                .Property(e => e.TescilSiraNo)
                .IsFixedLength();

            modelBuilder.Entity<Ruhsat1_TB>()
                .Property(e => e.AzamiYukluAgirlik)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ruhsat1_TB>()
                .Property(e => e.RoAzamiYukluAgirlik)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ruhsat1_TB>()
                .Property(e => e.GucAgirlikOrt)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sirketler_TB>()
                .Property(e => e.Tel1)
                .IsUnicode(false);

            modelBuilder.Entity<Sirketler_TB>()
                .Property(e => e.Tel2)
                .IsUnicode(false);

            modelBuilder.Entity<Sirketler_TB>()
                .Property(e => e.Faks)
                .IsUnicode(false);

            modelBuilder.Entity<Subeler_TB>()
                .Property(e => e.Tel1)
                .IsUnicode(false);

            modelBuilder.Entity<Subeler_TB>()
                .Property(e => e.Tel2)
                .IsUnicode(false);

            modelBuilder.Entity<Subeler_TB>()
                .Property(e => e.Faks)
                .IsUnicode(false);

            modelBuilder.Entity<Tarife_TB>()
                .Property(e => e.YıkamaFiyat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tarife_TB>()
                .Property(e => e.TarifeFiyat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YediEminCikisKayit_TB>()
                .Property(e => e.AracPlaka)
                .IsUnicode(false);

            modelBuilder.Entity<YediEminCikisKayit_TB>()
                .Property(e => e.OtoparkUcret)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YediEminCikisKayit_TB>()
                .Property(e => e.CekiciUcret)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YediEminCikisKayit_TB>()
                .Property(e => e.ToplamUcret)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YediEminHasar_TB>()
                .Property(e => e.Plaka)
                .IsUnicode(false);
        }
    }
}
