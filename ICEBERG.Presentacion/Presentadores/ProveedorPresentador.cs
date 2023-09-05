using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Dominio;
using ICEBERG.Aplicación;

namespace ICEBERG.Presentacion.Presentadores
{
    public class ProveedorPresentador
    {
        private readonly IProveedor proveedorVista;
        private readonly ProveedorServicios proveedorServicios;

        public ProveedorPresentador(IProveedor vista)
        {
            proveedorVista = vista;
            proveedorServicios = new ProveedorServicios();
        }
        public List<Proveedor> Listado()
        {
            return proveedorServicios.ListadoProveedores();
        }
        public Proveedor ObtenerProveedor(int id)
        {
            return proveedorServicios.ObtenerProveedor(id);
        }
        public void EditarProveedor(Vistas.Proveedor.Editar editar, int id)
        {
            Proveedor proveedor = new Proveedor()
            {
                RazonSocial = editar.txtRazonSocial.Text,
                Cuit = editar.txtCuit.Text,
                Cuil = editar.txtCuil.Text,
                Dni = editar.txtDni.Text == "" ? 0 : Convert.ToInt32(editar.txtDni.Text),
                Nombre = editar.txtNombres.Text,
                Apellido = editar.txtApellidos.Text,
                Domicilio = editar.txtDomicilio.Text,
                TelefonoFijo = editar.txtTelefonoFijo.Text,
                Celular = editar.txtCelular.Text,
                CorreoElectronico = editar.txtCorreoElectronico.Text,
                Estado = false
            };
            proveedorServicios.ABMProveedor(proveedor, 2, id);
            proveedorVista.MostrarMensaje("Proveedor editado");
            editar.Close();
        }
        public void EliminarProveedor(int id)
        {
            if (id != 0)
            {
                proveedorServicios.ABMProveedor(null, 3, id);
                proveedorVista.MostrarMensaje("Proveedor eliminado");
            }
            else
            {
                proveedorVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarProveedor(Vistas.Proveedor.Nuevo nuevo)
        {
            Proveedor proveedor = new Proveedor()
            {
                RazonSocial = nuevo.txtRazonSocial.Text,
                Cuit = nuevo.txtCuit.Text,
                Cuil = nuevo.txtCuil.Text,
                Dni = nuevo.txtDni.Text == "" ? 0 : Convert.ToInt32(nuevo.txtDni.Text),
                Nombre = nuevo.txtNombres.Text,
                Apellido = nuevo.txtApellidos.Text,
                Domicilio = nuevo.txtDomicilio.Text,
                TelefonoFijo = nuevo.txtTelefonoFijo.Text,
                Celular = nuevo.txtCelular.Text,
                CorreoElectronico = nuevo.txtCorreoElectronico.Text,
                Estado = false
            };
            proveedorServicios.ABMProveedor(proveedor, 1, 0);
            proveedorVista.MostrarMensaje("Proveedor agregado");
        }
    }
}
