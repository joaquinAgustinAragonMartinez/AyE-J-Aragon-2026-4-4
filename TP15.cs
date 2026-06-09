Console.WriteLine("ejercicio 1");
int[,] matriz = new int[3, 3]
{
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 }
};

for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {
        Console.Write(matriz[fila, columna] + " ");
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("ejercicio 2");
int acum = 0;
int[,] matriz2 = new int[3, 3]
{
    {10, 20, 30 },
    {40, 50, 60 },
    {70, 80, 90 }
};

for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {
        Console.Write(matriz2[fila, columna] + " ");
        acum = acum + (matriz2)[fila, columna];
    }
    Console.WriteLine("");
}
Console.WriteLine("la suma de todos esos numeros es " + acum);

Console.WriteLine("");
Console.WriteLine("ejercicio 3");
int[,] matriz3 = new int[4, 4]
{
    {1, 2, 3, 4 },
    {5, 6, 7, 8 },
    {9, 10, 11, 12},
    {13, 14, 15, 16}
};
Console.WriteLine("ingrese una fila del 0 al 3");
int fila2 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese una columna del 0 al 3");
int columna2 = int.Parse(Console.ReadLine());

for (int filas = 0; filas < 4; filas++)
{
    for (int columnas = 0; columnas < 4; columnas++)
    {
        if (fila2 == filas && columna2 == columnas)
        {
            Console.WriteLine("el elemento es "+ matriz3[fila2, columna2]);
        }
    }
}

Console.WriteLine("");
Console.WriteLine("ejercicio 4");
int[,] matriz4 = new int[4, 4]
{
    {2, 4, 6, 8 },
    {10, 12, 14, 16 },
    {18, 20, 22, 24},
    {26, 28, 30, 32}
};

int nummasgrande = matriz[0, 0];

for (int filas3 = 0; filas3 < 4; filas3++)
{
    for (int columnas3 = 0; columnas3 < 4; columnas3++)
    { 
        if (matriz4[filas3, columnas3] > nummasgrande)
        {
            nummasgrande = matriz4[filas3, columnas3];
        }
    }
}
Console.WriteLine("el numero mas grande de la matriz es " + nummasgrande);

Console.WriteLine("");
Console.WriteLine("ejercicio 5");
int[,] matriz5 = new int[4, 4]
{
    {5, 10, 15, 20 },
    {25, 30, 35, 40 },
    {45, 50, 55, 60},
    {65, 70, 75, 80}
};

for (int i = 0; i < 4; i++)
{
    int suma = 0;

    for (int j = 0; j < 4; j++)
    {
        suma += matriz5[i ,j];
    }

    Console.WriteLine("fila "+ i + ": "+ suma);
}
for (int j = 0; j < 4; j++)
{
    int suma = 0;

    for (int i = 0; i < 4; i++)
    {
        suma += matriz5[i, j];
    }

    Console.WriteLine("columna " + j + ": " + suma);
}

Console.WriteLine("");
Console.WriteLine("ejercicio 6");
int[,] matriz6 =
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {13, 14, 15, 16}
};

for (int columna = 0; columna < 4; columna++)
{
    for (int fila = 0; fila < 4; fila++)
    {
        Console.Write(matriz6[fila, columna] + " ");
    }

    Console.WriteLine();
}

Console.WriteLine("");
Console.WriteLine("ejercicio 7");
int[,] matriz7 =
{
    {1, 5, 3, 5},
    {8, 5, 9, 2},
    {4, 5, 6, 7}
};

Console.WriteLine("Ingrese un numero:");
int numero = int.Parse(Console.ReadLine());

int contador = 0;

for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        if (matriz7[fila, columna] == numero)
        {
            contador++;
        }
    }
}

Console.WriteLine("Aparece " + contador + " veces");

Console.WriteLine("");
Console.WriteLine("ejercicio 8");
int[,] matriz8 =
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    {13, 14, 15, 16}
};

int suma2 = 0;

for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        suma2 += matriz8[fila, columna];
    }
}

double promedio = suma2 / 16.0;

int[,] nuevaMatriz = new int[4, 4];

for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        if (matriz8[fila, columna] < promedio)
        {
            nuevaMatriz[fila, columna] = (int)promedio;
        }
        else
        {
            nuevaMatriz[fila, columna] = matriz8[fila, columna];
        }
    }
}

for (int fila = 0; fila < 4; fila++)
{
    for (int columna = 0; columna < 4; columna++)
    {
        Console.Write(nuevaMatriz[fila, columna] + " ");
    }

    Console.WriteLine();
}