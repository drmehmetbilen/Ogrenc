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
    public class OgrenciManager : GenericManager<Ogrenci, OgrenciDTO>
    {
        IGenericRepository<Ogrenci> repository;
        IFunctions functions;
        public OgrenciManager(IGenericRepository<Ogrenci> _repository, IFunctions _functions) : base(_repository, _functions)
        {
            repository = _repository;
            functions = _functions;

        }
    }
}
