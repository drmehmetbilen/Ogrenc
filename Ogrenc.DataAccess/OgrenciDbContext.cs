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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{ 
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Server=.;Database=dbOgrenci2;Trusted_Connection=True");



        //}
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Ders> Derss { get; set; }

        public DbSet<DonemDersleri> DonemDersleris { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
        

       
    }
}
