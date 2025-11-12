using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOCONEXION
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuCostalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categorias frm = new Categorias();
            frm.MdiParent = this;
            frm.Show();

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NombreProductos frm = new NombreProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
