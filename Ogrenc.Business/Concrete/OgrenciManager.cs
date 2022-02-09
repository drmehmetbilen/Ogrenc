using Ogrenc.Business.Abstract;
using Ogrenc.DataAccess.Abstract;
using Ogrenc.DataAccess.Concrete;
using Ogrenc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ogrenc.Business.ExtraClassesConcrete;
using Ogrenc.Business.Abstract;
using Ogrenc.Business.ExtraClassesAbstract;

namespace Ogrenc.Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
         IOgrenciRepository repository;
        IFunctions functions;
        public OgrenciManager(IOgrenciRepository _repository,IFunctions _functions)
        {
            repository = _repository;
            functions = _functions;
        }

        public Ogrenci addOgrenci(Ogrenci ogrenci)
        {
           return repository.addOgrenci(ogrenci);
            
        }

        public string getAllOgrencis()
        {


            var result = repository.getAllOgrencis().Select(S => new
            {
                id =S.IdOgrenci,
                adSoyad = S.AdSoyad,
                anaDal = S.Anadal.Ad,
                yanDal = S.Yandal !=null ? S.Yandal.Ad : "Bölüm Yok"
                
            }).ToList();

           

            return functions.Serialize(result);
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
