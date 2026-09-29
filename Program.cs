using programa_n8;

namespace BB_en_BDD
{
    internal class Program
    {
        static ArbolPokemon arbol = new ArbolPokemon();

        static void Main(string[] args)
        {
            Console.WriteLine("Programa N°8");

            int opcion;

            do
            {
                Console.WriteLine();
                Console.WriteLine("MENU POKEMON");
                Console.WriteLine("1 - Ver todos los Pokemon");
                Console.WriteLine("2 - Buscar Pokemon por ID");
                Console.WriteLine("3 - Agregar Pokemon");
                Console.WriteLine("4 - Modificar Pokemon");
                Console.WriteLine("5 - Eliminar Pokemon");
                Console.WriteLine("6 - Crear arbol");
                Console.WriteLine("7 - Mostrar arbol");
                Console.WriteLine("8 - Buscar en arbol");
                Console.WriteLine("0 - Salir");
                Console.Write("Opcion: ");

                opcion = Leer();

                switch (opcion)
                {
                    case 1:
                        ConsultarTodos();
                        break;

                    case 2:
                        ConsultarPorId();
                        break;

                    case 3:
                        AgregarPokemon();
                        break;

                    case 4:
                        ActualizarPokemon();
                        break;

                    case 5:
                        EliminarPokemon();
                        break;

                    case 6:
                        CrearArbol();
                        break;

                    case 7:
                        MostrarArbol();
                        break;

                    case 8:
                        BuscarEnArbol();
                        break;

                    case 0:
                        Console.WriteLine("Programa terminado.");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        break;
                }

            } while (opcion != 0);
        }

        static void ConsultarTodos()
        {
            using var db = new AppDbContext();

            List<Pokemon> lista = db.pokemon.ToList();

            Console.WriteLine();
            Console.WriteLine("LISTA DE POKEMON");

            foreach (Pokemon p in lista)
            {
                p.Mostrar();
            }
        }

        static void ConsultarPorId()
        {
            Console.Write("Ingrese el ID: ");
            int id = Leer();

            using var db = new AppDbContext();

            Pokemon p = db.pokemon.Find(id);

            if (p == null)
            {
                Console.WriteLine("No existe ese Pokemon.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Pokemon encontrado:");
                p.Mostrar();
            }
        }

        static void AgregarPokemon()
        {
            Console.WriteLine();
            Console.WriteLine("AGREGAR POKEMON");

            Pokemon p = new Pokemon();

            Console.Write("ID: ");
            p.ID = Leer();

            Console.Write("Nombre: ");
            p.Nombre = Console.ReadLine();

            Console.Write("Tipo 1: ");
            p.Tipo_1 = Console.ReadLine();

            Console.Write("Tipo 2: ");
            string tipo = Console.ReadLine();

            if (tipo == "")
            {
                p.Tipo_2 = null;
            }
            else
            {
                p.Tipo_2 = tipo;
            }

            Console.Write("HP: ");
            p.Hp = Leer();

            Console.Write("Ataque: ");
            p.ataque = Leer();

            Console.Write("Defensa: ");
            p.defensa = Leer();

            Console.Write("Ataque especial: ");
            p.ataque_especial = Leer();

            Console.Write("Defensa especial: ");
            p.defensa_especial = Leer();

            Console.Write("Velocidad: ");
            p.velocidad = Leer();

            Console.Write("Nivel: ");
            p.nivel = Leer();

            using var db = new AppDbContext();

            Pokemon buscar = db.pokemon.Find(p.ID);

            if (buscar != null)
            {
                Console.WriteLine("Ya existe un Pokemon con ese ID.");
                return;
            }

            db.pokemon.Add(p);
            db.SaveChanges();

            Console.WriteLine("Pokemon agregado.");
        }

        static void ActualizarPokemon()
        {
            Console.WriteLine();
            Console.WriteLine("MODIFICAR POKEMON");

            Console.Write("Ingrese el ID: ");
            int id = Leer();

            using var db = new AppDbContext();

            Pokemon p = db.pokemon.Find(id);

            if (p == null)
            {
                Console.WriteLine("No existe ese Pokemon.");
                return;
            }

            Console.WriteLine();
            p.Mostrar();

            Console.WriteLine();
            Console.WriteLine("Ingrese los nuevos datos:");

            Console.Write("Nombre: ");
            p.Nombre = Console.ReadLine();

            Console.Write("Tipo 1: ");
            p.Tipo_1 = Console.ReadLine();

            Console.Write("Tipo 2: ");
            string tipo = Console.ReadLine();

            if (tipo == "")
            {
                p.Tipo_2 = null;
            }
            else
            {
                p.Tipo_2 = tipo;
            }

            Console.Write("HP: ");
            p.Hp = Leer();

            Console.Write("Ataque: ");
            p.ataque = Leer();

            Console.Write("Defensa: ");
            p.defensa = Leer();

            Console.Write("Ataque especial: ");
            p.ataque_especial = Leer();

            Console.Write("Defensa especial: ");
            p.defensa_especial = Leer();

            Console.Write("Velocidad: ");
            p.velocidad = Leer();

            Console.Write("Nivel: ");
            p.nivel = Leer();

            db.SaveChanges();

            Console.WriteLine("Pokemon modificado correctamente.");
        }

        static void EliminarPokemon()
        {
            Console.WriteLine();
            Console.WriteLine("ELIMINAR POKEMON");

            Console.Write("Ingrese el ID: ");
            int id = Leer();

            using var db = new AppDbContext();

            Pokemon p = db.pokemon.Find(id);

            if (p == null)
            {
                Console.WriteLine("No existe ese Pokemon.");
                return;
            }

            Console.WriteLine();
            p.Mostrar();

            Console.Write("¿Quiere eliminarlo? s/n: ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s")
            {
                db.pokemon.Remove(p);
                db.SaveChanges();

                Console.WriteLine("Pokemon eliminado.");
            }
            else
            {
                Console.WriteLine("No se elimino.");
            }
        }

        static void CrearArbol()
        {
            Console.WriteLine();
            Console.WriteLine("CREAR ARBOL");

            arbol.Limpiar();

            using var db = new AppDbContext();

            List<Pokemon> lista = db.pokemon.OrderBy(p => p.ID).ToList();

            foreach (Pokemon p in lista)
            {
                arbol.Insertar(p);
            }

            Console.WriteLine("Arbol creado.");
            Console.WriteLine("Cantidad de Pokemon: " + lista.Count);
        }

        static void MostrarArbol()
        {
            Console.WriteLine();
            Console.WriteLine("ARBOL BINARIO");

            if (arbol.raiz == null)
            {
                Console.WriteLine("El arbol esta vacio.");
                Console.WriteLine("Primero cree el arbol.");
                return;
            }

            arbol.Mostrar();
        }

        static void BuscarEnArbol()
        {
            Console.WriteLine();
            Console.WriteLine("BUSCAR EN ARBOL");

            if (arbol.raiz == null)
            {
                Console.WriteLine("El arbol esta vacio.");
                Console.WriteLine("Primero cree el arbol.");
                return;
            }

            Console.Write("Ingrese el ID: ");
            int id = Leer();

            Pokemon p = arbol.Buscar(id);

            if (p == null)
            {
                Console.WriteLine("No se encontro ese Pokemon.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Pokemon encontrado:");
                p.Mostrar();
            }
        }

        static int Leer()
        {
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Ingrese un numero: ");
            }

            return numero;
        }
    }
}
