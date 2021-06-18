using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibreria
{
    public class Profesor : Persona
    {
        public string Materia { get; set; }
        public override float ComputarPromedioDelCurso()
        {
            //TODO: arreglar despues
            return 0.4f;
        }
    }
}
