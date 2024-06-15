using Entidades;
using Microsoft.AspNetCore.Mvc;
using Servicios.ServCurso;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Matricula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ISvCurso _svCurso;
        public CursoController(ISvCurso svCurso)
        {
            _svCurso = svCurso;
        }

        // POST api/<CursoController>
        [HttpPost]
        public void Post([FromBody] Curso curso)
        {
            _svCurso.AddCurso(curso);
        }
    }
}
