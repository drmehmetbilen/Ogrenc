using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Concrete
{
    public class BolumRepository : GenericRepository<Bolum>
    {
        public OgrenciDbContext db;
        public BolumRepository(OgrenciDbContext _db) : base(_db)
        {
            db = _db;
        }

    }
}
