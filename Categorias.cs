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

namespace PROYECTOCONEXION
{
    public partial class Categorias : Form
    {
  
        public Categorias()
        {
            InitializeComponent();
         
        }

        private void CargarCategorias()
        {
            using (var context = new PROYECTO3Entities3())
            {
                var lista = context.Categorias.ToList();
                dgCategorias.DataSource = lista;
            }
        }


        


        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PROYECTO3Entities3()) // tu DbContext real
                {
                    // Traer todas las categorías desde la base de datos
                    var lista = context.Categorias
                                       .Select(c => new
                                       {
                                           c.CategoriaID,
                                           c.NombreCategoria
                                       })
                                       .ToList();

                    // Mostrar en el DataGridView (asegúrate de tener uno llamado dgvCategorias)
                    dgCategorias.DataSource = context.Categorias
                        .Select(c => new
                        {
                            c.CategoriaID,
                            c.NombreCategoria
                        });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CargarProductos()
        {
            using (var context = new PROYECTO3Entities3())
            {
                var listaProductos = context.Productos
                    .Select(p => new
                    {
                        ID = p.ProductoID,
                        Nombre = p.NombreProducto,
                        Descripcion = p.Descripcion,
                        Precio = p.Precio,
                        Stock = p.Stock,
                        Categoria = p.Categorias.NombreCategoria
                    })
                    .ToList();

                dgCategorias.DataSource = listaProductos;
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEliminar.Text.Trim(), out int id))
            {
                MessageBox.Show("Debe introducir un ID valido.");
                return;
            }

            using (var db = new PROYECTO3Entities3())
            {
                var categoria = db.Categorias.Find(id);

                if (categoria != null)
                {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();

                    MessageBox.Show("Categoria eliminada vacanamente.");
                }
                else
                {
                    MessageBox.Show("No se encontro una categoria con ese ID.");
                }
            }
            CargarCategorias(); 
        }
        



           
        private void btnCargarCategorias_Click(object sender, EventArgs e)
        {
            using (var context = new PROYECTO3Entities3())
            {
                // Traer todas las categorías desde la base de datos
                var lista = context.Categorias.ToList();

                // Refrescar el DataGridView
                dgCategorias.DataSource = null; // Limpia el origen anterior
                dgCategorias.DataSource = lista; // Carga la nueva lista
            }
            using (var context = new PROYECTO3Entities3())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var lista = context.Categorias.ToList();
                dgCategorias.DataSource = null;
                dgCategorias.DataSource = lista;
            }

            using (var context = new PROYECTO3Entities3())
            {
                var lista = context.Categorias.Include("Products").ToList();
                dgCategorias.DataSource = null;
                dgCategorias.DataSource = lista;
            }

            using (var context = new PROYECTO3Entities3())
            {
                var lista = context.Categorias
                    .Select(c => new { c.IdCategoria, c.Nombre }) // sin navegación
                    .ToList();
                dgCategorias.DataSource = null;
                dgCategorias.DataSource = lista;
            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de la categoría.");
                    return;
                }

                var categoria = new PROYECTOCONEXION.PROYECTO3_BASEdDATOS.Categorias
                {
                    NombreCategoria = txtNombreCategoria.Text.Trim()
                };

                using (var context = new PROYECTO3Entities3())
                {
                    context.Categorias.Add(categoria);
                    context.SaveChanges();
                }

                MessageBox.Show("Categoría agregada correctamente.");
                txtNombreCategoria.Clear();
                CargarCategorias();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCategoriaIDActualizar.Text, out int id))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombreCategoriaActualizar.Text))
            {
                MessageBox.Show("Debe introducir un nombre de categoría.");
                return;
            }

            try
            {
                using (var context = new PROYECTO3Entities3())
                {
                    // Buscar la categoría por ID
                    var categoria = context.Categorias.Find(id);

                    if (categoria == null)
                    {
                        MessageBox.Show("No se encontró una categoría con ese ID.");
                        return;
                    }

                    // Actualizar el nombre
                    categoria.NombreCategoria = txtNombreCategoriaActualizar.Text.Trim();

                    context.SaveChanges();

                    MessageBox.Show("Categoría actualizada correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarCategorias(); // refresca el DataGridView
                    txtCategoriaIDActualizar.Clear();
                    txtNombreCategoriaActualizar.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la categoría: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }



