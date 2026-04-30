using System;
Console.WriteLine("ingrese 0 o 1");
int num = Convert.ToInt32(Console.ReadLine());

while (num != 0 && num != 1)
{
    Console.WriteLine("error, ingrese 0 o 1");
    num = Convert.ToInt32(Console.ReadLine());
    if (num == 0 || num == 1)
    {
        Console.WriteLine("ha ingresado el numero correcto");
        break;
    }
}

Console.WriteLine("ingrese un numero de 2 cifras");
int num2 = Convert.ToInt32(Console.ReadLine());
while ((num2 < 10 && num2 > -10) || (num2 > 99 || num2 < -99))
{
    Console.WriteLine("error, ingrese nuevamente numero de 2 cifras");
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 >= 10 && num2 <= 99)
    {
        break;
    }
}
