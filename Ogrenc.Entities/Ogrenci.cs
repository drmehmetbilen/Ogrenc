using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogrenc.Entities
{
    public class Ogrenci : IEntityWithId
    {
        [Key]
        public int Id { get; set; }

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

    public class OgrenciDTO : IEntityWithId
    {
    
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string OgrenciNo { get; set; }
        public int? AnaDalId { get; set; }

        public int? YanDalId { get; set; }

        public string? AnadalAd { get; set; }
        public string? YandalAd { get; set; }

    }
}