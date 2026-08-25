namespace tp_19
{
    public class Program
    {
        public void Main(string[] args)
        {
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
        }

    }
}
