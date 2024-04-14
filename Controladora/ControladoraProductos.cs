using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {
        private Contexto contexto = GestionarContexto.ObtenerContexto();
        private static ControladoraProductos instancia;

        public static ControladoraProductos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraProductos();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Producto> ListarProductos()
        {
            try
            {
                return contexto.Productos.Include(c => c.Categoria).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Producto producto)
        {
            try
            {
                var productoExistente = contexto.Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (productoExistente == null)
                {
                    contexto.Productos.Add(producto);
                    contexto.SaveChanges();
                    return "Producto agregado con éxito";
                }
                else
                {
                    return "Ya existe el producto ingresado";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar producto");
            }
        }

        public string Eliminar(Producto producto)
        {
            try
            {
                var productoExistente = contexto.Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (productoExistente != null)
                {
                    contexto.Productos.Remove(producto);
                    contexto.SaveChanges();
                    return "Producto eliminado con éxito";
                }
                else
                {
                    return "No existe producto que eliminar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar producto");
            }
        }

        public string Modificar(Producto producto)
        {            
            
                var productoExistente = contexto.Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (productoExistente != null)
                {
                    contexto.Productos.Update(producto);
                    contexto.SaveChanges();
                    return "Producto modificado con éxito";
                }                
                else
                {
                    return "No existe producto que modificar";
                }
            
        }
    }
}
