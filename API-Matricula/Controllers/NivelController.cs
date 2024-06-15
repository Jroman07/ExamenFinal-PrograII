using Entidades;
using Microsoft.AspNetCore.Mvc;
using Servicios.ServNivel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Matricula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NivelController : ControllerBase
    {
        private readonly ISvNivel _svNivel;
        public NivelController(ISvNivel svNivel)
        {
            _svNivel = svNivel;
        }
        // POST api/<NivelController>
        [HttpPost]
        public void Post([FromBody] Nivel nivel)
        {
            _svNivel.AddNivel(nivel);
        }

    }
}
