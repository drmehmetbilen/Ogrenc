using Ogrenc.Business.ExtraClassesAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using AutoMapper;
using Ogrenc.Entities;
using Ogrenc.Business.Concrete;

namespace Ogrenc.Business.ExtraClassesConcrete
{
    public class Functions : IFunctions
    {
        Mapper mapper;
        
        public Functions()
        {


            var mapConfig = new MapperConfiguration(
                cfg=>
                {
                    cfg.CreateMap<Ogrenci, OgrenciDTO>()
            
                      .ForMember(dest => dest.YandalAd, act => act.MapFrom(src => src.Yandal != null ? src.Yandal.Ad : "YOK"))
                      .ForMember(dest => dest.AnadalAd, act => act.MapFrom(src => src.Anadal != null ? src.Anadal.Ad : "YOK"))
                      
                      .ReverseMap()
                      .ForMember(dest=>dest.AnaDalId, act=>act.MapFrom(src=>src.AnaDalId!=0?src.AnaDalId:null))
                      .ForMember(dest => dest.YanDalId, act => act.MapFrom(src => src.YanDalId != 0 ? src.YanDalId : null))
                      .ForMember(dest => dest.Yandal, act=>act.Ignore())
                      .ForMember(dest => dest.Anadal, act=>act.Ignore());                      


                    cfg.CreateMap<Bolum, BolumDTO>()
                  .ForMember(dest => dest.AnaDalOgrenciSayisi, act => act.MapFrom(src => src.AnaDalOgrencileris != null ? src.AnaDalOgrencileris.Count() : 0))
                  .ForMember(dest => dest.YanDalOgrenciSayisi, act => act.MapFrom(src => src.YanDalOgrencileris != null ? src.YanDalOgrencileris.Count() : 0))
                  .ForMember(dest => dest.DersSayisi, act => act.MapFrom(src => src.BolumDersleris != null ? src.BolumDersleris.Count() : 0))
                  .ForMember(dest => dest.OgretimElemaniSayisi, act => act.MapFrom(src => src.BolumOgretimElemanlaris != null ? src.BolumOgretimElemanlaris.Count() : 0))
                  .ReverseMap()
                  .ForMember(dest => dest.AnaDalOgrencileris, act => act.Ignore())
                  .ForMember(dest => dest.YanDalOgrencileris, act => act.Ignore())
                  .ForMember(dest => dest.BolumDersleris, act => act.Ignore())
                  .ForMember(dest => dest.BolumOgretimElemanlaris, act => act.Ignore());

                    cfg.CreateMap<Ders, DersDTO>()
                    .ReverseMap()
                    .ForMember(dest=>dest.IdBolum, act=>act.MapFrom(s=>s.IdBolum!=0?s.IdBolum:null))
                    .ForMember(dest => dest.IdOgretimElemani, act => act.MapFrom(s => s.IdOgretimElemani != 0 ? s.IdOgretimElemani : null))
                    .ForMember(dest => dest.Bolum, act => act.Ignore())
                    .ForMember(dest => dest.OgretimElemani, act => act.Ignore());

                    cfg.CreateMap<OgretimElemani, OgretimElemaniDTO>()
                    .ReverseMap()
                    .ForMember(dest => dest.idBolum, act => act.MapFrom(s => s.idBolum != 0 ? s.idBolum : null))
                    .ForMember(dest => dest.Bolum, act => act.Ignore());






                });

            mapper = new Mapper(mapConfig);



        }

        public Mapper Mapper()
        {
            return mapper;     
        
        }

      
    }
}
