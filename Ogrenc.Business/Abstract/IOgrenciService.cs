using Ogrenc.Business.Concrete;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenc.Business.Abstract
{
    
    public interface IOgrenciService
    {
        public List<OgrenciDTO> getAllOgrencis();
        public OgrenciDTO addOgrenci(OgrenciDTO ogrenci);
        public bool removeOgrenci(int id);
        public OgrenciDTO getOgrenciById(int id);
    }
}
