using Modelo;

namespace Vista
{
    public partial class FormProveedor : Form
    {
        private Proveedor proveedor;
        private bool modificar = false;

        public FormProveedor()
        {
            InitializeComponent();
        }

        public FormProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            modificar = true;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar proveedor";
                txtCuit.Text = proveedor.Cuit;
                txtCuit.Enabled = false;
                txtNombre.Text = proveedor.Nombre;
                txtApellido.Text = proveedor.Apellido;
            }
            else
            {
                this.Text = "Agregar proveedor";
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el Apellido correctamente");
                return false;
            }

            int DNI;
            if (!int.TryParse(txtCuit.Text, out DNI))
            {
                MessageBox.Show("Ingrese el DNI correctamente");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            if (modificar)
            {
                proveedor.Cuit = txtCuit.Text;
                proveedor.Nombre = txtNombre.Text;
                proveedor.Apellido = txtApellido.Text;

                var mensaje = Controladora.ControladoraProveedores.Instancia.Modificar(proveedor);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var proveedor = new Proveedor()
                {
                    Cuit = txtCuit.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text
                };

                var mensaje = Controladora.ControladoraProveedores.Instancia.Agregar(proveedor);
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
