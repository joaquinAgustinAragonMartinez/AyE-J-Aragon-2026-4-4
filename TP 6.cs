// ejercicio 1: Numero positivo?
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
//Ejercicio 2: Mayor de edad?
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
//Ejercicio 3: Contraseña secreta
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
//ejercicio 4:Par o Impar?
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
//ejercicio 5: Entrada gratis?
string ejercicio5(int años, string compro)
{
    string resultado5;

    if (años > 65 && compro == "si")
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

bool seguimos = true;

while (seguimos == true)
{
    Console.WriteLine("");
    Console.WriteLine("ingrese un numero");
    Console.WriteLine("0 = salir, 1 = Ejercicio 1: Numero positivo?, 2 = Ejercicio 2: Mayor de edad?, 3 = Ejercicio 3: Contraseña secreta, 4 = Ejercicio 4:Par o Impar?, 5 = Ejercicio 5: Entrada gratis?");

    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (x)
    {
        case 0:
            seguimos = false;
            break;
        case 1:
            Console.WriteLine("ingrese un numero entero");
            Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));
            break;
        case 2:
            Console.WriteLine("ingrese su edad");
            Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));
            break;
        case 3:
            Console.WriteLine("proporcione una contraseña");
            Console.WriteLine(ejercicio3(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine("ingrese un numero entero");
            Console.WriteLine(ejercicio4(Convert.ToInt32(Console.ReadLine())));
            break;
        case 5:
            Console.WriteLine("ingrese su edad");
            int ej5_edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese si ha comprado palomitas");
            string ej5_compro = Console.ReadLine();
            Console.WriteLine(ejercicio5(ej5_edad, ej5_compro));
            break;
        default:
            Console.WriteLine("no seleccionaste ninguno de los numeros");
            break;

    }
}