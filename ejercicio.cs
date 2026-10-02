namespace tp_19
{
    public class Program
    {
        public void Main(string[] args)
        {
            //ejercicio 1
            Console.WriteLine("Ingrese una pakabra o frase");
            string texto = Console.ReadLine();
            Invertir(texto);

            string Invertir(string texto)
            {
                Stack<char> letras = new Stack<char>();

                foreach (char letra in texto)
                {
                    letras.Push(letra);
                }

                string Invertido = "";

                for (int l = 0; l < texto.Length; l++)
                {
                    char ultimaletra = letras.Pop();
                    Invertido += ultimaletra;
                }
                Console.WriteLine($"La palabra invertida es: {Invertido}");
                return Invertido;

            }
            //ejercicio 2
            Stack<string> historial = new Stack<string>();

string paginaActual = "Inicio";

int opcion;

do
{
    Console.WriteLine("Página actual: " + paginaActual);
    Console.WriteLine("1. Visitar nueva página");
    Console.WriteLine("2. Atrás");
    Console.WriteLine("3. Salir");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.Write("Ingrese la URL: ");
        string nuevaPagina = Console.ReadLine();

        historial.Push(paginaActual);
        paginaActual = nuevaPagina;
    }
    else if (opcion == 2)
    {
        if (historial.Count > 0)
        {
            paginaActual = historial.Pop();
        }
        else
        {
            Console.WriteLine("No hay páginas anteriores.");
        }
    }

} while (opcion != 3);
            //ejercicio 3
            static bool DelimitadoresCorrectos(string expresion)
{
    Stack<char> pila = new Stack<char>();

    foreach (char caracter in expresion)
    {
        if (caracter == '(' || caracter == '[' || caracter == '{')
        {
            pila.Push(caracter);
        }
        else if (caracter == ')' || caracter == ']' || caracter == '}')
        {
            if (pila.Count == 0)
            {
                return false;
            }

            char ultimo = pila.Pop();

            if (caracter == ')' && ultimo != '(')
            {
                return false;
            }

            if (caracter == ']' && ultimo != '[')
            {
                return false;
            }

            if (caracter == '}' && ultimo != '{')
            {
                return false;
            }
        }
    }

    return pila.Count == 0;
}
            
            //ejercicio 4
string texto = " ";
int opcion, opcion2;
Stack<AccionTexto> Acciones = new Stack<AccionTexto>();
AccionTexto laAcciondelPeek;
do
{
    Console.WriteLine("queres desacer -1 o escribir -2 ?");
    opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion == 1)
    {
        Acciones.TryPop(out AccionTexto resultado);
        Acciones.TryPeek(out AccionTexto resultado1);
        if (resultado1.Contenido == null)
        {
            Console.WriteLine("no se epude desacer mas");
        }
        else
        {
            Console.WriteLine(resultado1.Contenido);
        }
    }
    else
    {
        Console.WriteLine("ingresa algo");
        texto = texto + Console.ReadLine();
        laAcciondelPeek = new AccionTexto("escritura", texto, "6767676767");
        Acciones.Push(laAcciondelPeek);
    }
    Console.WriteLine("seguimos? si = 1 no = 2");
    opcion2 = Convert.ToInt32(Console.ReadLine());
}
while (opcion2 != 2);
        }

    }
}
//ejercicio 5
static double CalcularRPN(string expresion)
{
    Stack<double> pila = new Stack<double>();

    string[] elementos = expresion.Split(' ');

    foreach (string elemento in elementos)
    {
        if (double.TryParse(elemento, out double numero))
        {
            pila.Push(numero);
        }
        else
        {
            double numero2 = pila.Pop();
            double numero1 = pila.Pop();

            if (elemento == "+")
            {
                pila.Push(numero1 + numero2);
            }
            else if (elemento == "-")
            {
                pila.Push(numero1 - numero2);
            }
            else if (elemento == "*")
            {
                pila.Push(numero1 * numero2);
            }
            else if (elemento == "/")
            {
                pila.Push(numero1 / numero2);
            }
        }
    }

    return pila.Pop();
}

//ejercicio 6
    class Tarea
{
    public int Id;
    public string Titulo;
    public int Prioridad;
    public int EstimacionMinutos;

    public Tarea(int id, string titulo, int prioridad, int estimacionMinutos)
    {
        Id = id;
        Titulo = titulo;
        Prioridad = prioridad;
        EstimacionMinutos = estimacionMinutos;
    }
}

class Program
{
    static void Main()
    {
        Stack<Tarea> tareas = new Stack<Tarea>();

        tareas.Push(new Tarea(1, "Hacer TP", 2, 60));
        tareas.Push(new Tarea(2, "Estudiar", 1, 40));
        tareas.Push(new Tarea(3, "Programar", 3, 90));

        // Ver la tarea que está en la cima
        if (tareas.Count > 0)
        {
            Tarea tarea = tareas.Peek();

            Console.WriteLine("Tarea en la cima:");
            Console.WriteLine("Id: " + tarea.Id);
            Console.WriteLine("Titulo: " + tarea.Titulo);
            Console.WriteLine("Prioridad: " + tarea.Prioridad);
            Console.WriteLine("Estimacion: " + tarea.EstimacionMinutos + " minutos");
        }

        Console.WriteLine();

        // Atender la última tarea ingresada
        if (tareas.Count > 0)
        {
            Tarea tarea = tareas.Pop();

            Console.WriteLine("Atendiendo tarea: " + tarea.Titulo);
        }

        Console.WriteLine();

        // Mostrar la siguiente tarea
        if (tareas.Count > 0)
        {
            Tarea tarea = tareas.Peek();

            Console.WriteLine("Ahora la tarea en la cima es: " + tarea.Titulo);
        }
    }
}
