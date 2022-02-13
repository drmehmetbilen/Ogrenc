using Ogrenc.Business.ExtraClassesAbstract;
using Ogrenc.DataAccess.Abstract;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Business.Concrete
{
    public class DersManager : GenericManager<Ders, DersDTO>
    {
        IGenericRepository<Ders> repository;
        IFunctions functions;

        public DersManager(IGenericRepository<Ders> _repository, IFunctions _functions) : base(_repository, _functions)
        {
            this.repository = _repository;
            this.functions = _functions;
        }
    }
}
