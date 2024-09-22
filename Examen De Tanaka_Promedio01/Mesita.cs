using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_De_Tanaka_Promedio01
{
    internal class Mesita:ObjetoDelJuego
    {
        private bool tieneLlave;

        public Mesita()
        {
            nombre = "mesita";
            tieneLlave = true;
        }

        public override void Mirar()
        {
            Console.WriteLine("Ves una mesita de noche con un cajón.");
        }

        public override void Usar()
        {
            if (tieneLlave)
            {
                Console.WriteLine("Abres el cajón y encuentras una llave!");
                tieneLlave = false;
                Juego.jugadorTieneLlave = true;
            }
            else
            {
                Console.WriteLine("El cajón está vacío.");
            }
        }
    }
}
