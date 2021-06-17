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

    }
}
