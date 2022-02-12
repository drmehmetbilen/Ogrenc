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
    public class GenericManager<Target,TargetDTO> : Abstract.IGenericService<TargetDTO> where TargetDTO : class, new() where Target : class, new()
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

        public TargetDTO add(TargetDTO record)
        {

            Target newRecord = new Target();
            newRecord = mapper.Map(record, newRecord);
            var AddedRecord =  repository.addOne(newRecord);
            var recordDTO = mapper.Map<TargetDTO>(AddedRecord);
            return recordDTO;
            
        }

        public List<TargetDTO> getAll()
        {
            var result = repository.getAll().Select(s => mapper.Map<TargetDTO>(s)).ToList();
            return result;  
            
        }

        public TargetDTO getByID(int id)
        {
            var result = repository.getById(id);
            return mapper.Map<TargetDTO>(result);
        }

        public bool remove(int id)
        {
            return repository.removeOne(id);
        }
    }
}
