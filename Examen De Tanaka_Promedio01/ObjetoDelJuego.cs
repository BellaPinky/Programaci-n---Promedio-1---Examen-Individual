using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_De_Tanaka_Promedio01
{
    abstract class ObjetoDelJuego:ICosasInteractuables
    {
        protected string nombre;

        public string ObtenerNombre()
        {
            return nombre;
        }

        public abstract void Mirar();
        public abstract void Usar();
    }
}
