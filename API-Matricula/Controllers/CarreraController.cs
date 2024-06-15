using Microsoft.AspNetCore.Mvc;
using Entidades;
using Servicios.ServCarrera;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Matricula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {

        private ISvCarrera _svCarrera;

        public CarreraController(ISvCarrera svCarrera)
        {
            _svCarrera = svCarrera;
        }
       
        [HttpPost]
        public Carrera AddCarrera(Carrera carrera)
        {
            return _svCarrera.AddCarrera(carrera);
        }

    }
}
