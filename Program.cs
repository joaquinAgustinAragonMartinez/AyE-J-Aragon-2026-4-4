namespace fulbo
{
    internal class Program
    {
        public struct Jugador
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public double CantidadGoles { get; set; }
            public double CantidadTirosArco { get; set; }
            public int NumeroCamiseta { get; set; }
            public string Posicion { get; set; }
            public string Equipo { get; set; }

            public Jugador(string nombre, string apellido, double cantidadgoles, double cantidadtirosarco, int numerocamiseta, string posicion, string equipo)
            {
                Nombre = nombre;
                Apellido = apellido;
                CantidadGoles = cantidadgoles;
                CantidadTirosArco = cantidadtirosarco;
                NumeroCamiseta = numerocamiseta;
                Posicion = posicion;
                Equipo = equipo;
            }

            public double indiceAtaque()
            {
                double indice;
                indice = (CantidadGoles / CantidadTirosArco) * 100;
                return indice;
            }
        }

        static void Main(string[] args)
        {
            Jugador[] goleadores = new Jugador[]
            {
                new Jugador("Kylian","Mbappé",8,19,10,"Delantero","Francia"),
                new Jugador("Lionel","Messi",8,16,10,"Delantero","Argentina"),
                new Jugador("Erling","Haaland",7,11,9,"Delantero","Noruega"),
                new Jugador("Harry","Kane",6,10,9,"Delantero","Inglaterra"),
                new Jugador("Jude","Bellingham",6,9,10,"Mediocampista","Inglaterra"),
                new Jugador("Ousmane","Dembélé",5,8,7,"Delantero","Francia"),
                new Jugador("Mikel","Oyarzabal",5,7,21,"Delantero","España")
            };

            Console.WriteLine("Lista de Goleadores");

            foreach (Jugador jugadores in goleadores)
            {
                Console.WriteLine("Nombre y Apellido: "+ jugadores.Nombre + " " + jugadores.Apellido + "| Goles: " + jugadores.CantidadGoles + "| Tiros al arco: " + jugadores.CantidadTirosArco + " | Dorsal: " + jugadores.NumeroCamiseta + " | Posición: " + jugadores.Posicion + " | Equipo: " + jugadores.Equipo);
            }

            Console.WriteLine();
            Jugador jugador = indiceAtaque(goleadores);
            Console.WriteLine("Jugador con Mayor Índice de Ataque: "+ jugador.Nombre + " " + jugador.Apellido + " con " + jugador.indiceAtaque());
        }

        public static Jugador indiceAtaque(Jugador[] jugadores)
        {
            Jugador jugadorMayorIndice = jugadores[0];
            Jugador jugadorAct = new Jugador();

            for (int x = 0; x < jugadores.Length; x++)
            {
                jugadorAct = jugadores[x];

                if (jugadorAct.indiceAtaque() > jugadorMayorIndice.indiceAtaque())
                {
                    jugadorMayorIndice = jugadorAct;
                }
            }

            return jugadorMayorIndice;
        }
    }
}