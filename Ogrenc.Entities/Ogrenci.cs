using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogrenc.Entities
{
    public class Ogrenci
    {
        [Key]
        public int IdOgrenci { get; set; }

        [StringLength(100)]
        [Required]
        public string AdSoyad { get; set; }
        public string? OgrenciNo { get; set; }

      

 
        [ForeignKey("AnaDalId")]
        public int? AnaDalId { get; set; }
        public  Bolum? Anadal { get; set; }

        [ForeignKey("YanDalId")]
        public int? YanDalId { get; set; }
        public  Bolum? Yandal { get; set; }

        public Ogrenci()
        {
            AdSoyad = "";
        }
    }
}