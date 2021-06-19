using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] ListaSuper;
        public SimpleArray()
        {
            ListaSuper = new string[4]
            {
                "Pan",
                "Milf",
                "Huevitos",
                "TuVieja"
            };
        }

        public override string ToString()
        {
            return "Hay " 
                + ListaSuper.Length + 
                "items en la lista del Super : " 
                + ListaSuper.ToString();
        }
    }
}
