int intentos = 0;
int tesoros_restantes = 3;

string[,] matriz = new string[10, 10];
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        matriz[i, j] = "_";
        Console.Write("_ ");
    }
    Console.WriteLine();
}

int[,] tesoros = new int[3, 2];

for (int i = 0; i < 3; i++)
{
    tesoros[i, 0] = random.Next(10);
    tesoros[i, 1] = random.Next(10);
}

bool[,] encontrados = new bool[3, 1];

while (intentos < 5 && tesoros_restantes > 0)
{
    try
    {
        Console.WriteLine("Ingrese fila (0-9):");
        int fila = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese columna (0-9):");
        int columna = int.Parse(Console.ReadLine());

        if (fila < 0 || fila >= 10 || columna < 0 || columna >= 10)
        {
            Console.WriteLine("ingrese una coordenada valida");
            continue;
        }

        bool encontrado = false;

        for (int i = 0; i < 3; i++)
        {
            if (tesoros[i, 0] == fila && tesoros[i, 1] == columna && !encontrados[i, 0])
            {
                Console.WriteLine("encontraste un tesoro");
                matriz[fila, columna] = "X";
                encontrados[i, 0] = true;
                tesoros_restantes--;
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("no habia tesoro ahi");
            intentos++;
        }

        Console.WriteLine("intentos " + intentos);
        Console.WriteLine("tesoros restantes " + tesoros_restantes);
    }
    catch
    {
        Console.WriteLine("error: ingrese números validos");
    }
}

if (tesoros_restantes == 0)
{
    Console.WriteLine("ganaste!");
}
else
{
    Console.WriteLine("perdiste!");
}