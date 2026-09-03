using System.Collections.Generic;
using System.Resources;
using System.Threading.Tasks;

namespace prueba_algoritmos
{
    internal class Program
    {
        public void volverEnElTiempo(Stack<Personaje> historialDelPersonaje)
        {
            Personaje UltimaAccion = historialDelPersonaje.Peek();

            Console.WriteLine("la ultima accion realizada fue :" + UltimaAccion);
        }
        public void Golpear(Stack<Personaje> historialDelPersonaje)
        {
            string AccionUltima = "Golpe Recibido";
            int ActualVida = Personaje.VidaActual;
            ActualVida = ActualVida - 20;

            Personaje VidaActual = historialDelPersonaje.Push(ActualVida);

            Personaje UltimaAccion = historialDelPersonaje.Push(AccionUltima);
        }
        static void Main(string[] args)
        {
            Personaje personaje1 = new Personaje(100, 100, "talar");
            Personaje personaje2 = new Personaje(100, 100, "picar");
            Personaje personaje3 = new Personaje(100, 100, "cocinar");

            volverEnElTiempo();
            Golpear();

            foreach (Personaje personajes in Personaje)
            {
                Console.WriteLine(personaje1);
                Console.WriteLine(personaje2);
                Console.WriteLine(personaje3);
            }
        }
    }
}