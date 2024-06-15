using Microsoft.AspNetCore.Mvc;
using Servicios.ServMatricula;
using Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Matricula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MatriculaController : ControllerBase
    {
        private ISvMatricula _svMatricula;
        
        public MatriculaController(ISvMatricula svMatricula)
        {
            _svMatricula = svMatricula;

        }

        // GET: api/<MatriculaController>
        [HttpGet]
        public List<Matricula> GetAll()
        {
            return _svMatricula.GetAllMatriculas();
        }

        // GET api/<MatriculaController>/5
        [HttpGet("Carrera")]
        public List<Matricula> GetByCarrera(int id)
        {
            return _svMatricula.GetAllMatriculaPorCarrera(id);
        }

        [HttpGet("Carrera y Nivel")]
        public List<Matricula> GetporMatriculaandNivel(int idCarrera,int idNivel)
        {
            return _svMatricula.GetAllMatriculaPorCarrera_Nivel(idCarrera,idNivel);
        }


        [HttpGet("Curso")]
        public List<Matricula> GetPorcurso(int curso)
        {
            return _svMatricula.GetAllMatriculaPorCurso(curso);
        }


        // POST api/<MatriculaController>
        [HttpPost]
        public Matricula AddMatricula([FromBody] Matricula matricula)
        {
            return _svMatricula.AddMatricula(matricula);
        }
        [HttpPost("Lista")]
        public List<Matricula> AddListaMatriculas([FromBody] List<Matricula> matriculas)
        {
            return _svMatricula.AddMatriculas(matriculas);
        }
    }
}
