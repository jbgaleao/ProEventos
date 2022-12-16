using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "EXEMPLO DE GET";
        }

        [HttpPost]
        public string Post()
        {
            return "EXEMPLO DE POST";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"EXEMPLO DE PUT COM ID = {id}";
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"EXEMPLO DE DELETE COM ID = {id}";
        }
    }
}
