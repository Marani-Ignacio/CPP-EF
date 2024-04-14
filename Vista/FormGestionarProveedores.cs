using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormGestionarProveedores : Form
    {
        private Producto producto;
        private Contexto contexto;

        public FormGestionarProveedores(Producto producto, Contexto contexto)
        {
            InitializeComponent();
            this.producto = producto;
            this.contexto = contexto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contexto contexto = Controladora.GestionarContexto.ObtenerContexto();

            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Ingrese el Cuit correctamente");
                return;
            }
            Proveedor proveedor = contexto.Proveedores.FirstOrDefault(p => p.Cuit == txtCuit.Text);
            if (proveedor == null)
            {
                MessageBox.Show("No existe el proveedor ingresado");
                return;
            }
            else
            {
                if (producto.Proveedores.Any(p => p.ProveedorID == proveedor.ProveedorID))
                {
                    MessageBox.Show("El proveedor ya está asociado a este producto");
                    return;
                }
                producto.Proveedores.Add(proveedor);
                var mensaje = Controladora.ControladoraProductos.Instancia.Modificar(producto);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGestionarClientes_Load(object sender, EventArgs e)
        {
            lblProducto.Text = "Producto: " + producto.Nombre + " / " + producto.Categoria;
        }
    }
}
