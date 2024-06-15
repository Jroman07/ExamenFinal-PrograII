using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Matricula
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public int NivelId { get; private set; }
        public int CarreraId { get; private set; }
        public int CursoId { get; set; }
        [JsonIgnore]
        public Estudiante? Estudiante { get; set; }
        [JsonIgnore]
        public Nivel? Nivel { get; set; }
        [JsonIgnore]
        public Carrera? Carrera { get; set; }
        [JsonIgnore]
        public Curso? Curso { get; set; }

        public void Sets(Curso curso)
        {
            this.CarreraId = curso.idCarrera;
            this.NivelId = curso.idNivel;
        }
    }
}
