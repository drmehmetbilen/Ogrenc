using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Entities
{
    public class Bolum
    {
        [Key]
        public int IdBolum { get; set; }
        [StringLength(50)]
        public string Ad { get; set; }

        
        [InverseProperty("Anadal")]
        public  List<Ogrenci>? AnadalOgrListesi { get; set; }
        [InverseProperty("Yandal")]
        public  List<Ogrenci>? YandalOgrListesi { get; set; }
        //[InverseProperty("BolumDers")]
        public virtual List<Ders> BolumDersListesi { get; set; }

    }
}
