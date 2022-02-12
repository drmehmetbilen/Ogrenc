using Microsoft.EntityFrameworkCore;
using Ogrenc.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Concrete
{
    public class GenericRepository<Target> : IGenericRepository<Target> where  Target : class
    {
        OgrenciDbContext db;
        DbSet<Target> genericTable;
        
        public GenericRepository(OgrenciDbContext _db)
        {
            db = _db;
            genericTable = db.Set<Target>();

        }

        public Target addOne(Target record)
        {
            genericTable.Add(record);
            db.SaveChanges();
            
            return record;

        }

        public List<Target> getAll()
        {
            var result = genericTable.ToList();
            return result;
        }

        public Target getById(int id)
        {
            var result = genericTable.Find(id); //override etmeden include etme????
            return result;

        }

        public virtual bool removeOne(int id)
        {
            var result = getById(id);
            if (result!=null)
            {
                genericTable.Remove(result);
                db.SaveChanges();
                return true;

            }
            return false;
        }
    }
}
