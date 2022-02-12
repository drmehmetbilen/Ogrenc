using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ogrenc.Entities;
using Ogrenc.Business.Abstract;

namespace Ogrenc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BolumController : ControllerBase
    {
        IGenericService<BolumDTO> service;
        public BolumController(IGenericService<BolumDTO> _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult GET()
        {
            var result = service.getAll();
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]

        public IActionResult GET(int id)
        {
            var result = service.getByID(id);
            if (result!=null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult POST([FromBody] BolumDTO record)
        {

           var result =  service.add(record);

            return CreatedAtAction("get", new {id=result.IdBolum},true);
        
        }

        [HttpDelete("{id}")]
        public IActionResult DELETE(int id)
        {
            var result =  service.remove(id);
            if (result)
            {
                return Ok();
            }
            
                return BadRequest();
            
        }
    }
}
