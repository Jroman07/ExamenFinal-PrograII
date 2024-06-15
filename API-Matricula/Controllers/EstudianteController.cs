using Entidades;
using Microsoft.AspNetCore.Mvc;
using Servicios.ServEstudiante;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Matricula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly ISvEstudiante _svEstudiente;
        public EstudianteController(ISvEstudiante svEstudiante)
        {
            _svEstudiente = svEstudiante;
        }
        
        // POST api/<EstudianteController>
        [HttpPost]
        public void Post([FromBody] Estudiante estudiante)
        {
            _svEstudiente.addStudent(estudiante);
        }
    }
}
