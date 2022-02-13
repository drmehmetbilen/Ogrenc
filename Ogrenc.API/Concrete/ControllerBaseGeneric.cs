using Microsoft.AspNetCore.Mvc;
using Ogrenc.Business.Abstract;
using Ogrenc.Entities;

namespace Ogrenc.API.Concrete
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class ControllerBaseGeneric<TargetDTO> : ControllerBase where TargetDTO : class, new()
        {

            IGenericService<TargetDTO> service;
            public ControllerBaseGeneric(IGenericService<TargetDTO> _service)
            {
                service = _service;
            }
            [HttpGet]
            public IActionResult Get()
            {

                var result = service.getAll(true);
                if (result.Count > 0)
                {
                    return Ok(result);
                }
                return NotFound();
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var result = service.getByID(id);
                if (result != null)
                {
                    return Ok(result);

                }

                return NotFound();

            }

            [HttpPost]
            public IActionResult Post([FromBody] TargetDTO record)
            {

                var result = service.add(record);

                return CreatedAtAction("get", new { id = ((IEntityWithId)result).Id }, true);


            }



            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {

                bool sonuc
                    = service.remove(id);

                if (sonuc)
                {
                    return Ok(sonuc);
                }

                return NotFound();


            }

            [HttpPut("{id}")]
            public IActionResult Update(int id, [FromBody] TargetDTO record)
            {
                if (id != ((IEntityWithId)record).Id)
                {
                    return BadRequest();
                }

                var result = service.update(id, record);
                if (result)
                {
                    return AcceptedAtAction("get", new { id = id }, true);
                }
                return BadRequest();
            }



        }
    }

