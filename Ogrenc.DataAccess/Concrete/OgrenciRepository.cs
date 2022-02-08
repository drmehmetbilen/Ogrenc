using Ogrenc.DataAccess.Abstract;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Concrete
{
    public class OgrenciRepository : IOgrenciRepository
    {
        OgrenciDbContext db;
        public OgrenciRepository(OgrenciDbContext _db)
        {
            db = _db;
        }

        public Ogrenci addOgrenci(Ogrenci ogrenci)
        {
            db.Ogrencis.Add(ogrenci);
            db.SaveChanges();
            return ogrenci;
            
        }

        public List<Ogrenci> getAllOgrencis()
        {
            return db.Ogrencis.ToList();
        }

        public Ogrenci getOgrenciById(int id)
        {
            return db.Ogrencis.Find(id);

        }

        public void removeOgrenci(Ogrenci ogrenci)
        {
            db.Ogrencis.Remove(ogrenci);
            db.SaveChanges();

        }
    }
}
