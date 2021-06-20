using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class FlowControl3_Loops
    {
        public int ForLoop()
        {
            var suma = 0;
            for (var i = 0; i < 100; i++)
            {
                suma = suma + i;
            }
            return suma;
        }
    }
}
