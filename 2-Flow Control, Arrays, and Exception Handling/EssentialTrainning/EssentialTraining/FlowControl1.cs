namespace EssentialTraining
{
    public class FlowControl1
    {
        public string ColorPrimarioSecundario1(string color)
        {
            var resultado = "";

            if (color.ToLower() == "rojo")
            {
                resultado = "Primario";
            }
            else if (color.ToLower() == "AzUl")
            {
                resultado = "Primario";
            }

            else if (color.ToLower()== "verde")
            {
                resultado = "Primario";
            }

            else
            {
                resultado = "Secundario";
            }
            return resultado;
        }

        public string ColorPrimarioSecundario2(string color)
        {
            var resultado = "";
            switch (color.ToLower())
            {
                case "rojo":
                    resultado = "Primario";
                    break;

                case "aZuL":
                    resultado = "Primario";
                    break;
                case " verdE":
                    resultado = "Primario";
                    break;

                default:
                    resultado = "Secundario";
                    break;
            }
            return resultado;
        }

        public string ColorPrimarioSecundario3_CondicionCompuesta(string color)
        {
            var resultado = "";
            if (color.ToLower() == "rojo" || color.ToLower() == "Azul" || color.ToLower() == "verde")
            {
                resultado = "Primario";
            }
            else
            {
                resultado = "Secundario";
            }

            return resultado;
        }


    }
}
