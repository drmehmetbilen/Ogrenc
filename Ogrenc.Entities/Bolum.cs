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
        [Required]
        public string Ad { get; set; }

        public virtual ICollection<Ogrenci>? AnaDalOgrencileri { get; set; }
        public virtual ICollection<Ogrenci>? YanDalOgrencileri { get; set; }




        public Bolum()
        {

            Ad = "";
        }
        
    }
}
