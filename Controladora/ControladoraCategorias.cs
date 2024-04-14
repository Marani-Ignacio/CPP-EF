using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
    {
        private Contexto contexto = GestionarContexto.ObtenerContexto();
        private static ControladoraCategorias instancia;

        public static ControladoraCategorias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraCategorias();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Categoria> ListarCategorias()
        {
            try
            {
                return contexto.Categorias.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Categoria categoria)
        {
            try
            {
                var categoriaExistente = contexto.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (categoriaExistente == null)
                {
                    contexto.Categorias.Add(categoria);
                    contexto.SaveChanges();
                    return "Categoria agregada con éxito";
                }
                else
                {
                    return "Ya existe la categoria ingresada";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar categoria");
            }
        }

        public string Eliminar(Categoria categoria)
        {
            try
            {
                var categoriaExistente = contexto.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (categoriaExistente != null)
                {
                    contexto.Categorias.Remove(categoria);
                    contexto.SaveChanges();
                    return "Categoria eliminada con éxito";
                }
                else
                {
                    return "No existe categoria que eliminar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar categoria");
            }
        }

        public string Modificar(Categoria categoria)
        {
            try
            {
                var categoriaExistente = contexto.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (categoriaExistente != null)
                {
                    contexto.Categorias.Update(categoria);
                    contexto.SaveChanges();
                    return "Categoria modificada con éxito";
                }
                else
                {
                    return "No existe categoria que modificar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconociedo al modificar categoría");
            }
        }

        public Categoria EncontrarCategoria(string codigo)
        {
            return contexto.Categorias.ToList().FirstOrDefault(x => x.Codigo == codigo);
        }
    }
}
