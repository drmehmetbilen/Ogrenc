using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Entities
{
    public class DonemDersleri
    {
        [Key]
        public int IdDonem { get; set; }
        public Ogrenci? ogrenci;
        public Ders? ders;
        public string Donem { get; set; }
    }
}
