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
        [StringLength(100)]
        public string Ad { get; set; }
        public string Kod { get; set; }

        public virtual List<DonemDersleri>? DonemDersleris { get; set; }
        
    }

}
