using Microsoft.EntityFrameworkCore;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ogrenc.DataAccess
{
    public class OgrenciDbContext : DbContext
    {
        DbContextOptions options;

        public OgrenciDbContext(DbContextOptions _options) : base(_options)
        {
            options = _options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ogrenci>()
                .HasOne(x=>x.Anadal)
                .WithMany(y=>y.AnaDalOgrencileri)
                .HasForeignKey(z=>z.AnaDalId);

            modelBuilder.Entity<Ogrenci>()
                .HasOne(x => x.Yandal)
                .WithMany(y => y.YanDalOgrencileri)
                .HasForeignKey(z => z.YanDalId);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{ 
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Server=.;Database=dbOgrenci2;Trusted_Connection=True");



        //}
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
        

       
    }
}
