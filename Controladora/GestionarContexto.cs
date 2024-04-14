using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class GestionarContexto
    {
        private static Contexto contexto;

        public static Contexto ObtenerContexto()
        {
            if (contexto == null)
            {
                contexto = new Contexto();
            }
            return contexto;
        }
    }
}
