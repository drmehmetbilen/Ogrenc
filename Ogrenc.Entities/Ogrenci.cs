using System.ComponentModel.DataAnnotations;

namespace Ogrenc.Entities
{
    public class Ogrenci
    {
        [Key]
        public int IdOgrenci { get; set; }
        [StringLength(100)]
        public string AdSoyad { get; set; }
        public string OgrenciNo { get; set; }

        public virtual List<DonemDersleri>? DonemDersleris { get; set; }



    }
}