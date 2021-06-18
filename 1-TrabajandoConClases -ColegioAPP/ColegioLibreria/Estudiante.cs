using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibreria
{
    public class Estudiante : Persona
    {
        public enum NivelesCursos{Ingresante, Junior, Senior, AcomodadoVagoPolitico, VacunadoVIP_K}
        public NivelesCursos NivelCurso { get; set; }

        public override float ComputarPromedioDelCurso()
        {
            return 4.54f;
        }
        public override string EnviarMensaje(string mensaje)
        {
            var original = base.EnviarMensaje(mensaje);
            var sb       = new StringBuilder(original);
            sb.Append("Este mensaje es privado y confidencial.");
            return sb.ToString();

        }
    }
}
