//Ejercicio 1: Numero Primo
Console.WriteLine("ingrese un numero entero");
int numero = Convert.ToInt32(Console.ReadLine());

bool NumPrimo = true;
{

    if (numero <= 1)
    {
        NumPrimo = false;
    }
    else
    {
        for (int x = 2; x < numero; x++)
        {
            if (numero % x == 0)
            {
                NumPrimo = false;
                break;
            }
        }
    }
}

if (NumPrimo)
{
    Console.WriteLine("el numero es primo");
}
else
{
    Console.WriteLine("el numero no es primo");
}

//Ejercicio 2: Factorial:
Console.WriteLine("ingrese un numero entero y positivo");
int numero2 = Convert.ToInt32(Console.ReadLine());
int acum = 1;

if (numero2 <= 0)
{
    Console.WriteLine("el numero ingresado es invalido");
}
else
{
    for (int x = numero2; x >= 1; x--)
    {
        acum = acum * x;
    }
    Console.WriteLine(acum);
}

//Ejercicio 3: Secuencia Fibonacci:
int a = 0;
int b = 1;

Console.WriteLine("ingrese un numero");
int n = Convert.ToInt32(Console.ReadLine());

while (a <= n)
{
    Console.WriteLine(a);

    int n_siguiente = a + b;
    a = b;
    b = n_siguiente;
}

//Ejercicio 4: Menú interactivo

bool seguimos = true;

while (seguimos == true)
{
    Console.WriteLine("");
    Console.WriteLine("ingrese un numero");
    Console.WriteLine("1 = Saludar, 2 = Despedirse, 3 = Terminar Programa");

    int x = Convert.ToInt32(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("hola");
            break;
        case 2:
            Console.WriteLine("chau");
            break;
        case 3:
            Console.WriteLine("cerrando el programa...");
            seguimos = false;
            break;
        default:
            Console.WriteLine("no seleccionaste ninguno de los numeros indicados");
            break;
    }
}