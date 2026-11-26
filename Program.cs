namespace recuperatorio_arbol
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var deadlock_db = new AppDbContext();
            //agregar
            var Personaje = new personaje
            {
                nombre = "Elpepe",
                genero = "terror"
            };
            try
            {
                Personaje.Personajes.Add(Personaje);
                await Personaje.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                return;
            }
            //eliminar
            int IdPersonajeEliminar = 4;

            var PersonajeEliminar = await Personajes.Personajes.FindAsync(IdPersonajeEliminar);

            if (PersonajeEliminar != null)
            {
                Personajes.Remove(PersonajeEliminar);
                await Personajes.SaveChangesAsync();
            }
            //actualizar
            int IdPersonaje = 2;

            var PersonajeActualizar = await Personajes.Personajes.FindAsync(IdPersonaje);

            if (PersonajeActualizar != null)
            {
                PersonajeActualizar.nombre = "pablo";
                await Personajes.SaveChangesAsync();
            }

            var todos = await Personajes.Personajes.ToListAsync();
            Console.WriteLine("TODOS LOS DATOS:");
            foreach (var i in todos)
            {
                Console.WriteLine(i.Id + " " + i.nombre + " " + i.genero);
            }
        ;
            Console.WriteLine("---------------");
            Arbol elarbolito = new Arbol();

            foreach (var i in todos)
            {
                elarbolito.Insertar(i);
            }
            int IdABuscar = 8;
            elarbolito.Buscar(IdABuscar);

            Personajes[] Lista = await Personajes.Personajes.ToArrayAsync();
            Console.WriteLine("Nombres de la lista sin ordenar: ");
            foreach (Personajes i in Lista)
            {
                Console.WriteLine(i.nombre);
            }
            //ordenamiento borbuja
            void OrdenarEnOrdenAlfabetico(Personajes[] Listita)
            {
                for (int i = 0; i < Listita.Length - 1; i++)
                {
                    for (int x = 0; x < Listita.Length - 1; x++)
                    {
                        string NombreActual = Listita[x].nombre;
                        string NombreMasUno = Listita[x + 1].nombre;
                        if (NombreActual.CompareTo(NombreMasUno) > 0)
                        {
                            Personajes Aux = Listita[x];
                            Listita[x] = Listita[x + 1];
                            Listita[x + 1] = Aux;
                        }
                    }
                }
                Console.WriteLine("Nombres en orden:");
                foreach (var nombre in Listita)
                {
                    Console.WriteLine(nombre.nombre);
                }
            }
            OrdenarEnOrdenAlfabetico(Lista);
        }
    }
}
