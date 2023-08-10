using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionClientesSQL.dao;
using GestionClientesSQL.models;
using MySqlX.XDevAPI;
using ZstdSharp.Unsafe;

namespace GestionClientesSQL
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }
        private void GestionClientes_Load_1(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            ClienteDao baseDeDatos = new ClienteDao();
            List<Cliente> listaDb = baseDeDatos.ObtenerlistadoDeClientes();

            listClientes.Items.Clear();

            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }


        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblId.Text= "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Eliminar(cliente);
            actualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente) listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjeta.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.Id;

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjeta.Text;

            if (lblId.Text != "")
            {
                cliente.Id = lblId.Text;
            }


            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();
        }
    }
}
