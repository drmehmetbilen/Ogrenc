using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Concrete
{
    public class OgretimElemaniRepository : GenericRepository<OgretimElemani>
    {
        public OgrenciDbContext db;
        public OgretimElemaniRepository(OgrenciDbContext _db) : base(_db)
        {
            db = _db;
        }

        public override bool removeOne(int id)
        {
            var result = getById(id);
            
            if (result != null)
            {

                db.OgretimElemans.Remove(result);

                db.SaveChanges();
                return true;

            }
            return false;
        }
    }

}
