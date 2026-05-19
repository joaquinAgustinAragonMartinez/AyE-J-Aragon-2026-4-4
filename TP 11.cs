//ejercicio 1
string Recursiva1(int a)
{
    if (a == 0)
    {
        return 
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