namespace tp_n_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 1");
            Punto2D punto = new Punto2D(5, 10);
            punto.Mostrar();
            Console.WriteLine("ejercicio 2");
            Dimensiones D1 = new Dimensiones(10, 20);
            Dimensiones D2 = D1;
            D2 = new Dimensiones(99, 20);
            D1.Mostrar2();
            D2.Mostrar3();
            //el ancho de d1 no se cambio porque los struct solo copian el valor y como Dimensiones lo es paso eso
            Console.WriteLine("ejercicio 3");
            Producto[] productos = new Producto[3];
            productos[0] = new Producto("Mouse", 101, 15000);
            productos[1] = new Producto("Teclado", 102, 28000);
            productos[2] = new Producto("Monitor", 103, 180000);
            foreach (Producto producto in productos)
            {
                producto.Mostrar4();
            }
            Console.WriteLine("ejercicio 4");
            Estudiante estudiante = new Estudiante("jose", 8.25, 7.5, 9.5);
            estudiante.CalcularPromedio();
        }
        public struct Punto2D
        {
            // Propiedades
            public int X { get; set; }
            public int Y { get; set; }

            // Constructor

            public Punto2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Método
            public void Mostrar()
            {
                Console.WriteLine("La posicion en x es: " + X + " y en y es: " + Y);
            }
        }
        public struct Dimensiones
        {
            public int D1 { get; set; }
            public int D2 { get; set; }

            public Dimensiones(int ancho, int alto)
            {
                D1 = ancho;
                D2 = alto;
            }
            public void Mostrar2()
            {
                Console.WriteLine("Los valores de D1 son el ancho: " + D1 + " y el alto: " + D2);
            }
            public void Mostrar3()
            {
                Console.WriteLine("los valores de D2 son el ancho: " + D1 + " y el alto: " + D2);
            }
        }
        public struct Producto
        {
            // Propiedades
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public double Precio { get; set; }

            // Constructor
            public Producto(string nombre, int codigo, double precio)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;
            }

            // Método
            public void Mostrar4()
            {
                Console.WriteLine("Nombre: " + Nombre + " - Precio: $" + Precio);
            }
        }
        public struct Estudiante
        {
            // Propiedades
            public string Alumno { get; set; }
            public double Nota1 { get; set; }
            public double Nota2 { get; set; }
            public double Nota3 { get; set; }

            // Constructor
            public Estudiante(string alumno, double nota1, double nota2, double nota3)
            {
                Alumno = alumno;
                Nota1 = nota1;
                Nota2 = nota2;
                Nota3 = nota3;
            }

            // Método
            public void CalcularPromedio()
            {
                double Promedio = (Nota1 + Nota2 + Nota3) / 3;
                Console.WriteLine("el promedio final del estudiante "+ Alumno+ "es: "+ Promedio);
            }
        }
    }
}