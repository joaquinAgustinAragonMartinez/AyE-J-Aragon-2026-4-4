try
{
    //Ejercicio 1: Numero positivo?
    Console.WriteLine("ingrese un numero entero");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        Console.WriteLine("el numero es positivo");
    }
    else if (n < 0)
    {
        Console.WriteLine("el numero es negativo");
    }
    else
    {
        Console.WriteLine("el numero es 0");
    }
}
catch (FormatException)
{
    Console.WriteLine("no escriba palabras");
}
catch (OverflowException)
{
    Console.WriteLine("ingresa un numero correcto");
}

//Ejercicio 2: Mayor de edad?
Console.WriteLine("cual es su edad");
int edad = Convert.ToInt32(Console.ReadLine());
try
{
    if (edad >= 18)
    {
        Console.WriteLine("¡Bienvenido a la fiesta!");
    }
    else if (edad < 18)
    {
        Console.WriteLine("Lo siento, eres muy joven");
    }
    else
    {
        Console.WriteLine("valor incorrecto");
    }
}
catch (FormatException)
{
    Console.WriteLine("no escriba palabras");
}
catch (OverflowException)
{
    Console.WriteLine("ingresa una edad real");
}

//Ejercicio 3: Contraseña secreta
Console.WriteLine("ingrese una contraseña");
string ejercicio3(string contraseña)
{
    string resultado3;

    if (contraseña == "python123")
    {
        resultado3 = ("¡Contraseña correcta!");
        return resultado3;
    }
    else
    {
        resultado3 = ("¡Contraseña incorrecta, Autodestrucción en 5 minutos!");
        return resultado3;
    }
}

string contraseña = Convert.ToString(Console.ReadLine());
string resultado3 = ejercicio3(contraseña);
Console.WriteLine(resultado3);

//ejercicio 4:Par o Impar?
Console.WriteLine("ingrese un numero entero");
int numero = Convert.ToInt32(Console.ReadLine());
try
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("el numero es par");

    }
    else
    {
        Console.WriteLine("el numero es impar");

    }
}
catch (FormatException)
{
    Console.WriteLine("no escriba palabras");
}

//ejercicio 5: Entrada gratis?
Console.WriteLine("ingrese su edad");
int años = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese si ha comprado palomitas");
string compro = Console.ReadLine();
try
{

    if (años > 65 && compro == "si")
    {
        Console.WriteLine("¡Felicidades! Tienes entrada gratuita al cine.");
    }
    else
    {
        Console.WriteLine("Compra la entrada o raja de acá");
    }
}
catch (FormatException)
{
    Console.WriteLine("no escriba palabras");
}
catch (OverflowException)
{
    Console.WriteLine("ingresa una edad real");
}