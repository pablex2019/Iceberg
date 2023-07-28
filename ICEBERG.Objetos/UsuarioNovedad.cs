using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICEBERG.Objetos
{
    public class UsuarioNovedad
    {
        public int UsuarioNovedadId { get; set; }
        public Usuario Usuario { get; set; }
        public Novedad Novedad { get; set; }
    }
}
