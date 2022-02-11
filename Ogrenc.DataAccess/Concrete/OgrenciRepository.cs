using Microsoft.EntityFrameworkCore;
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
            var sonuc = db.Ogrencis.Include(s => s.Anadal).Include(s => s.Yandal);

            return sonuc.ToList() ;
        }

        public Ogrenci getOgrenciById(int id)
        {
            var result =  db.Ogrencis.Include(s => s.Anadal).Include(s => s.Yandal).Where(s => s.IdOgrenci == id).SingleOrDefault();

            return result;



        }

        public bool removeOgrenci(int id)
        {
            var removeOgrenci = db.Ogrencis.Find(id);
            if (removeOgrenci!=null)
            {
                db.Ogrencis.Remove(removeOgrenci);
                db.SaveChanges();
                return true;
            }
            return false;
          

        }
    }
}
