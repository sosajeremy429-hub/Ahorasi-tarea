using PROYECTOCONEXION.PROYECTO3_BASEdDATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTOCONEXION.PROYECTO3_BASEdDATOS;
namespace PROYECTOCONEXION
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                // Validar campos obligatorios
                if (string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text) ||
                    string.IsNullOrEmpty(txtCorreoElectronico.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos obligatorios.");
                    return;
                }

                try
                {
                    using (var context = new  PROYECTO3Entities3())
                    {
                        var proveedor = new PROYECTO3_BASEdDATOS.Proveedores()
                        {
                            NombreProveedor = txtNombre.Text.Trim(),
                            Telefono = txtTelefono.Text.Trim(),
                            CorreoElectronico = txtCorreoElectronico.Text.Trim()
                            // ProveedorID no se asigna porque es Identity en SQL
                        };

                        context.Proveedores.Add(proveedor);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Proveedor guardado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //
                    // Actualizar el DataGridView
                    CargarProveedores();

                    // Limpiar los campos
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtCorreoElectronico.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el proveedor: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CargarProveedores()
        {
            using (var context = new PROYECTO3Entities3())
            {
                // Traer solo los campos que necesitas
                dgProveedores.DataSource = context.Proveedores
                    .Select(p => new
                    {
                        p.ProveedorID,
                        p.NombreProveedor,
                        p.Telefono,
                        p.CorreoElectronico
                    })
                    .ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEliminar.Text))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            // CONEXION A MI BASE DE DATOS
            string connectionString = @"Data Source=JEREMY;Initial Catalog=PROYECTO3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEliminarProveedores = @"DELETE FROM Proveedores WHERE ProveedorID = '" + txtEliminar.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarProveedores, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado el proveedor en la base de datos.");
                    }
                }

                connection.Close();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=JEREMY;Initial Catalog=PROYECTO3;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryProveedores = "SELECT * FROM Proveedores;";

                using (SqlCommand cmd = new SqlCommand(queryProveedores, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgProveedores.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            {
                // Validar que el ID sea un número válido
                if (!int.TryParse(txtProveedorIDActualizar.Text.Trim(), out int proveedorID))
                {
                    MessageBox.Show("Debe ingresar un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos obligatorios
                string nombre = txtNombreActualizar.Text.Trim();
                string telefono = txtTelefonoActualizar.Text.Trim();
                string correo = txtCorreoActualizar.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo))
                {
                    MessageBox.Show("Debe llenar todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // --- DbContext temporal ---
                    using (var context = new PROYECTO3Entities3())
                    {
                        // Buscar el proveedor por ID
                        var proveedor = context.Proveedores
                                               .FirstOrDefault(p => p.ProveedorID == proveedorID);

                        if (proveedor != null)
                        {
                            // Actualizar los campos
                            proveedor.NombreProveedor = nombre;
                            proveedor.Telefono = telefono;
                            proveedor.CorreoElectronico = correo;

                            context.SaveChanges();

                            MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un proveedor con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    // --- Fin DbContext temporal ---

                    // Recargar el DataGridView
                    CargarProveedores();

                    // Limpiar campos
                    txtProveedorIDActualizar.Clear();
                    txtNombreActualizar.Clear();
                    txtTelefonoActualizar.Clear();
                    txtCorreoActualizar.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProveedorIDActualizar.Text.Trim(), out int proveedorID))
            {
                MessageBox.Show("Debe ingresar un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campos obligatorios
            string nombre = txtNombreActualizar.Text.Trim();
            string telefono = txtTelefonoActualizar.Text.Trim();
            string correo = txtCorreoActualizar.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // --- DbContext temporal para evitar congelamientos ---
                using (var context = new PROYECTO3Entities3())
                {
                    // Buscar el proveedor por ID
                    var proveedor = context.Proveedores
                                           .FirstOrDefault(p => p.ProveedorID == proveedorID);

                    if (proveedor != null)
                    {
                        // Actualizar los campos
                        proveedor.NombreProveedor = nombre;
                        proveedor.Telefono = telefono;
                        proveedor.CorreoElectronico = correo;

                        // Guardar cambios
                        context.SaveChanges();

                        MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un proveedor con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // --- Fin DbContext temporal ---

                // Refrescar DataGridView
                CargarProveedores();

                // Limpiar TextBox
                txtProveedorIDActualizar.Clear();
                txtNombreActualizar.Clear();
                txtTelefonoActualizar.Clear();
                txtCorreoActualizar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





