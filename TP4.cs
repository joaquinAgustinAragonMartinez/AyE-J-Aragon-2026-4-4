//Ejercicio 1:Contando hasta 10

using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("numeros del 1 al 10");
for (int x = 1; x <= 10; x++)
{
    Console.WriteLine(x);
}

//Ejercicio 2: Hola, 5 veces...
Console.WriteLine("");
Console.WriteLine("hola mundo 5 veces");

for (int x = 1; x <= 5; x++)
{
    Console.WriteLine("¡Hola, mundo!");
}

//Ejercicio 3: Los números pares
Console.WriteLine("");
Console.WriteLine("todos los numeros pares del 2 al 20");

for (int x = 2; x <= 20; x+=2)
{
        Console.WriteLine(x);
}

//Ejercicio 4: Tabla de multiplicar del 7
Console.WriteLine("");
Console.WriteLine("tabla de multiplicar del 7");

for (int x = 7; x <= 70; x += 7)
{
    Console.WriteLine(x);
}

//Ejercicio 5: Suma de los primeros 5 números
Console.WriteLine("");
Console.WriteLine("suma de todos los numeros del 1 al 5");
int acum = 0;

for (int x = 1; x <= 5; x++)
{
    acum = acum + x;

    Console.WriteLine(acum);
}