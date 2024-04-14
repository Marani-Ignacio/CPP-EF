using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        private string cuit;
        private string nombre;
        private string apellido;

        public int ProveedorID { get; set; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return $"{cuit}";
        }
    }
}
