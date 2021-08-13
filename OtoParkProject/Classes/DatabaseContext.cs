
using OtoParkProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoParkProject.Classes
{
    public class DatabaseContext : DbContext
    {
        //public DatabaseContext(string connString= "Server=Merve;Database=OtoPark_Database;User ID=mervek;Password=MevsiM95;Trusted_Connection=False;")
        //{
        //    this.Database.Connection.ConnectionString = connString;
        //}
       // bu metod hangi veri tabanıyla ilişkileneceğini belirtir
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=Merve;Database=OtoPark_Database; User Id=mervek;Password=MevsiM95;");
        //}

        public DbSet<Sirket> Sirketler_TB { get; set; }
        public DbSet<Sube> Subeler_TB { get; set; }
        public DbSet<Personel> Personel_TB { get; set; }
        public DbSet<Arac> Arac_TB { get; set; }
        public DbSet<Arac_Tip> AracTip_TB { get; set; }
        public DbSet<Tarife_Tip> TarifeTip_TB { get; set; }
        public DbSet<Tarife> Tarife_TB { get; set; }
        public DbSet<Abonelik_Tip> AbonelikTip_TB { get; set; }
        public DbSet<Abonelik> Abonelik_TB { get; set; }
        public DbSet<Cari> Cari_TB { get; set; }
        public DbSet<CekiciFirma> CekiciFirma_TB { get; set; }
    }
}
