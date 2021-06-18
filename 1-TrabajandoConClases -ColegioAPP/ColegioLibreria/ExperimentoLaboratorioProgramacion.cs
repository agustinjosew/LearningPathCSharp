using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibreria
{
    public class ExperimentoLaboratorioProgramacion : IPuntaje
    {
        public string Hipotesis { get; set; }
        public string Materiales { get; set; }
        public string MetodoExperimento { get; set; }
        public string Conclusion { get; set; }
        public float Puntaje { get; set; }
        public float PuntajeMaximo { get; set; }
    }
}
