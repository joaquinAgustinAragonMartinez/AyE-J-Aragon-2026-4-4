//ejercicio 1
string Recursiva1(int a)
{
    if (a == 0)
    {
        return "";
    }
    Recursiva1(a + 1);
    Console.WriteLine(a);
    Console.WriteLine("ingrese una contraseña");
    string contraseña = Console.ReadLine();


    if (contraseña == "hola123")
    {
        return "entrando...";
    }
    else
    {
        return "la contraseña ingresada es incorrecta";
    }
}
//ejercicio 2
Console.WriteLine("empezando cuenta regresiva desde 5 hasta 1");
string Recursiva2(int b)
{
    if (b == 0)
    {
        return "¡Listo para despegar!" + "¡Despegue!";
    }
    else
    {
        Console.WriteLine(b);
        return Recursiva2(b - 1);
    }
}
Console.WriteLine(Recursiva2(5));
//ejercicio 3
Console.WriteLine("ingresa el numero secreto");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Recursiva3(n));
string Recursiva3(int n)
{
    if (n == 41)
    {
        return "felicidades adivinaste el numero";
    }
    else
    {
        Console.WriteLine("numero incorrecto intente de nuevo");
        n = Convert.ToInt32(Console.ReadLine());
        return Recursiva3(n);
    }
}
//ejercicio 4
int acum = 0;
Console.WriteLine("ingrese numeros y escriba 0 para finalizar");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Recursiva4(num));
string Recursiva4(int num)
{
    if (num == 0)
    {
        return "la suma total de los numeros es. "+ acum;
    }
    else
    {
        acum += num;
        Console.WriteLine("ingrese otro numero");
        num = Convert.ToInt32(Console.ReadLine());
        return Recursiva4(num);
    }
}

