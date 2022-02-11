using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Abstract
{
    public interface IOgrenciRepository
    {
        public List<Ogrenci> getAllOgrencis();
        public Ogrenci addOgrenci(Ogrenci ogrenci);
        public bool removeOgrenci(int id);
        public Ogrenci getOgrenciById(int id);
    }
}
