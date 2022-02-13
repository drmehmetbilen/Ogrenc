using Microsoft.EntityFrameworkCore;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ogrenc.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        DbContextOptions options;

        public SchoolDbContext(DbContextOptions _options) : base(_options)
        {
            options = _options;
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Ogrenci>()
                .HasOne(x => x.Anadal)
                .WithMany(y => y.AnaDalOgrencileris)
                .HasForeignKey(z => z.AnaDalId);

            modelBuilder.Entity<Ogrenci>()
                .HasOne(x => x.Yandal)
                .WithMany(y => y.YanDalOgrencileris)
                .HasForeignKey(z => z.YanDalId);

            modelBuilder.Entity<OgretimElemani>()
                .HasOne(x => x.Bolum)
                .WithMany(y => y.BolumOgretimElemanlaris)
                .HasForeignKey(z => z.idBolum);

            modelBuilder.Entity<Ders>()
                .HasOne(x => x.Bolum)
                .WithMany(y => y.BolumDersleris)
                .HasForeignKey(z => z.IdBolum);

            modelBuilder.Entity<Ders>()
                .HasOne(x => x.OgretimElemani)
                .WithMany(y => y.DersVerilen)
                .HasForeignKey(z => z.IdOgretimElemani);

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{ 
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Server=.;Database=dbOgrenci2;Trusted_Connection=True");



        //}
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<OgretimElemani> OgretimElemans {get;set;}
        public DbSet<Ders> Ders { get; set; }

        

       
    }
}
