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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = Controladora.ControladoraProveedores.Instancia.ListarProveedores();
            dgvProveedores.Columns["ProveedorID"].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formProveedor = new FormProveedor();
            formProveedor.ShowDialog();
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
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el proveedor seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraProveedores.Instancia.Eliminar(proveedorSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor que eliminar");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var formMenu = new FormMenu();
            formMenu.ShowDialog();
        }
    }
}
