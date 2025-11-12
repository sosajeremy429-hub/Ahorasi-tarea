using PROYECTOCONEXION.PROYECTO3_BASEdDATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTOCONEXION
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private PROYECTO3Entities3 _context = new PROYECTO3Entities3();


       

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
          using (var db = new PROYECTO3Entities3())
          {
            var clientes = db.Clientes
            .Select(c => new
            {
             c.ClienteID,
             c.NombreCompleto,
             c.CorreoElectronico,
             c.Telefono,
             c.Direccion
            })
              .ToList();
              dgClientes.DataSource = clientes;
          }
        }



      
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           if (dgClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para elimiinar.");
                return;
           }

           // Obtener el id del cliente seleccionado en el dgv
           int clienteId = (int)dgClientes.CurrentRow.Cells["ClienteID"].Value;
            var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteID == clienteId);
            
            if (cliente != null)
            {
                var confirm = MessageBox.Show(
                      $"¿Esta seguro de eliminar al cliente:  {cliente.NombreCompleto}?",
                      "Confirmar eliminacion",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Warning
                      );
                if (confirm == DialogResult.Yes)
                {
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();

                    MessageBox.Show("Cliente eliminado correctamente.");
                    CargarClientes();
                }
            }
            else
            {
                MessageBox.Show("No se encontro ningun cliente en la base de datos.");
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para actualiar.");
                return;
            }

            int clienteId = (int) dgClientes.CurrentRow.Cells["ClienteID"].Value;

            var cliente = _context.Clientes.FirstOrDefault(c => c.ClienteID == clienteId);
            if (cliente != null)
            {
                cliente.NombreCompleto = txtNombreCliente.Text.Trim();
                cliente.CorreoElectronico = txtCorreoCliente.Text.Trim();
                cliente.Telefono = txtTelefonoCliente.Text.Trim();

                _context.SaveChanges();

                MessageBox.Show("Cliente actualizado satifastoriamente.");
                CargarClientes();
            }
            else
            {
                MessageBox.Show("No se encontró el cliente en la base de datos.");
            }
        }








        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.CurrentRow != null)
            {
                txtNombreCliente.Text = dgClientes.CurrentRow.Cells["NombreCompleto"].Value?.ToString();
                txtCorreoCliente.Text = dgClientes.CurrentRow.Cells["CorreoElectronico"].Value?.ToString();
                txtTelefonoCliente.Text = dgClientes.CurrentRow.Cells["Telefono"].Value?.ToString();
                txtDireccionCliente.Text = dgClientes.CurrentRow.Cells["Direccion"].Value?.ToString();
            }
        }
    }
}



