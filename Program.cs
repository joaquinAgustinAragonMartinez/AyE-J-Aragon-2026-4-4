using System.Security.Cryptography.X509Certificates;

namespace tp_21
{
    public class Program
    {
        static void Main(string[] args)
        {

            ArbolBusqueda miArbol = new ArbolBusqueda();

            miArbol.Insertar(50);
            miArbol.Insertar(60);
            miArbol.Insertar(20);
            miArbol.Insertar(67);
            miArbol.Insertar(76);
            miArbol.Insertar(90);


            Console.WriteLine("minimo: " + miArbol.ObtenerMinimo());
            Console.WriteLine("maximo: " + miArbol.ObtenerMaximo());
            Console.WriteLine("cantidad de nodos almacenados: " + miArbol.ObtenerCantidadNodos());
            Console.WriteLine("altura del arbol: "+ miArbol.ObtenerAltura());
            Console.WriteLine("cantidad de hojas: " + miArbol.ObtenerHojas());

            Console.WriteLine("");
            
        }
    }
}
