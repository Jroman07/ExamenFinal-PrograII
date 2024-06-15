using Microsoft.Extensions.DependencyInjection;
using Servicios.ServCarrera;
using Servicios.ServCurso;
using Servicios.ServEstudiante;
using Servicios.ServMatricula;
using Servicios.ServNivel;

namespace Servicios
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ISvCarrera, SvCarrera>();
            serviceCollection.AddScoped<ISvEstudiante, SvEstudiante>();
            serviceCollection.AddScoped<ISvMatricula, SvMatricula>();
            serviceCollection.AddScoped<ISvCurso, SvCurso>();
            serviceCollection.AddScoped<ISvNivel, SvNivel>();
        }   
    }
}
