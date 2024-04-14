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
    public partial class FormProductos : Form
    {
        private Contexto contexto;

        public FormProductos()
        {
            InitializeComponent();
        }

        public void ActualizarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Controladora.ControladoraProductos.Instancia.ListarProductos();
            dgvProductos.Columns["ProductoID"].Visible = false;
            dgvProductos.Columns["CategoriaID"].Visible = false;            
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
            formProducto.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var formProducto = new FormProducto(productoSeleccionado);
                formProducto.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto que modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraProductos.Instancia.Eliminar(productoSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto que eliminar");
            }
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var formGestionarClientes = new FormGestionarProveedores(productoSeleccionado, contexto);
                formGestionarClientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto para agregar clientes");
            }
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                this.Hide();
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var formClientes = new FormProveedoresProductos(productoSeleccionado);
                formClientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto el cual desee ver sus clientes");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var formMenu = new FormMenu();
            formMenu.ShowDialog();
        }        
    }
}
