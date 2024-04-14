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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        public void ActualizarGrilla()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = Controladora.ControladoraCategorias.Instancia.ListarCategorias();
            dgvCategorias.Columns["CategoriaID"].Visible = false;
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formCategoria = new FormCategoria();
            formCategoria.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                var categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                var formCategoria = new FormCategoria(categoriaSeleccionada);
                formCategoria.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoria que modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                var categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar la categoria seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraCategorias.Instancia.Eliminar(categoriaSeleccionada);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría que eliminar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var formMenu = new FormMenu();
            formMenu.ShowDialog();
        }
    }
}
