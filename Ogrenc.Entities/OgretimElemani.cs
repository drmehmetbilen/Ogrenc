using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Entities
{
    public class OgretimElemani : IEntityWithId
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string AdSoyad { get; set; }

        [StringLength(15)]

        public string SicilNo { get; set; }

        [ForeignKey("idBolum")]
        public int? idBolum { get; set; }

        public Bolum? Bolum { get; set; }

        public virtual List<Ders> DersVerilen { get; set; }
        public OgretimElemani()
        {
            AdSoyad = "";
        }
    }

    public class OgretimElemaniDTO : IEntityWithId
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string SicilNo { get; set; }

        public int? idBolum { get; set; }
        public string? BolumAd { get; set; }



    }
}
