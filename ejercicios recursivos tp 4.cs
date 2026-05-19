// ejercicio 1
using System.Diagnostics.CodeAnalysis;

bool Recursiva(int n)
{
    if (n == 0)
    {
        return false;
    }
    else
    {
        Recursiva(n - 1);
        Console.WriteLine(n);
        return true;
    }
}
Console.WriteLine("numeros del 1 al 10");
Recursiva(10);

//ejercicio 2
bool Recursiva2(int a)
{
    if (a == 0)
    {
        return false;
    }
    else
    {
        Recursiva2(a - 1);
        Console.WriteLine("hola mundo!");
        return true;
    }
}
Console.WriteLine("hola mundo 5 veces");
Recursiva2(5);

//ejercicio 3
bool Recursiva3(int b)
{
    if (b == 0)
    {
        return false;
    }
    else
    {
        Recursiva3(b - 2);
        Console.WriteLine(b);
        return true;
    }
}
Console.WriteLine("todos los numeros pares del 2 al 20");
Recursiva3(20);

//ejercicio 4
bool Recursiva4(int c)
{
    if (c == 0)
    {
        return false;
    }
    else
    {
        Recursiva4(c - 7);
        Console.WriteLine(c);
        return true;
    }
}
Console.WriteLine("tabla de multiplicar del 7");
Recursiva4(70);

//ejercicio 5
int Recursiva5(int d)
{
    if (d == 0)
    {
        return 0;
    }
    else
    {
        return d + Recursiva5 (d - 1);
        return d;
    }
}
Console.WriteLine("suma de todos los numeros del 1 al 5");
Console.WriteLine(Recursiva5(5));
