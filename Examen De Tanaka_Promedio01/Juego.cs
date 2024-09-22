using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_De_Tanaka_Promedio01
{
    internal class Juego
    {
        public static bool jugadorTieneLlave = false;
        public static bool juegoTerminado = false;
        List<ObjetoDelJuego> objetosDelJuego = new List<ObjetoDelJuego>();

        public Juego()
        {
            objetosDelJuego.Add(new Mesita());
            objetosDelJuego.Add(new Puerta());
        }

        public void IniciarJuego()
        {
            Console.WriteLine("Estás en un cuarto con una puerta cerrada y una mesita.");

            while (juegoTerminado == false)
            {
                MostrarOpciones();
                RealizarAccion();
            }

            Console.WriteLine("¡Fin del juego!");
        }

        private void MostrarOpciones()
        {
            Console.WriteLine("\n¿Qué quieres hacer?");
            for (int i = 0; i < objetosDelJuego.Count; i++)
            {
                Console.WriteLine($"{i * 2 + 1}. Mirar {objetosDelJuego[i].ObtenerNombre()}");
                Console.WriteLine($"{i * 2 + 2}. Usar {objetosDelJuego[i].ObtenerNombre()}");
            }
            Console.WriteLine("0. Salir del juego");
        }

        private void RealizarAccion()
        {
            Console.Write("Elige un número: ");
            string entrada = Console.ReadLine();
            int opcion;

            if (int.TryParse(entrada, out opcion))
            {
                if (opcion == 0)
                {
                    juegoTerminado = true;
                }
                else if (opcion > 0 && opcion <= objetosDelJuego.Count * 2)
                {
                    int indiceObjeto = (opcion - 1) / 2;
                    if (opcion % 2 != 0)
                    {
                        objetosDelJuego[indiceObjeto].Mirar();
                    }
                    else
                    {
                        objetosDelJuego[indiceObjeto].Usar();
                    }
                }
                else
                {
                    Console.WriteLine("Número no válido. Intenta de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Eso no es un número. Intenta de nuevo.");
            }
        }
    }
}
