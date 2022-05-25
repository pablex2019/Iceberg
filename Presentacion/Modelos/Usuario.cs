using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Modelo
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string NivelAcceso { get; set; }
        public Empleado Empleado { get; set; }
    }
}
