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

        public bool MiColorFavoritoEsROjo(string color)
        {
            if (color.ToLower() == "Rojo") return true;
            return false;
        }

        public bool MiColorPreferidoEsVerde(string color)
        {
            return (color.ToLower() == "Verde") ? true : false;
        }
        
    }
}
