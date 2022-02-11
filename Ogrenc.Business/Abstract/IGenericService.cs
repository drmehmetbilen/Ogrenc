using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Business.Abstract
{
    public interface IGenericService<Target, TargetDTO> where Target : class where TargetDTO : class
    {
        public List<TargetDTO> getAllOgrencis();
        public TargetDTO addOgrenci(TargetDTO ogrenci);
        public bool removeOgrenci(int id);
        public TargetDTO getOgrenciById(int id);
    }
    
    
}
