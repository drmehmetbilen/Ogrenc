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

            string result = service.getAllOgrencis();
            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
                


        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = service.getOgrenciById(id);
            if (result != null)
            {
                return Ok(result);

            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ogrenci ogrenci)
        {
            var result = service.addOgrenci(ogrenci);

            return CreatedAtAction("Get", new { id = result.IdOgrenci }, result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();

        }

    }
}
