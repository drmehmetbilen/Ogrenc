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
        SchoolDbContext db;
        public DersRepository(SchoolDbContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
