string[,] mazo = { { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" } };
string[] palo = ["Diamante", "Picas", "Treboles", "Corazones"];
string[,] mano = new string[8, 2];
Random random = new Random();
int opcion;
bool pedirCarta = false;

try
{
    do
    {
        Console.WriteLine("Elija una opción:");
        Console.WriteLine("1-Pedir cartas, 2-Descartar cartas, 3-Salir programa");

        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Pedir_carta();
                break;
            case 2:
                Descartar_carta();
                break;
            case 3:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opcion incorreta, intente de nuevo");
                break;
        }
    } while (opcion != 3);
}
catch (FormatException)
{
    Console.WriteLine("Ingrese un numero valido");
}
void Pedir_carta()
{
    pedirCarta = true;
    for (int f = 0; f < mano.GetLength(0); f++)
    {
        int columna = random.Next(mazo.GetLength(1));

        mano[f, 0] = mazo[0, columna];
        mano[f, 1] = palo[random.Next(palo.Length)];
    }
    Console.WriteLine("Tus cartas: ");
    Mostrar_carta();
}
void Descartar_carta()
{
    try
    {
        if (!pedirCarta)
        {
            Console.WriteLine("Primero debe pedir cartas antes de descartar");
        }
        else
        {
            Console.Write("¿Cuántas cartas deseas descartar?: ");
            Console.WriteLine("");
            int descarte = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= descarte; i++)
            {
                Console.Write("Ingrese la posición de la carta a descartar de 0-7 ");
                Console.WriteLine("");
                int posicion = Convert.ToInt32(Console.ReadLine());
                i++;

                while (posicion < 0 || posicion >= mano.GetLength(0))
                {
                    Console.Write("Posición inválida, intente de nuevo: ");
                    posicion = Convert.ToInt32(Console.ReadLine());
                }

                int columna = random.Next(mazo.GetLength(1));

                mano[posicion, 0] = mazo[0, columna];
                mano[posicion, 1] = palo[random.Next(palo.Length)];
            }

            Console.WriteLine("Mano actualizada:");
            Mostrar_carta();
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Solo se permiten numeros");
    }
}
void Mostrar_carta()
{
    for (int f = 0; f < mano.GetLength(0); f++)
    {
        Console.WriteLine(mano[f, 0] + " de " + mano[f, 1]);
    }
}