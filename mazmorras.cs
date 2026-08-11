using System.Reflection.Metadata.Ecma335;

namespace mazmorras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje1 = new Personaje("elpepe", 10, new string[20]);
            Personaje personaje2 = new Personaje("juanito", 10, new string[20]);

            string[] objetosbatalla = new string[20] {"Sable de luz", "Bláster", "Cañón de riel", "Escudo deflector", "Servoarmadura", "Rifle Gauss", "Granada PEM", "Hoja de plasma", "Nanotraje", "Disruptor sónico", "Rifle de plasma", "Cañón de antimateria", "Lanzador de micro-misiles", "Camuflaje óptico", "Granada de singularidad", "Cuchillo de vibración", "Inyector de nanobots","Guantelete de fuerza", "Rifle de inducción magnética","Campo de estasis" };

            Random aleatorio = new Random();

            for (int numturno = 1; numturno <= 20; numturno++)
            {
                int dificultadsala = aleatorio.Next(0, 50);
                string item = objetosbatalla[aleatorio.Next(0, 20)];
                int podersala = aleatorio.Next(0, 5);

                Salas Sala = new Salas(dificultadsala, item, podersala);

                Console.WriteLine();
                Console.WriteLine("Turno numero " + numturno);

                if (numturno % 2 == 0)
                {
                    personaje1.poder = personaje1.Robar(Sala.dificultad, Sala.item, Sala.poderitem);
                }
                else
                {
                    personaje2.poder = personaje2.Robar(Sala.dificultad, Sala.item, Sala.poderitem);
                }
            }


            if (personaje1.poder > personaje2.poder)
            {
                Console.WriteLine("El ganador es " + personaje1.nombre);
                Console.WriteLine("Items:");

                for (int i = 0; i < personaje1.items.Length; i++)
                {
                    if (personaje1.items[i] != null)
                    {
                        Console.WriteLine(personaje1.items[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nEl ganador es " + personaje2.nombre);
                Console.WriteLine("Items:");

                for (int i = 0; i < personaje2.items.Length; i++)
                {
                    if (personaje2.items[i] != null)
                    {
                        Console.WriteLine(personaje2.items[i]);
                    }
                }
            }
        }


        public struct Personaje
        {
            public string nombre { get; set; }
            public int poder { get; set; }
            public string[] items { get; set; }


            public Personaje(string nombre, int poder, string[] items)
            {
                this.nombre = nombre;
                this.poder = poder;
                this.items = items;
            }


            public int Robar(int dificultad, string item, int poderitem)
            {
                if (poder > dificultad)
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i] == null)
                        {
                            items[i] = item;
                            poder += poderitem;
                            Console.WriteLine(nombre + " robo " + item);
                            return poder + poderitem;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(nombre + " no pudo robar el objeto");
                }
                return poder;
            }
        }


        public struct Salas
        {
            public int dificultad { get; set; }
            public string item { get; set; }
            public int poderitem { get; set; }


            public Salas(int dificultad, string item, int poder)
            {
                this.dificultad = dificultad;
                this.item = item;
                this.poderitem = poder;
            }
        }
    }
}