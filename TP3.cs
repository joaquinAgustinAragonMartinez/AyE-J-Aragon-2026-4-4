//Ejercicio 1: Numero positivo?
using System.ComponentModel;

Console.WriteLine("ingrese un numero entero");
string ejercicio1(int n)
{
    string resultado;
    if (n > 0)
    {
        resultado = ("el numero es positivo");
        return resultado;
    }
    else if (n < 0)
    {
        resultado = ("el numero es negativo");
        return resultado;
    }
    else
    {
        resultado = ("el numero es 0");
        return resultado;
    }

}

int n = Convert.ToInt32(Console.ReadLine());
string resultado = ejercicio1(n);
Console.WriteLine(resultado);

//Ejercicio 2: Mayor de edad?
Console.WriteLine("cual es su edad");
string ejercicio2(int edad)
{
    string resultado2;
    if (edad >= 18)
    {
        resultado2 = ("¡Bienvenido a la fiesta!");
        return resultado2;
    }
    else if (edad < 18)
    {
        resultado2 = ("Lo siento, eres muy joven");
        return resultado2;
    }
    else
    {
        resultado2 = ("valor incorrecto");
        return resultado2;
    }
}

int edad = Convert.ToInt32(Console.ReadLine());
string resultado2 = ejercicio2(edad);
Console.WriteLine(resultado2);

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
string ejercicio4(int numero)
{
    string resultado4;

    if (numero % 2 == 0)
    {
        resultado4 = ("el numero es par");
        return resultado4;
    }
    else
    {
        resultado4 = ("el numero es impar");
        return resultado4;
    }
}

int numero  = Convert.ToInt32(Console.ReadLine());
string resultado4 = ejercicio4(numero);
Console.WriteLine(resultado4);

//ejercicio 5: Entrada gratis?

Console.WriteLine("ingrese su edad");
Console.WriteLine("ingrese si ha comprado palomitas");
string ejercicio5(int años, string compro)
{
    string resultado5;

    if (años > 65 && compro == "si" )
    {
        resultado5 = ("¡Felicidades! Tienes entrada gratuita al cine.");
        return resultado5;
    }
    else
    {
        resultado5 = ("Compra la entrada o raja de acá");
        return resultado5;
    }
}

int años = Convert.ToInt32(Console.ReadLine());
string compro = Convert.ToString(Console.ReadLine());
string resultado5 = ejercicio5(años, compro);
Console.WriteLine(resultado5);