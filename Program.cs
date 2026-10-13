namespace evaluacion_AyE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero segun la opcion que quiera realizar");
            Console.WriteLine("0-salir");
            Console.WriteLine("1-actualizar dato");
            Console.WriteLine("2-eliminar dato");
            Console.WriteLine("3-agregar dato");
            Console.WriteLine("4-consultar dato");
            Console.WriteLine("5-buscar agente en el arbol binario");
            Console.WriteLine("6-ordenar la lista de agentes en orden alfabetico");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("saliendo");
                    break;
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.WriteLine("");
                    break;
            }
        }
    }

}
