using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Entities
{
    
    public class Bolum : IEntityWithId
    {
        [Key]
        public int Id { get; set; }


        [StringLength(50)]
        [Required]
        public string Ad { get; set; }

        public virtual ICollection<Ogrenci>? AnaDalOgrencileris { get; set; }
        public virtual ICollection<Ogrenci>? YanDalOgrencileris { get; set; }
        public virtual ICollection<Ders>? BolumDersleris { get; set; }
        public virtual ICollection<OgretimElemani> BolumOgretimElemanlaris { get; set; }

        public Bolum()
        {

            Ad = "";
        }
        
    }

    public class BolumDTO : IEntityWithId 
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public int AnaDalOgrenciSayisi { get; set; }
        public int YanDalOgrenciSayisi { get; set; }

        public int DersSayisi { get; set; }
        public int OgretimElemaniSayisi { get; set; }
    }
}
