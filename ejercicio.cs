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
