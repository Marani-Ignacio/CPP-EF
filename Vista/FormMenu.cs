using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCategorias = new FormCategorias();
            formCategorias.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formProductos = new FormProductos();
            formProductos.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formProveedores = new FormProveedores();
            formProveedores.ShowDialog();
        }
    }
}
