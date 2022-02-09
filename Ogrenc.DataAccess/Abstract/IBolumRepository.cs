using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.DataAccess.Abstract
{
    public   interface IBolumRepository
    {
        public List<Bolum> getAllBolums (); 
        public Bolum getBolumById (int id);
        public Bolum addBolum(Bolum bolum);
        public void removeBolumById(int id);
        public Bolum updateBolum(Bolum bolum);
    }
}
