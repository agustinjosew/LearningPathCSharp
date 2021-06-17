using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibreria
{
     class Colegio
    {
        //manera no convencional, no hay interaccion de encapsulacion
        //string ColegioNombre;
        //string ColegioDireccion;
        //string ColegioCiudad;
        //string ColegioProvincia;
        //string ColegioCodPostal;
        //string NumeroTelefono;

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
            Nombre         = "Escuela NoName";
            NumeroTelefono = "000-000-000000";

        }

        //tambien puedo hacerlo mediante instancia
        public Colegio(string NombreDelColegio, string ColegioNumeroTelefono)
        {
            Nombre         = NombreDelColegio;
            NumeroTelefono = ColegioNumeroTelefono;
        }

        //metodos o funciones
        //public float PromedioDeNotas(float a, float b, float c)
        //{
        //    var promedio = (a + b + c) / 3;
        //    return promedio;
        //}

        //funciones dentro la expresion
        public float PromedioDeNotas(float a, float b, float c) =>(a + b + c) / 3;

        public int PromedioDeNotas(int a, int b, int c)
        {
            var promedio = (a + b + c) / 3;
            return promedio;
        }

        

    }
}
