using Microsoft.EntityFrameworkCore;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Concrete
{
    public class OgrenciRepository : GenericRepository<Ogrenci>
    {
        public SchoolDbContext db;
        public OgrenciRepository(SchoolDbContext _db) : base(_db)
        {
            db = _db;
        }


    }
}
