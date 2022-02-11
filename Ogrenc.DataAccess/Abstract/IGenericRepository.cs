using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ogrenc.Entities;

namespace Ogrenc.DataAccess.Abstract
{
    public interface IGenericRepository<Target> where Target : class
    {
        public List<Target> getAll();
        public Target addOne(Target record);
        public bool removeOne(int id);
        public Target getById(int id);
    }
}
