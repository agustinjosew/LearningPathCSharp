using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibreria
{
    public class UtilityPuntaje
    {
        public static IPuntaje MejorDeDos (IPuntaje Tarea1, IPuntaje Tarea2)
        {
            var puntaje1 = Tarea1.Puntaje / Tarea1.PuntajeMaximo;
            var puntaje2 = Tarea2.Puntaje / Tarea2.PuntajeMaximo;

            if (puntaje1 > puntaje2)
            {
                return Tarea1;
            }
            else
            {
                return Tarea2;
            }
        }
    }
}
