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
        public void removeOgrenci(Ogrenci ogrenci);
        public Ogrenci getOgrenciById(int id);
    }
}
