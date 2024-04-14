using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProveedores
    {
        private Contexto contexto = GestionarContexto.ObtenerContexto();
        private static ControladoraProveedores instancia;

        public static ControladoraProveedores Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraProveedores();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Proveedor> ListarProveedores()
        {
            try
            {
                return contexto.Proveedores.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Proveedor proveedor)
        {
            try
            {
                var proveedorExistente = contexto.Proveedores.FirstOrDefault(p => p.Cuit == proveedor.Cuit);
                if (proveedorExistente == null)
                {
                    contexto.Proveedores.Add(proveedor);
                    contexto.SaveChanges();
                    return "Proveedor agregado con éxito";
                }
                else
                {
                    return "Ya existe el proveedor ingresado";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar proveedor"); 
            }
        }

        public string Eliminar(Proveedor proveedor)
        {
            try
            {
                var proveedorExistente = contexto.Proveedores.FirstOrDefault(p => p.Cuit == proveedor.Cuit);
                if (proveedorExistente != null)
                {
                    contexto.Proveedores.Remove(proveedor);
                    contexto.SaveChanges();
                    return "Proveedor eliminado con éxito";
                }
                else
                {
                    return "No existe proveedor que eliminar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar proveedor");
            }
        }

        public string Modificar(Proveedor proveedor)
        {
            try
            {
                var proveedorExistente = contexto.Proveedores.FirstOrDefault(p => p.Cuit == proveedor.Cuit);
                if (proveedorExistente != null)
                {
                    contexto.Proveedores.Update(proveedor);
                    contexto.SaveChanges();
                    return "Proveedor modificado con éxito";
                }
                else
                {
                    return "No existe proveedor que modificar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar proveedor");
            }
        }

        public Proveedor EncontrarProveeedor(string cuit)
        {
            return contexto.Proveedores.ToList().FirstOrDefault(x => x.Cuit == cuit);
        }
    }
}
