﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICEBERG.Presentacion.Interfaces;
using ICEBERG.Presentacion.Vistas;
using ICEBERG.Dominio;
using ICEBERG.Aplicación;
using System.Windows.Forms;

namespace ICEBERG.Presentacion.Presentadores
{
    public class ClientePresentador
    {
        private readonly ICliente clienteVista;
        private readonly ClienteServicios clienteServicios;

        public ClientePresentador(ICliente vista)
        {
            clienteVista = vista;
            clienteServicios = new ClienteServicios();
        }
        public List<Cliente> Listado()
        {
            return clienteServicios.ListadoClientes();
        }
        public Cliente ObtenerCliente(int id)
        {
            return clienteServicios.ObtenerCliente(id);
        }
        public void EditarCliente(Vistas.Cliente.Editar editar,int id)
        {
            Cliente cliente = new Cliente()
            {
                Dni = editar.txtDni.Text == "" ? 0 : Convert.ToInt32(editar.txtDni.Text),
                Nombre = editar.txtNombres.Text,
                Apellido = editar.txtApellidos.Text,
                Domicilio = editar.txtDomicilio.Text,
                TelefonoFijo =editar.txtTelefonoFijo.Text,
                Celular = editar.txtCelular.Text,
                CorreoElectronico = editar.txtCorreoElectronico.Text,
                SaldoDeudor = float.Parse(editar.txtSaldoDeudor.Text),
                Estado = false
            };
            clienteServicios.ABMCliente(cliente,2,id);
            clienteVista.MostrarMensaje("Cliente editado");
            editar.Close();
        }
        public void EliminarCliente(int id)
        {
            if (id != 0)
            {
                clienteServicios.ABMCliente(null,3,id);
                clienteVista.MostrarMensaje("Cliente eliminado");
            }
            else
            {
                clienteVista.MostrarMensaje("Debe seleccionar un registro");
            }
        }
        public void AgregarCliente(Vistas.Cliente.Nuevo nuevo)
        {
            Cliente cliente = new Cliente()
            {
                Dni = nuevo.txtDni.Text == "" ? 0 : Convert.ToInt32(nuevo.txtDni.Text),
                Nombre = nuevo.txtNombres.Text,
                Apellido = nuevo.txtApellidos.Text,
                Domicilio = nuevo.txtDomicilio.Text,
                TelefonoFijo = nuevo.txtTelefonoFijo.Text,
                Celular = nuevo.txtCelular.Text,
                CorreoElectronico = nuevo.txtCorreoElectronico.Text,
                SaldoDeudor = float.Parse(nuevo.txtSaldoDeudor.Text),
                Estado = false
            };
            clienteServicios.ABMCliente(cliente,1,0);
            clienteVista.MostrarMensaje("Cliente agregado");
        }
    }
}
