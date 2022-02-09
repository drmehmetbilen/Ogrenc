using Ogrenc.DataAccess.Abstract;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Concrete
{
    public class BolumRepository : IBolumRepository
    {
        OgrenciDbContext db;
        public BolumRepository(OgrenciDbContext _db)
        {
            db = _db;
        }

        Bolum IBolumRepository.addBolum(Bolum bolum)
        {
            db.Bolums.Add(bolum);   
            db.SaveChanges();
            return bolum;
        }

        List<Bolum> IBolumRepository.getAllBolums()
        {
            return db.Bolums.ToList();
        }

        Bolum IBolumRepository.getBolumById(int id)
        {
            return db.Bolums.Find(id);
        }

        void IBolumRepository.removeBolumById(int id)
        {
            db.Bolums.Remove(db.Bolums.Find(id));
            db.SaveChanges();
        }

        Bolum IBolumRepository.updateBolum(Bolum bolum)
        {
            db.Bolums.Find(bolum.IdBolum);
            db.Update(bolum);
            db.SaveChanges();
            return bolum;
        }
    }
}
