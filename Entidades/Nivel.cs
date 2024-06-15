using System.Text.Json.Serialization;

namespace Entidades
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Curso>? Cursos { get; set; }
    }
}
