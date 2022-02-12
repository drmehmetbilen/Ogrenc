using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ogrenc.DataAccess.Abstract;
using Ogrenc.Entities;

namespace Ogrenc.DataAccess.Concrete
{
    public class DersRepository : GenericRepository<Ders>
    {
        OgrenciDbContext db;
        public DersRepository(OgrenciDbContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
