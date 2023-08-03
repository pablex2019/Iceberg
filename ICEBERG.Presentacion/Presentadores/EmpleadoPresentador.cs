using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Objetos;
using ICEBERG.Dominio;

namespace ICEBERG.Presentacion.Presentadores
{
    public class EmpleadoPresentador
    {
        private readonly IEmpleado empleadoVista;
        private readonly EmpleadoServicios empleadoServicios;

        public EmpleadoPresentador(IEmpleado vista)
        {
            empleadoVista = vista;
            empleadoServicios = new EmpleadoServicios();
        }
        public List<Empleado> Listado()
        {
            return empleadoServicios.ListadoEmpleados();
        }
        public Empleado ObtenerEmpleado(int id)
        {
            return empleadoServicios.ObtenerEmpleado(id);
        }
        public void EditarEmpleado(Vistas.Empleado.Editar editar, int id)
        {
            Empleado empleado = new Empleado()
            {
                Legajo = Convert.ToInt32(editar.txtLegajo.Text),
                Cuil = editar.txtCuil.Text,
                Cuit = editar.txtCuit.Text,
                Dni = Convert.ToInt32(editar.txtDni.Text),
                Nombre = editar.txtNombre.Text,
                Apellido = editar.txtApellido.Text,
                Domicilio = editar.txtDomicilio.Text,
                CorreoElectronico = editar.txtCorreoElectronico.Text,
                TelefonoFijo = editar.txtTelefonoFijo.Text,
                Celular = editar.txtCelular.Text,
                Estado = false
            };
            empleadoServicios.ABMEmpleado(empleado, 2, id);
            empleadoVista.MostrarMensaje("Empleado editado");
            editar.Close();
        }
        public void EliminarEmpleado(int id)
        {
            if (id != 0)
            {
                empleadoServicios.ABMEmpleado(null, 3, id);
                empleadoVista.MostrarMensaje("Empleado Eliminado");
            }
            else
            {
                empleadoVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarEmpleado(Vistas.Empleado.Nuevo nuevo)
        {
            Empleado empleado = new Empleado()
            {
                Legajo = Convert.ToInt32(nuevo.txtLegajo.Text),
                Cuil = nuevo.txtCuil.Text,
                Cuit = nuevo.txtCuit.Text,
                Dni = Convert.ToInt32(nuevo.txtDni.Text),
                Nombre = nuevo.txtNombre.Text,
                Apellido = nuevo.txtApellido.Text,
                Domicilio = nuevo.txtDomicilio.Text,
                CorreoElectronico = nuevo.txtCorreoElectronico.Text,
                TelefonoFijo = nuevo.txtTelefonoFijo.Text,
                Celular = nuevo.txtCelular.Text,
                Estado = false
            };
            empleadoServicios.ABMEmpleado(empleado, 1, 0);
            empleadoVista.MostrarMensaje("Empleado agregado");
        }
    }
}
