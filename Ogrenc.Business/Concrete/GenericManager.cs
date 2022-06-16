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

        public List<TargetDTO> getAll(bool load = false)
        {


            var result = repository.getAll(load).Select(s => mapper.Map<TargetDTO>(s)).ToList();
            // base sınıfta tolist yapmak tehlikeli olabilir. dikkatli olmak lazım
            
            // burada   
            // var result = repository.getAll(load);
            // var lastresult=   mapper.Map<List<TargetDTO>>(result).ToList();
            //biçiminde list olarak mapleme yapabilirsin
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

        public bool update(int id, TargetDTO record)
        {
            
            var recordOriginal = mapper.Map<TargetDTO, Target>(record);
            
            return repository.update(recordOriginal);

        }
    }
}
