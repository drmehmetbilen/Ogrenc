using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Entities
{
    public class Ders : IEntityWithId
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        public int Kredi { get; set; }
        public int Saat { get; set; }


        [ForeignKey("IdBolum")]
        public int? IdBolum { get; set; }
        public Bolum? Bolum { get; set; }

        [ForeignKey("IdOgretimElemani")]
        public int? IdOgretimElemani { get; set; }
        public OgretimElemani? OgretimElemani { get; set; }

        

    }

    public class DersDTO : IEntityWithId
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public int? IdOgretimElemani { get; set; }
        public int? IdBolum { get; set; }

        public string? OgretimElemaniAdSoyad { get; set; }
        public string? BolumAd { get; set; }


        //public int? IdBolum { get; set; }
        //public int? IdOgretimElemani { get; set; }
        //public string? OgretimElemaniAd { get; set; }

    }
}
