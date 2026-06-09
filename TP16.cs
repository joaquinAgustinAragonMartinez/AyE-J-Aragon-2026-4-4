Console.WriteLine("ejercicio 1");

int[,] matriz = new int[4, 4]
{
    {1,  2,  3,  4},
    {5,  6,  7,  8},
    {9,  10, 11, 12},
    {13, 14, 15, 16}
};

int acum = matriz[0, 0] + matriz[0, 3] + matriz[3, 0] + matriz[3, 3];

Console.WriteLine("La suma de todas las esquinas es " + acum);


Console.WriteLine("");
Console.WriteLine("ejercicio 2");

int[,] matriz2 = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int acum2 = 0;
int acum3 = 0;

for (int fila2 = 0; fila2 < 3; fila2++)
{
    for (int columna2 = 0; columna2 < 3; columna2++)
    {
        if (fila2 == columna2)
        {
            acum2 += matriz2[fila2, columna2];
        }

        if (fila2 + columna2 == 2)
        {
            acum3 += matriz2[fila2, columna2];
        }
    }
}

Console.WriteLine("La suma de la diagonal principal es " + acum2);
Console.WriteLine("La suma de la diagonal secundaria es " + acum3);

Console.WriteLine("");
Console.WriteLine("ejercicio 3");
Console.WriteLine("Ingrese que numero de filas y columnas va a tener su matriz");
int Largo = int.Parse(Console.ReadLine());

int[,] matriz3 = new int[Largo, Largo];

for (int fila = 0; fila < Largo; fila++)
{
    for (int columna = 0; columna < Largo; columna++)
    {
        if (fila == columna)
        {
            matriz3[fila, columna] = 1;
        }
        else
        {
            matriz3[fila, columna] = 0;
        }
        Console.Write(matriz3[fila, columna] + " ");
    }
    Console.WriteLine();
}