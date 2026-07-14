//ejercicio 1
using System.Diagnostics.Contracts;

int horas = 0;
try
{
    Console.WriteLine("ingrese la cantidad de horas que trabajo en la semana");
    horas = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("ingrese en numeros");
    return;
}
Console.WriteLine(salario_semanal(horas));
static int salario_semanal(int horas)
{
    int salario;
    if (horas <= 40)
    {
        salario = horas * 16;
    }
    else
    {
        salario = (40 * 16) + ((horas - 40) *  20);
    }
    Console.WriteLine("su salario es: ");
    return salario;
}

//ejercicio 2
Console.WriteLine(suma_numeros());

static int suma_numeros()
{
    int numero = 0;
    int acum = 0;
    do
    {
        try
        {
            Console.WriteLine("ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("ingrese en numeros");
        }
        acum = acum + numero;
    }
    while (numero != 0) ;

    Console.WriteLine("la suma de todos los numero antes del 0 es: ");
    return acum;
}

//ejercicio 3
Console.WriteLine(contar_vocales());

static int contar_vocales()
{
    int cont = 0;
    string palabra = "";
    string vocales = "aeiouAEIOU";

    try
    {
        Console.WriteLine("ingrese una palabra");
        palabra = Console.ReadLine();
    }
    catch (FormatException)
    {
        Console.WriteLine("ingrese en letras la palabra");
    }
    for (int i = 0; i < palabra.Length; i++)
    {
        if (palabra == vocales)
        {
            cont++;
        }
    }
    Console.WriteLine("la cantidad de vocales son: ");
    return cont;
}


//ejercicio 4
Console.WriteLine(palindromo());

static string palindromo()
{
    bool verificado = false;
    string palabra = "";
    string alrevez = "";
   
    while (verificado == false)
    {
        try
        {
            Console.WriteLine("ingrese una palabra");
            palabra = Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("ingrese en letras la palabra");
        }
        alrevez = "";
        foreach (char l in palabra)
        {
            alrevez = alrevez + l;
        }

        if (alrevez == palabra)
        {
            Console.WriteLine("la palabra es un palindromo");
            verificado = true;
        }
    }
    return palabra;
}