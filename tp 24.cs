namespace tp_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1
            Console.WriteLine("ingrese un numero de 2 cifras");
            int numero = Convert.ToInt32(Console.ReadLine());
            int unidades;
            int decenas;
            unidades = numero % 10;
            decenas = numero / 10;

            string rutaEntrada = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada, append: false))
            {
                writer.WriteLine(unidades);
                writer.WriteLine(decenas);
            }
            using (StreamReader reader = new StreamReader(rutaEntrada))
            {
                decenas = Convert.ToInt32(reader.ReadLine());
                unidades = Convert.ToInt32(reader.ReadLine());
                Console.WriteLine(decenas);
                Console.WriteLine(unidades);
            }
            //ejercicio 2
            Console.WriteLine("Indicar un número de tres cifras");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int central;
            central = (numero2 / 10) % 10;

            string rutaEntrada2 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada2, append: false))
            {
                writer.WriteLine("Valor: " + numero2);
                writer.WriteLine("La cifra central es: " + central);
            }

            using (StreamReader reader = new StreamReader(rutaEntrada2))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            //ejercicio 3
            Console.WriteLine("Indicar precio de lista");
            double precio = Convert.ToDouble(Console.ReadLine());

            double descuento;
            double precioFinal;

            descuento = precio * 0.18;
            precioFinal = precio - descuento;

            string rutaEntrada3 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada3, append: false))
            {
                writer.WriteLine("Precio de lista: $" + precio.ToString("F2"));
                writer.WriteLine("Descuento: 18% sobre el precio de lista.");
                writer.WriteLine("Precio con descuento: $" + precioFinal.ToString("F2"));
            }

            using (StreamReader reader = new StreamReader(rutaEntrada3))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }

            //ejercicio 4
            Console.WriteLine("Indicar un número de dos cifras");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            int unidades4;
            int decenas4;
            int permutado;

            unidades4 = numero4 % 10;
            decenas4 = numero4 / 10;
            permutado = unidades4 * 10 + decenas4;

            string rutaEntrada4 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada4, append: false))
            {
                writer.WriteLine("Valor: " + numero4);
                writer.WriteLine("Valor permutado: " + permutado);
            }

            using (StreamReader reader = new StreamReader(rutaEntrada4))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }

            //ejercicio 5
            Console.WriteLine("Indicar una fecha como un entero de 6 dígitos");
            int fecha = Convert.ToInt32(Console.ReadLine());

            int mes;
            mes = (fecha / 100) % 100;

            string rutaEntrada5 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada5, append: false))
            {
                writer.WriteLine("Fecha: " + fecha.ToString("D6"));
                writer.WriteLine("Mes: " + mes.ToString("D2"));
            }

            using (StreamReader reader = new StreamReader(rutaEntrada5))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            //ejercicio 6
            Console.WriteLine("Indicar el lado del cuadrado");
            double lado = Convert.ToDouble(Console.ReadLine());

            double perimetro;
            double superficie;

            perimetro = lado * 4;
            superficie = lado * lado;

            string rutaEntrada6 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada6, append: false))
            {
                writer.WriteLine("Perímetro: " + perimetro);
                writer.WriteLine("Superficie: " + superficie);
            }

            using (StreamReader reader = new StreamReader(rutaEntrada6))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            //ejercicio 7
            Console.WriteLine("Indicar el valor de una hora de trabajo");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indicar la cantidad de horas trabajadas");
            double horas = Convert.ToDouble(Console.ReadLine());

            double sueldo;
            sueldo = valorHora * horas;

            string rutaEntrada7 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada7, append: false))
            {
                writer.WriteLine("Valor de la hora: $" + valorHora);
                writer.WriteLine("Horas trabajadas: " + horas);
                writer.WriteLine("Sueldo bruto: $" + sueldo);
            }

            using (StreamReader reader = new StreamReader(rutaEntrada7))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            //ejercicio 8
            Console.WriteLine("Indicar temperatura en grados Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius;
            celsius = (fahrenheit - 32) * 5 / 9;

            string rutaEntrada8 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada8, append: false))
            {
                writer.WriteLine("Temperatura en Fahrenheit: " + fahrenheit);
                writer.WriteLine("Temperatura en Celsius: " + celsius);
            }

            using (StreamReader reader = new StreamReader(rutaEntrada8))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            //ejercicio 9
            Console.WriteLine("Indicar la hora del primer instante");
            int hora1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los minutos del primer instante");
            int minutos1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los segundos del primer instante");
            int segundos1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar la hora del segundo instante");
            int hora2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los minutos del segundo instante");
            int minutos2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los segundos del segundo instante");
            int segundos2 = Convert.ToInt32(Console.ReadLine());

            int instante1;
            int instante2;
            int intervalo;

            instante1 = hora1 * 3600 + minutos1 * 60 + segundos1;
            instante2 = hora2 * 3600 + minutos2 * 60 + segundos2;

            intervalo = Math.Abs(instante2 - instante1);

            string rutaEntrada9 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada9, append: false))
            {
                writer.WriteLine("Segundos del intervalo: " + intervalo);
            }

            using (StreamReader reader = new StreamReader(rutaEntrada9))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
            //ejercicio 10
            Console.WriteLine("Indicar un número de tres dígitos");
            int numero10 = Convert.ToInt32(Console.ReadLine());

            int unidades10;
            int decenas10;
            int centenas10;

            unidades10 = numero10 % 10;
            decenas10 = (numero10 / 10) % 10;
            centenas10 = numero10 / 100;

            string rutaEntrada10 = "archivo.txt";

            using (StreamWriter writer = new StreamWriter(rutaEntrada10, append: false))
            {
                writer.WriteLine("Valor ingresado: " + numero10);
                writer.WriteLine("Unidades: " + unidades10);
                writer.WriteLine("Decenas: " + decenas10);
                writer.WriteLine("Centenas: " + centenas10);
            }

            using (StreamReader reader = new StreamReader(rutaEntrada10))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
    }
}
