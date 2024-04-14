using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private string talle;
        private Categoria categoria;
        private List<Proveedor> proveedores;


        public Producto()
        {
            if (Proveedores == null)
            {
                Proveedores = new List<Proveedor>();
            }
        }

        public int ProductoID { get; set; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Talle { get => talle; set => talle = value; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public List<Proveedor> Proveedores { get => proveedores; set => proveedores = value; }

        public override string ToString()
        {
            return $"{nombre}";
        }
    }
}
