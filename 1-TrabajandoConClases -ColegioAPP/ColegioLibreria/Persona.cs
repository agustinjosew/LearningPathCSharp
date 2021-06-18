using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioLibreria
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        public abstract float ComputarPromedioDelCurso();

        public virtual string EnviarMensaje(string mensaje)
        {
            var sb            = new StringBuilder();
            var MarcaDeTiempo = string.Format("Enviado el {0:D} a las {0:t}", DateTime.Now );

            sb.AppendLine(MarcaDeTiempo);
            sb.AppendLine(" ");
            sb.AppendLine("Estimad@ " + Nombre + ",");
            sb.AppendLine(mensaje);
            return sb.ToString();
        }
    }
}
