using Ogrenc.Business.Abstract;
using Ogrenc.DataAccess.Abstract;
using Ogrenc.DataAccess.Concrete;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ogrenc.Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
         IOgrenciRepository repository;
        public OgrenciManager(IOgrenciRepository _repository)
        {
            repository = _repository;
        }

        public Ogrenci addOgrenci(Ogrenci ogrenci)
        {
           return repository.addOgrenci(ogrenci);
            
        }

        public List<Ogrenci> getAllOgrencis()
        {

            return repository.getAllOgrencis();
        }

        public Ogrenci getOgrenciById(int id)
        {
            return repository.getOgrenciById(id);
        }

        public void removeOgrenci(Ogrenci ogrenci)
        {
            repository.removeOgrenci(ogrenci);
        }
    }
}
