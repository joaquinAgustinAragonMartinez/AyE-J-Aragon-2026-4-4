Console.WriteLine("ejercicio 1");
int[] numeros = new int[5];
int cont = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("ingrese un numero");
    numeros[i] = int.Parse(Console.ReadLine());
    cont++;
}
if (cont == 5)
{
    Console.WriteLine("los numeros ingresados son");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("");
Console.WriteLine("ejercicio 2");
string[] frutas = { "", "pera", "manzana", "banana", "uvas", "sandia" };
int posicion = -1;

Console.WriteLine("ingrese una fruta");
string fruta = Console.ReadLine();

for (int i = 1; i < frutas.Length; i++)
{
    if (frutas[i] == fruta)
    {
        posicion = i;
        Console.WriteLine("la fruta " + fruta + " fue encontrada en la lista en la posicion numero " + posicion);
        break;
    }
}
if (posicion == -1)
{
    Console.WriteLine("la fruta no fue encontrada");
}

Console.WriteLine("");
Console.WriteLine("ejercicio 3");
int[] notas = { 0, 6, 7, 3, 8, 2, 9, 4, 10, 2, 5 };
int suma = 0;

for (int i = 1; i < notas.Length; i++)
{
    suma += notas[i];
}

double promedio = (double)suma / notas.Length;

Console.WriteLine("la suma de las notas es " + suma + " y el promedio de las notas es " + promedio);

Console.WriteLine("");
Console.WriteLine("ejercicio 4");
int[] temperaturas = { 24, 32, 17, 12, 10, 35, 5, 10, 22 };
int mayortemp = temperaturas[0];
int menortemp = temperaturas[0];

for (int i = 1; i < temperaturas.Length; i++)
{
    if (temperaturas[i] > mayortemp)
    {
        mayortemp = temperaturas[i];
    }
    if (temperaturas[i] < menortemp)
    {
        menortemp = temperaturas[i];
    }
}

Console.WriteLine("la mayor temperatura es " + mayortemp + "°C y la menor temperatura es " + menortemp + "°C");


Console.WriteLine("");
Console.WriteLine("ejercicio 5");
int[] numeros2 = { 42, 7, 19, 3, 85, 1, 56, 23, 14, 99, 38 };

Console.WriteLine("la lista desordenada");
for (int i = 0; i < numeros2.Length; i++)
{
    Console.Write(numeros2[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < numeros2.Length; i++)
{
    for (int j = 0; j < numeros2.Length - 1; j++)
    {
        if (numeros2[j] > numeros2[j + 1])
        {
            int temporal = numeros2[j];
            numeros2[j] = numeros2[j + 1];
            numeros2[j + 1] = temporal;
        }
    }
}

Console.WriteLine("la lista ordenada:");
for (int i = 0; i < numeros2.Length; i++)
{
    Console.Write(numeros2[i] + " ");
}

Console.WriteLine("");
Console.WriteLine("ejercicio 6");
int[] numeros3 = { 3, 8, 15, 22, 7, 14, 9, 6, 11, 20, 1, 18, 5, 12, 17 };

int pares = 0;
int impares = 0;

for (int i = 0; i < numeros3.Length; i++)
{
    if (numeros3[i] % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}

Console.WriteLine("Pares: " + pares);
Console.WriteLine("Impares: " + impares);
