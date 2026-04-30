static void MultiplosDeTres()
{
    //a)

    Console.WriteLine("todos los numeros del 1 al 100 de 3 en 3");
    for (int x = 3; x <= 100; x += 3)
    {
        Console.WriteLine(x);
    }
}
static void VerificarEdad()
//b)
{
    Console.WriteLine("ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad > 18)
    {
        Console.WriteLine("sos mayor de edad");
    }
    else if (edad < 18)
    {
        Console.WriteLine("sos menor de edad");
    }
    else
    {
        Console.WriteLine("tenes 18 años");
    }
}
static void ContarLetrasPalabra()
{
    //c)
    Console.WriteLine("ingrese un frase");
    string frase = Console.ReadLine();
    string letras = ("abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
    int contador = 0;

    foreach (char f in frase)
    {
        foreach (char v in letras)
        {
            if (f == v)
            {
                contador++;
                break;
            }
        }
    }
    Console.WriteLine("su palabra tiene " + contador + " letras");
}
static void AdivinarContraseña()
{
    //d)
    int contador2 = 0;

    while (contador2 <= 5)
    {
        Console.WriteLine("ingrese una contraseña secreta");
        Console.WriteLine("pista: Empieza con j y termina con uanito2013");
        string contraseñaingresada = Console.ReadLine();

        if (contraseñaingresada == "juanito2013")
        {
            Console.WriteLine("contraseña correcta, ingresando...");
            break;
        }
        else
        {
            Console.WriteLine("contraseña incorrecta");
            contador2++;
        }
        if (contador2 == 5)
        {
            Console.WriteLine("intentos agotados, intente mas tarde");
            break;
        }
    }
}
static void MayorNumero()
{
    //e)
    int numeromax = 0;
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("ingrese un numero");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (i == 1)
        {
            numeromax = numero;
        }
        else
        {
            if (numero > numeromax)
            {
                numeromax = numero;
            }
        }
    }
    Console.WriteLine("el numero mas alto es el " + numeromax);
}
static void FormatearNombre()
{
    //f)
    Console.WriteLine("ingrese su nombre");
    string nombre = Console.ReadLine();
    Console.WriteLine("ingrese su apellido");
    string apellido = Console.ReadLine();


    string nombremodificado = char.ToUpper(nombre[0]) + nombre.Substring(1);
    string apellidomodificado = char.ToUpper(apellido[0]) + apellido.Substring(1);

    Console.WriteLine("Hola " + nombremodificado + " " + apellidomodificado);
}
static void TablaDelSiete()
{
    //g)
    Console.WriteLine("tabla de multiplicar del 7");
    for (int x = 1; x <= 10; x++)
    {
        Console.WriteLine(x + " x " + "7" + " = " + (x * 7));
    }
}
static void CuentaRegresiva()
{
    //h)
    Console.WriteLine("cuenta regresiva del 10 al 1");
    for (int x = 10; x >= 1; x--)
    {
        Console.WriteLine(x);
    }
    Console.WriteLine("oa");
}
static void ParOImpar()
{
    //i)
    Console.WriteLine("ingrese un numero entero");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero2 % 2 == 0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
}
static void ContarVocales()
{
    //j)
    Console.WriteLine("ingrese un frase");
    string oracion = Console.ReadLine();
    string vocales = ("aeiouAEIOU");
    int contador3 = 0;

    foreach (char f in oracion)
    {
        foreach (char v in vocales)
        {
            if (f == v)
            {
                contador3++;
                break;
            }
        }
    }
    Console.WriteLine("la frase tiene " + contador3 + " vocales");
}
static void TablaDeMultiplicar()
{
    //k)
    Console.WriteLine("ingrese un numero");
    int numero3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("tabla de multiplicar del " + numero3);

    for (int x = 1; x <= 12; x++)
    {
        Console.WriteLine(numero3 + " x " + x + " = " + (numero3 * x));
    }
}
static void AcumuladorHastaCien()
{
    //l)
    Console.WriteLine("ingrese un numero");
    int acum = Convert.ToInt32(Console.ReadLine());
    while (acum < 100)
    {
        Console.WriteLine("ingrese un numero");
        int numero4 = Convert.ToInt32(Console.ReadLine());

        acum = acum + numero4;
    }
    Console.WriteLine("se supero el total de 100");
}
static void MostrarLetrasLineaPorLinea()
{
    //m)
    Console.WriteLine("ingrese una palabra");
    string palabra = Console.ReadLine();
    foreach (char f in palabra)
    {
        Console.WriteLine(f);
    }
}
static void PermisosPorEdad()
{
    //n)
    Console.WriteLine("Ingrese su edad: ");
    int edad2 = Convert.ToInt32(Console.ReadLine());

    if (edad2 >= 18)
    {
        Console.WriteLine("Puede votar y manejar");
    }
    else if (edad2 >= 16)
    {
        Console.WriteLine("Puede manejar pero no votar");
    }
    else
    {
        Console.WriteLine("No puede votar ni manejar");
    }
}
static void CuentaDescendenteCinco()
{
    //o)
    Console.WriteLine("numeros del 50 al 0 de forma descendente de 5 en 5");
    for (int i = 50; i >= 0; i -= 5)
    {
        Console.WriteLine(i);
    }
}
static void ConfirmarContraseña()
{
    //p)
    string contraseña;
    string nuevacontraseña;

    do
    {
        Console.WriteLine("escriba una contraseña");
        contraseña = Console.ReadLine();

        Console.WriteLine("escriba nuevamente la misma contraseña");
        nuevacontraseña = Console.ReadLine();

        if (contraseña == nuevacontraseña)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("ingrese de nuevo la contraseña");
        }
    } while (contraseña != nuevacontraseña);
}
static void IngresoNombres()
{
    //q)
    string nombre2 = "";
    while (nombre2.Length <= 10)
    {
        Console.WriteLine("ingrese un nombre");
        nombre2 = Console.ReadLine();
    }
    Console.WriteLine("el nombre ingresado tiene 10 o mas caracteres");
}
static void ContarLetraA()
{
    //r)
    int contador4 = 0;
    char letra = 'a';

    Console.WriteLine("escriba una oracion");
    string oracion2 = Console.ReadLine();

    foreach (char g in oracion2)
    {
        if (g == letra)
        {
            contador4++;
        }
    }
    Console.WriteLine("la palabra tiene " + contador4 + " letras a");
}

Console.WriteLine("Primer Bloque");
bool seguimos = true;

while (seguimos == true)
{
    Console.WriteLine("");
    Console.WriteLine("===== MENU DE EJERCICIOS =====");
    Console.WriteLine("0. Salir");
    Console.WriteLine("1. Mostrar múltiplos de 3 (1 al 100)");
    Console.WriteLine("2. Verificar edad (menor, mayor o 18)");
    Console.WriteLine("3. Contar letras de una palabra");
    Console.WriteLine("4. Adivinar contraseña (5 intentos)");
    Console.WriteLine("5. Encontrar el número mayor de 10 números");
    Console.WriteLine("6. Formatear nombre (mayúsculas iniciales)");
    Console.WriteLine("7. Tabla del 7");
    Console.WriteLine("8. Cuenta regresiva (10 a 1)");
    Console.WriteLine("9. Par o impar");
    Console.WriteLine("10. Contar vocales en una frase");
    Console.WriteLine("11. Tabla de multiplicar (1 al 12)");
    Console.WriteLine("12. Acumulador hasta superar 100");
    Console.WriteLine("13. Mostrar letras una por línea");
    Console.WriteLine("14. Permisos según edad (votar / manejar)");
    Console.WriteLine("15. Cuenta descendente de 50 a 0 de 5 en 5");
    Console.WriteLine("16. Confirmar contraseña (dos veces)");
    Console.WriteLine("17. Ingreso de nombres (hasta 10 caracteres)");
    Console.WriteLine("18. Contar letras 'a' en una oración");

    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (x)
    {
        case 0:
            seguimos = false;
            break;
        case 1:
            MultiplosDeTres();
            break;
        case 2:
            VerificarEdad();
            break;
        case 3:
            ContarLetrasPalabra();
            break;
        case 4:
            AdivinarContraseña();
            break;
        case 5:
            MayorNumero();
            break;
        case 6:
            FormatearNombre();
            break;
        case 7:
            TablaDelSiete();
            break;
        case 8:
            CuentaRegresiva();
            break;
        case 9:
            ParOImpar();
            break;
        case 10:
            ContarVocales();
            break;
        case 11:
            TablaDeMultiplicar();
            break;
        case 12:
            AcumuladorHastaCien();
            break;
        case 13:
            MostrarLetrasLineaPorLinea();
            break;
        case 14:
            PermisosPorEdad();
            break;
        case 15:
            CuentaDescendenteCinco();
            break;
        case 16:
            ConfirmarContraseña();
            break;
        case 17:
            IngresoNombres();
            break;
        case 18:
            ContarLetraA();
            break;
    }
}