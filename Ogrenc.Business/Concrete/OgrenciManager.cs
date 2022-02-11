using AutoMapper;
using Ogrenc.Business.Abstract;
using Ogrenc.Business.ExtraClassesAbstract;
using Ogrenc.DataAccess.Abstract;
using Ogrenc.Entities;

namespace Ogrenc.Business.Concrete
{
    public class OgrenciDTO
    {
        public int IdOgrenci { get; set; }
        public string AdSoyad { get; set; }
        public string OgrenciNo { get; set; }
        public int? AnaDalId { get; set; }

        public int? YanDalId { get; set; }

        public string? AnadalAd { get; set; }
        public string? YandalAd { get; set; }

    }

    public class OgrenciManager : IOgrenciService
    {
        IOgrenciRepository repository;
        IFunctions functions;

        Mapper mapper;

        public OgrenciManager(IOgrenciRepository _repository, IFunctions _functions)
        {
            repository = _repository;


            functions = _functions;
            mapper = functions.Mapper();
        }

        public Ogrenci addOgrenci(OgrenciDTO ogrenci)
        {


            Ogrenci ogr = new Ogrenci();
            ogr = mapper.Map(ogrenci,ogr);
            return repository.addOgrenci(ogr);

        }

        public List<OgrenciDTO> getAllOgrencis()
        {


            var resultDTO = repository.getAllOgrencis().Select(S => mapper.Map<OgrenciDTO>(S)).ToList();
            return resultDTO;
        }

        public OgrenciDTO getOgrenciById(int id)
        {
            var result = repository.getOgrenciById(id);
            OgrenciDTO resultDTO = mapper.Map<OgrenciDTO>(result);
            return resultDTO;

        }

        public bool removeOgrenci(int id)
        {
           return  repository.removeOgrenci(id);

           
        }
    }
}
