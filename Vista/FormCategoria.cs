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
    public partial class FormCategoria : Form
    {
        private Categoria categoria;
        private bool modificar = false;

        public FormCategoria()
        {
            InitializeComponent();
        }

        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            modificar = true;
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

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            if(modificar)
            {
                this.Text = "Modificar Categoria";
                txtCodigo.Text = categoria.Codigo;
                txtCodigo.Enabled = false;
                txtNombre.Text = categoria.Nombre;  
            }
            else
            {
                this.Text = "Agregar Categoria";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            if (modificar)
            {
                categoria.Codigo = txtCodigo.Text;
                categoria.Nombre = txtNombre.Text;

                var mensaje = Controladora.ControladoraCategorias.Instancia.Modificar(categoria);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var categoria = new Categoria()
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                };

                var mensaje = Controladora.ControladoraCategorias.Instancia.Agregar(categoria);
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
