using Modelo;
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
    public partial class FormProducto : Form
    {
        private Producto producto;
        private bool modificar = false;
        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            modificar = true;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            var categorias = Controladora.ControladoraCategorias.Instancia.ListarCategorias();
            
            cbCategoria.Items.Clear();

            foreach (var categoria in categorias)
            {
                cbCategoria.Items.Add(categoria);
            }

            if (modificar)
            {
                this.Text = "Modificar Producto";
                txtCodigo.Text = producto.Codigo.ToString();
                txtCodigo.Enabled = false;
                txtNombre.Text = producto.Nombre;
                txtTalle.Text = producto.Talle;
                cbCategoria.Text = producto.Categoria.ToString();
            }
            else
            {
                this.Text = "Agregar Producto";
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el Codigo correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre correctamente");
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            if(!ValidarDatos())
            {
                return;
            }

            Categoria categoria = contexto.Categorias.FirstOrDefault(c => c.Codigo == cbCategoria.Text);

            if (categoria == null)
            {
                MessageBox.Show("No existe una categoría con el nombre ingresado");
                return;
            }

            if (modificar)
            {
                producto.Codigo = Convert.ToInt32(txtCodigo.Text);
                producto.Nombre = txtNombre.Text;
                producto.Talle = txtTalle.Text;
                producto.Categoria = Controladora.ControladoraCategorias.Instancia.EncontrarCategoria(cbCategoria.Text);

                var mensaje = Controladora.ControladoraProductos.Instancia.Modificar(producto);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var producto = new Producto()
                {
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nombre = txtNombre.Text,
                    Talle = txtTalle.Text,
                    Categoria = Controladora.ControladoraCategorias.Instancia.EncontrarCategoria(cbCategoria.Text),
                };

                var mensaje = Controladora.ControladoraProductos.Instancia.Agregar(producto);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
