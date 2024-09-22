using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_De_Tanaka_Promedio01
{
    internal class Puerta:ObjetoDelJuego
    {
        public Puerta()
        {
            nombre = "puerta";
        }

        public override void Mirar()
        {
            Console.WriteLine("Ves una puerta de madera con cerradura.");
        }

        public override void Usar()
        {
            if (Juego.jugadorTieneLlave)
            {
                Console.WriteLine("Usas la llave y abres la puerta. ¡Ganaste!");
                Juego.juegoTerminado = true;
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("La puerta está cerrada. Necesitas una llave.");
            }
        }
    }
}
