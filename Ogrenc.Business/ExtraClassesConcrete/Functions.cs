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
                      .ForMember(dest => dest.Yandal, act=>act.Ignore())
                      .ForMember(dest => dest.Anadal, act=>act.Ignore());                      ;
                      
                      
                      
                     
                     
                      
                 }

                 

                );

            mapper = new Mapper(mapConfig);



        }

        public Mapper Mapper()
        {
            return mapper;     
        
        }

      
    }
}
