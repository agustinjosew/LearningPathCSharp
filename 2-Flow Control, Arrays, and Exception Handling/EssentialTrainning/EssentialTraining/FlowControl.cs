using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class FlowControl
    {
        public bool MiColorPreferidoEsAzul(string color)
        {
            if (color.ToLower() == "Azul")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
