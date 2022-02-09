using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogrenc.Entities
{
    public class Ogrenci
    {
        [Key]
        public int IdOgrenci { get; set; }
        [StringLength(100)]
        public string AdSoyad { get; set; }
        public string OgrenciNo { get; set; }

        [ForeignKey("IdAnadal")]
        public  Bolum Anadal { get; set; }

        [ForeignKey("IdYanDal")]
        public  Bolum? Yandal { get; set; }
        public virtual List<DonemDersleri>? DonemDersleris { get; set; }
    }
}