using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Entities
{
    public class Ders
    {
        [Key]
        public int IdDers { get; set; }

        [StringLength(50)]
        public int Ad { get; set; }

        public int Kredi { get; set; }
        public int Saat { get; set; }


        [ForeignKey("IdBolum")]
        public int? IdBolum { get; set; }
        public Bolum? Bolum { get; set; }

        [ForeignKey("IdOgretimElemani")]
        public int? IdOgretimElemani { get; set; }
        public OgretimElemani? OgretimElemani { get; set; }

        

    }

    public class DersDTO
    {
        public int IdDers { get; set; }

    }
}
