using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ogrenc.Entities;
using Ogrenc.DataAccess;
using Ogrenc.DataAccess.Abstract;
using Ogrenc.Business.ExtraClassesAbstract;

namespace Ogrenc.Business.Concrete
{
    public class OgretimElemaniManager : GenericManager<OgretimElemani, OgretimElemaniDTO>
    {
        IGenericRepository<OgretimElemani> repository;
        IFunctions functions;
        public OgretimElemaniManager(IGenericRepository<OgretimElemani> _repository, IFunctions _functions) : base(_repository, _functions)
        {
            this.repository = _repository;
                functions = _functions;
        }

    }
}
