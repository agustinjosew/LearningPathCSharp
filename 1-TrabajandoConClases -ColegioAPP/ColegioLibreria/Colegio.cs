using System;
using System.Text;

namespace ColegioLibreria
{
    class Colegio
    {
        //manera que me permite usar las props y al usar get-set encapsular de manera amplia
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodPostal { get; set; }
        public string NumeroTelefono { get; set; }

        //props con logica
        //backing variable : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties#properties-with-backing-fields
        private string _twitterLink;
        public string Twitterlink
        {
            // usuario @
            // manipular backing var
            get { return _twitterLink; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterLink = value;
                }

                else
                {
                    throw new Exception("El usuario debe contener @.");
                }
            }

        }

        //constructor
        public Colegio()
        {
            Nombre = "Escuela NoName";
            NumeroTelefono = "000-000-000000";

        }

        //tambien puedo hacerlo mediante instancia
        public Colegio(string NombreDelColegio, string ColegioNumeroTelefono)
        {
            Nombre = NombreDelColegio;
            NumeroTelefono = ColegioNumeroTelefono;
        }

        //metodos o funciones
        //public float PromedioDeNotas(float a, float b, float c)
        //{
        //    var promedio = (a + b + c) / 3;
        //    return promedio;
        //}

        //funciones dentro la expresion
        public float PromedioDeNotas(float a, float b, float c) => (a + b + c) / 3;

        public int PromedioDeNotas(int a, int b, int c)
        {
            var promedio = (a + b + c) / 3;
            return promedio;
        }

        //sobre escribiendo ToString
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Nombre);
            sb.AppendLine(Direccion);
            sb.AppendLine(Ciudad);
            sb.Append(", ");
            sb.Append(Provincia);
            sb.Append(" ");
            sb.Append(CodPostal);

            return sb.ToString();
        }

    }
}
