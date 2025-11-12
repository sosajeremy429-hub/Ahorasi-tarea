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
    public partial class NombreProductos : Form
    {
        private PROYECTO3Entities3 _context;
        public NombreProductos()
        {
            InitializeComponent();
           _context = new PROYECTO3Entities3();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var listaProductos = _context.Productos
                .Select(p => new {
                    ID = p.ProductoID,
                    Nombre = p.NombreProducto,
                    Descripcion = p.Descripcion,
                    PRecio = p.Precio,
                    Stock = p.Stock,
                    Categoria = p.Categorias.NombreCategoria,
                }).ToList();
            dgProductos.DataSource = listaProductos;
        }

        private void CargarProductos()
        {
            var listaProductos = _context.Productos
                .Select(p => new {
                    ID = p.ProductoID,
                    Nombre = p.NombreProducto,
                    Descripcion = p.Descripcion,
                    Precio = p.Precio,
                    Stock = p.Stock,
                    Categoria = p.Categorias.NombreCategoria
                }).ToList();

            dgProductos.DataSource = listaProductos;
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
           if (!int.TryParse(txtEliminar.Text, out int id))
            {
                MessageBox.Show("Debe introducir un ID válido.");
                return;
            }

            var producto = _context.Productos.Find(id);
            if (producto != null) 
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
                MessageBox.Show("Producto eliminado correctamente.");
               
            }
            else
            {
                MessageBox.Show("No se encontro un producto con ese ID.");
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtProductoIDActualizar.Text, out int id))
            {
                MessageBox.Show("El ID del producto es invalido.");
                return;
            }

            var producto = _context.Productos.Find(id);
            if (producto == null)

            {
                MessageBox.Show("No se encontro un producto con ese ID.");
                return;
            }

            producto.NombreProducto = txtNombreProductoActualizar.Text.Trim();
            producto.Descripcion = txtDescripcionActualizar.Text.Trim();
            producto.Precio = Convert.ToDecimal(txtPrecioActualizar.Text);
            producto.Stock = Convert.ToInt32(txtStockActualizar.Text);
            producto.CategoriaID = Convert.ToInt32(txtCategoriaIDActualizar.Text);

            _context.SaveChanges();
            MessageBox.Show("Producto actualizado correctamente.");
        }

        private void NombreProductos_Load(object sender, EventArgs e)
        {
            var Categorias = _context.Categorias.ToList();
            cmbCategoriasAgregar.DataSource = Categorias;
            cmbCategoriasAgregar.DisplayMember = "NombreCategoria";
            cmbCategoriasAgregar.ValueMember = "CategoriaID";
        }

        private void btnGuardarProductos_Click(object sender, EventArgs e)
            //ComboBox Importar categorias
        {
            var producto = new Productos()
            {
                NombreProducto = txtNombreProducto.Text,
                Descripcion = txtDescripcion.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                CategoriaID = (int)cmbCategoriasAgregar.SelectedValue
            };

            _context.Productos.Add(producto);
            _context.SaveChanges();
            MessageBox.Show("Producto guardado correctamente.");
            CargarProductos();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
    
}