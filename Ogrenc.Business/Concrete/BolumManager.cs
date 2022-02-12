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
    public class BolumManager : GenericManager<Bolum, BolumDTO>
    {
        IGenericRepository<Bolum> repository;
        IFunctions functions;
        public BolumManager(IGenericRepository<Bolum> _repository, IFunctions _functions) : base(_repository, _functions)
        {
            repository = _repository;
            functions = _functions;

        }
    }
}
