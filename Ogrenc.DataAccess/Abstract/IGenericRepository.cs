using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ogrenc.Entities;

namespace Ogrenc.DataAccess.Abstract
{
    public interface IGenericRepository<Target> where Target : class
    {
        public List<Target> getAll(bool load=false);
        public Target addOne(Target record);
        public bool removeOne(int id);
        public Target getById(int id);

        public bool update(Target record);
    }
}
