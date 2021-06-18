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
    }
}
