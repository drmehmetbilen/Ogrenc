using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ogrenc.Business.Abstract;
using Ogrenc.Business.Concrete;
using Ogrenc.Entities;

namespace Ogrenc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {

        IOgrenciService service;

        public OgrenciController(IOgrenciService _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            List<OgrenciDTO> result = service.getAllOgrencis();
            if (result.Count==0)
            {
                 return NotFound();
            }
            return Ok(result);
           
                


        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            OgrenciDTO result = service.getOgrenciById(id);
            if (result != null)
            {
                return Ok(result);

            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] OgrenciDTO ogrenci)
        {



            var result = service.addOgrenci(ogrenci);

            return CreatedAtAction("Get", new { id = result.IdOgrenci }, result);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = service.removeOgrenci(id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
            

        }

    }
}
