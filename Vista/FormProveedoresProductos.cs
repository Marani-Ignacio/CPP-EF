using Microsoft.EntityFrameworkCore;
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
    public partial class FormProveedoresProductos : Form
    {
        private Producto producto;

        public FormProveedoresProductos(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        public void ActualizarGrilla()
        {
            Controladora.ControladoraProveedores.Instancia.ListarProveedores();
            dgvProveedores.DataSource = null;
            if (producto.Proveedores != null)
            {
                dgvProveedores.DataSource = producto.Proveedores.ToList();
            }
        }

        private void FormProveedoresProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                var proveedorSeleccionado = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                var formProveedor = new FormProveedor(proveedorSeleccionado);
                formProveedor.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor que modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                var proveedorSeleccionado = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el proveedor seleccionado del producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    producto.Proveedores.Remove(proveedorSeleccionado);
                    var mensaje = Controladora.ControladoraProductos.Instancia.Modificar(producto);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor que eliminar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProveedoresProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var formProductos = new FormProductos();
            formProductos.ShowDialog();
        }        
    }
}
