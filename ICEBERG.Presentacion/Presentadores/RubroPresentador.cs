using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using System.Windows.Forms;
using ICEBERG.Dominio;
using ICEBERG.Aplicación;

namespace ICEBERG.Presentacion.Presentadores
{
    public class RubroPresentador
    {
        private readonly IRubro rubroVista;
        private readonly RubroServicios rubroServicios;

        public RubroPresentador(IRubro vista)
        {
            rubroVista = vista;
            rubroServicios = new RubroServicios();
        }
        public List<Rubro> Listado()
        {
            return rubroServicios.ListadoRubros();
        }
        public Rubro ObtenerRubro(int id)
        {
            return rubroServicios.ObtenerRubro(id);
        }
        public void EditarRubro(Vistas.Rubro.Editar editar, int id)
        {
            Rubro rubro = new Rubro()
            {
                Descripción = editar.txtDescripción.Text,
                Estado = false
            };
            rubroServicios.ABMRubro(rubro, 2, id);
            rubroVista.MostrarMensaje("Rubro editado");
            editar.Close();
        }
        public void EliminaRubro(int id)
        {
            if (id != 0)
            {
                rubroServicios.ABMRubro(null, 3, id);
                rubroVista.MostrarMensaje("Cliente Eliminado");
            }
            else
            {
                rubroVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarRubro(Vistas.Rubro.Nuevo nuevo)
        {
            Rubro cliente = new Rubro()
            {
                Descripción = nuevo.txtDescripción.Text,
                Estado = false
            };
            rubroServicios.ABMRubro(cliente, 1, 0);
            rubroVista.MostrarMensaje("Rubro agregado");
        }
    }
}
