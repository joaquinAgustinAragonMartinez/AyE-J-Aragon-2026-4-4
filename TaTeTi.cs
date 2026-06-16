bool valor_correcto;
int cont = 0;
bool ganador_verificadoX = false;
bool ganador_verificadoO = false;
string[,] matriz = new string[3, 3];

Console.WriteLine("ingrese el nombre del jugador 1");
string jugador_x = Console.ReadLine();

Console.WriteLine("ingrese el nombre del jugador 2");
string jugador_o = Console.ReadLine();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matriz[i, j] = "_";
        Console.Write(matriz[i, j]);
    }
    Console.WriteLine();
}

void PrimerTurno()
{
    valor_correcto = false;

    while (valor_correcto == false)
    {
        try
        {
            Console.WriteLine("es el turno de " + jugador_x + " , a continuacion indique la posicion");
            Console.WriteLine("indique la coordenada de la fila");
            int fila = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("indique la coordenada de la columna");
            int columna = int.Parse(Console.ReadLine()) - 1;

            if (fila < 0 || fila > 2 || columna < 0 || columna > 2)
            {
                Console.WriteLine("ingrese una coordenada correcta");
                continue;
            }

            if (matriz[fila, columna] == "x" || matriz[fila, columna] == "o")
            {
                Console.WriteLine("casiila ya ocupada, ingrese otra coordenada");
                continue;
            }

            matriz[fila, columna] = "x";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j]);

                }
                Console.WriteLine("");
            }
            valor_correcto = true;
            cont++;
        }
        catch (FormatException)
        {
            Console.WriteLine("solo debe ingresar numeros");
            continue;
        }
    }
}
void SegundoTurno()
{
    valor_correcto = false;

    while (valor_correcto == false)
    {
        try
        {
            Console.WriteLine("es el turno de " + jugador_o + " , a continuacion indique la posicion");
            Console.WriteLine("indique la coordenada de la fila");
            int fila = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("indique la coordenada de la columna");
            int columna = int.Parse(Console.ReadLine()) - 1;

            if (fila < 0 || fila > 2 || columna < 0 || columna > 2)
            {
                Console.WriteLine("ingrese una coordenada correcta");
                continue;
            }

            if (matriz[fila, columna] == "x" || matriz[fila, columna] == "o")
            {
                Console.WriteLine("casiila ya ocupada, ingrese otra coordenada");
                continue;
            }

            matriz[fila, columna] = "o";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j]);

                }
                Console.WriteLine("");
            }
            valor_correcto = true;
            cont++;
        }
        catch (FormatException)
        {
            Console.WriteLine("solo debe ingresar numeros");
            continue;
        }
    }
}

void VerificarGanadorX()
{
    for (int i = 0; i < 3; i++)
    {
        if (matriz[i, 0] == "x" && matriz[i, 1] == "x" && matriz[i, 2] == "x")
        {
            ganador_verificadoX = true;
        }
        if (matriz[0, i] == "x" && matriz[1, i] == "x" && matriz[2, i] == "x")
        {
            ganador_verificadoX = true;
        }
    }
    if (matriz[0, 0] == "x" && matriz[1, 1] == "x" && matriz[2, 2] == "x")
    {
        ganador_verificadoX = true;
    }
    if (matriz[2,0] == "x" && matriz[1,1] == "x" && matriz[0,2] == "x")
    {
        ganador_verificadoX = true;
    }
}

void VerificarGanadorO()
{
    for (int i = 0; i < 3; i++)
    {
        if (matriz[i, 0] == "o" && matriz[i, 1] == "o" && matriz[i, 2] == "o")
        {
            ganador_verificadoO = true;
        }
        if (matriz[0, i] == "o" && matriz[1, i] == "o" && matriz[2, i] == "o")
        {
            ganador_verificadoO = true;
        }
    }
    if (matriz[0, 0] == "o" && matriz[1, 1] == "o" && matriz[2, 2] == "o")
    {
        ganador_verificadoO = true;
    }
    if (matriz[2, 0] == "o" && matriz[1, 1] == "o" && matriz[0, 2] == "o")
    {
        ganador_verificadoO = true;
    }
}

while (ganador_verificadoX == false && ganador_verificadoO == false && cont < 9)
{
    PrimerTurno();
    VerificarGanadorX();
    if (ganador_verificadoX == false && cont < 9)
    {
        SegundoTurno();
        VerificarGanadorO();
    }
}

if (ganador_verificadoX)
{
    Console.WriteLine("ha ganado el tateti " +jugador_x);
}
else if (ganador_verificadoO)
{
    Console.WriteLine("ha ganado el tateti " + jugador_o);
}
else
{
    Console.WriteLine("empate!");
}