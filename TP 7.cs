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
int acum = numero2;

if (numero2 <= 1)
{
    Console.WriteLine("el numero ingresado es invalido");
}
else { 
    for (int x = numero2 - 1; x >= 1; x--)
    {
        acum = acum * numero2;
    }
    Console.WriteLine(acum);
}