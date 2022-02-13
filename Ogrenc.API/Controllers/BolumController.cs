using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ogrenc.API.Concrete;
using Ogrenc.Business.Abstract;
using Ogrenc.Entities;

namespace Ogrenc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BolumController : ControllerBaseGeneric<BolumDTO>
    {
        IGenericService<BolumDTO> service;
        public BolumController(IGenericService<BolumDTO> _service) : base(_service)
        {
            service = _service;
        }
    }
}
