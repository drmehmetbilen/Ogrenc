using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Business.Abstract
{
    public interface IGenericService<TargetDTO> 
        where TargetDTO : class, new()
    {
        public List<TargetDTO> getAll(bool load =false);
        public TargetDTO add(TargetDTO record);
        public bool remove(int id);
        public TargetDTO getByID(int id);
        public bool update(int id,TargetDTO record);
    }
    
    
}
