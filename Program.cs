namespace tp_23
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            AppDbContext db = new AppDbContext();
            ArbolPokemon miArbol = new ArbolPokemon();

            CargarArbolDesdeDB(db, arbol);

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("bienvenido al menu de opciones ingrese el numero de la opcion que quiere elegir");
                Console.WriteLine("1--consultar base de datos en xampp");
                Console.WriteLine("2--actualizar pokemon");
                Console.WriteLine("3--actualizar datos de un pokemon");
                Console.WriteLine("4--eliminar pokemon");
                Console.WriteLine("5--sincronizar y reconstruir base de datos");
                Console.WriteLine("6--hacer busqueda binaria en el arbol");
                Console.WriteLine("7--salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    
                }
            }

        }
    }
}
