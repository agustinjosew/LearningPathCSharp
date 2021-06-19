using System.Collections.Generic;

namespace EssentialTraining
{
    public class SalsaSuper
    {
        public List<string> Salsas { get; set; }

        //constructor
        public SalsaSuper()
        {
            Salsas = new List<string>();
        }
        public bool LaSalsaExiste (string salsa)
        {
            return Salsas.Contains(salsa);
        }


    }
}
