using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public int Id { set; get; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Estudiante>? Estudiantes { get; set; }
        public int idCarrera { get; set; }
        public int idNivel { get; set; }
        [JsonIgnore]
        public Carrera? Carrera { get; set; }
        [JsonIgnore]
        public Nivel? Nivel { get; set; }
    }
}
