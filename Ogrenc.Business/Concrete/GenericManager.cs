using AutoMapper;
using Ogrenc.Business.ExtraClassesAbstract;
using Ogrenc.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Business.Concrete
{
    public class GenericManager<Target, TargetDTO> : Abstract.IGenericService<Target, TargetDTO> where Target : class where TargetDTO : class
    {
        IGenericRepository<Target> repository;
        IFunctions functions;

        Mapper mapper;

        public GenericManager(IGenericRepository<Target> _repository, IFunctions _functions)
        {
            repository = _repository;
            functions = _functions;
            mapper = functions.Mapper();
        }
        

        public TargetDTO addOgrenci(TargetDTO ogrenci)
        {
            throw new NotImplementedException();
        }

        public List<TargetDTO> getAllOgrencis()
        {
            throw new NotImplementedException();
        }

        public TargetDTO getOgrenciById(int id)
        {
            throw new NotImplementedException();
        }

        public bool removeOgrenci(int id)
        {
            throw new NotImplementedException();
        }
    }
}
