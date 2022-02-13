using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ogrenc.API.Concrete;
using Ogrenc.Business.Abstract;
using Ogrenc.Entities;

namespace Ogrenc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class OgretimElemaniController : ControllerBaseGeneric<OgretimElemaniDTO>
    {
        IGenericService<OgretimElemaniDTO> service;
        public OgretimElemaniController(IGenericService<OgretimElemaniDTO> _service) : base(_service)
        {
            service = _service;
        }
    }
}
