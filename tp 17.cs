//ejercicio 1
int[][] triangulo = new int[4][];

triangulo[0] = new int[1];
triangulo[1] = new int[2];
triangulo[2] = new int[3];
triangulo[3] = new int[4];

int numero = 1;

for (int i = 0; i < triangulo.Length; i++)
{
    for (int j = 0; j < triangulo[i].Length; j++)
    {
        triangulo[i][j] = numero;
        numero++;
    }
}

for (int i = 0; i < triangulo.Length; i++)
{
    for (int j = 0; j < triangulo[i].Length; j++)
    {
        Console.Write(triangulo[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("");
//ejercicio 2
int[][] numeros = {
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int cantidadTotal = 0;

for (int i = 0; i < numeros.Length; i++)
{
    cantidadTotal += numeros[i].Length;
}

Console.WriteLine("total: " + cantidadTotal);
Console.WriteLine("");
//ejercicio 3
int[][] datos = {
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int longitudMaxima = 0;
int indiceFila = 0;

for (int i = 0; i < datos.Length; i++)
{
    if (datos[i].Length > longitudMaxima)
    {
        longitudMaxima = datos[i].Length;
        indiceFila = i;
    }
}

Console.WriteLine("fila: " + indiceFila);
Console.WriteLine("elementos: " + longitudMaxima);
Console.WriteLine("");
//ejercicio 4
int[][] valores = {
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int[] resultados = new int[valores.Length];

for (int i = 0; i < valores.Length; i++)
{
    for (int j = 0; j < valores[i].Length; j++)
    {
        resultados[i] += valores[i][j];
    }
}

for (int i = 0; i < resultados.Length; i++)
{
    Console.WriteLine("suma: " + resultados[i]);
}
Console.WriteLine("");
//ejercicio 5
int[][] cantidades = {
    new int[] { 1, 2 },
    new int[] { 3, 15, 5, 6 },
    new int[] { 7, 8, 9 }
};

int valorMaximo = cantidades[0][0];
int posicionFila = 0;
int posicionColumna = 0;

for (int i = 0; i < cantidades.Length; i++)
{
    for (int j = 0; j < cantidades[i].Length; j++)
    {
        if (cantidades[i][j] > valorMaximo)
        {
            valorMaximo = cantidades[i][j];
            posicionFila = i;
            posicionColumna = j;
        }
    }
}

Console.WriteLine("maximo: " + valorMaximo);
Console.WriteLine("fila: " + posicionFila);
Console.WriteLine("columna: " + posicionColumna);
Console.WriteLine("");
//ejercicio 6
int[][] calificaciones = {
    new int[] { 8, 9 },
    new int[] { 6, 7, 10, 8 },
    new int[] { 9, 10, 8 }
};

for (int i = 0; i < calificaciones.Length; i++)
{
    int sumaNotas = 0;

    for (int j = 0; j < calificaciones[i].Length; j++)
    {
        sumaNotas += calificaciones[i][j];
    }

    double promedioAlumno = (double)sumaNotas / calificaciones[i].Length;

    Console.WriteLine("promedio: " + promedioAlumno);
}
Console.WriteLine("");
//ejercicio 7
static bool BuscarNumero(int[][] elementos, int buscado)
{
    for (int i = 0; i < elementos.Length; i++)
    {
        for (int j = 0; j < elementos[i].Length; j++)
        {
            if (elementos[i][j] == buscado)
            {
                return true;
            }
        }
    }

    return false;
}

int[][] valoresBusqueda = {
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

Console.WriteLine(BuscarNumero(valoresBusqueda, 5));