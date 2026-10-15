using System;
using System.IO;
namespace archivos_de_texto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1
            Console.WriteLine("ejercicio 1");
            Console.WriteLine("ingrese un numero de 2 cifras");
            int numero = Convert.ToInt32(Console.ReadLine());
            int unidades;
            int decenas;
            unidades = numero % 10;
            decenas = numero / 10;
            //ejercicio 2
            Console.WriteLine("ejercicio 2");
            Console.WriteLine("ingrese un numero de 3 cifras");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int central = (numero2 / 10) % 10;
            //ejercicio 3
            Console.WriteLine("")

            string rutaEntrada = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada, append: false))
            {
                //ejercicio 1
                writer.WriteLine(unidades);
                writer.WriteLine(decenas);
                //ejercicio 2
                writer.WriteLine(central);
            }
            using (StreamReader reader = new StreamReader(rutaEntrada))
            {
                //ejercicio 1
                Console.WriteLine();
                Console.WriteLine("ejercicio 1");
                decenas = Convert.ToInt32(reader.ReadLine());
                unidades = Convert.ToInt32(reader.ReadLine());
                Console.Write("decenas: ");
                Console.WriteLine(decenas);
                Console.Write("unidades: ");
                Console.WriteLine(unidades);
                //ejercicio 2
                Console.WriteLine();
                Console.WriteLine("ejercicio 2");
                central = Convert.ToInt32(reader.ReadLine());
                Console.Write("el numero central es: ");
                Console.WriteLine(central);
                //ejercicio 3
                Console.WriteLine();
                Console.WriteLine("ejercicio 3");

            }
        }
    }
}