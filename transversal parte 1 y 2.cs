int opcionPrincipal;

do
{
    Console.WriteLine();
    Console.WriteLine("===== MENU PRINCIPAL =====");
    Console.WriteLine("1. Primer Bloque");
    Console.WriteLine("2. Segundo Bloque");
    Console.WriteLine("0. Salir");

    opcionPrincipal = Convert.ToInt32(Console.ReadLine());

    switch (opcionPrincipal)
    {
        case 1:

            bool seguimos = true;

            while (seguimos)
            {
                Console.WriteLine();
                Console.WriteLine("===== PRIMER BLOQUE =====");
                Console.WriteLine("0. Volver al menu principal");
                Console.WriteLine("1. Mostrar múltiplos de 3");
                Console.WriteLine("2. Verificar edad");
                Console.WriteLine("3. Contar letras");
                Console.WriteLine("4. Adivinar contraseña");
                Console.WriteLine("5. Mayor número");
                Console.WriteLine("6. Formatear nombre");
                Console.WriteLine("7. Tabla del 7");
                Console.WriteLine("8. Cuenta regresiva");
                Console.WriteLine("9. Par o impar");
                Console.WriteLine("10. Contar vocales");
                Console.WriteLine("11. Tabla de multiplicar");
                Console.WriteLine("12. Acumulador hasta 100");
                Console.WriteLine("13. Mostrar letras");
                Console.WriteLine("14. Permisos por edad");
                Console.WriteLine("15. Cuenta descendente");
                Console.WriteLine("16. Confirmar contraseña");
                Console.WriteLine("17. Ingreso de nombres");
                Console.WriteLine("18. Contar letra A");

                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 0: seguimos = false; break;
                    case 1: MultiplosDeTres(); break;
                    case 2: VerificarEdad(); break;
                    case 3: ContarLetrasPalabra(); break;
                    case 4: AdivinarContraseña(); break;
                    case 5: MayorNumero(); break;
                    case 6: FormatearNombre(); break;
                    case 7: TablaDelSiete(); break;
                    case 8: CuentaRegresiva(); break;
                    case 9: ParOImpar(); break;
                    case 10: ContarVocales(); break;
                    case 11: TablaDeMultiplicar(); break;
                    case 12: AcumuladorHastaCien(); break;
                    case 13: MostrarLetrasLineaPorLinea(); break;
                    case 14: PermisosPorEdad(); break;
                    case 15: CuentaDescendenteCinco(); break;
                    case 16: ConfirmarContraseña(); break;
                    case 17: IngresoNombres(); break;
                    case 18: ContarLetraA(); break;
                    default: Console.WriteLine("Opcion incorrecta"); break;
                }
            }
            break;

        case 2:

            int opcion;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== SEGUNDO BLOQUE =====");
                Console.WriteLine("1 Adivinar numero");
                Console.WriteLine("2 Divisores");
                Console.WriteLine("3 Fibonacci");
                Console.WriteLine("4 Calculadora");
                Console.WriteLine("5 Factorial");
                Console.WriteLine("6 Turnos");
                Console.WriteLine("7 Pares 1 a 100");
                Console.WriteLine("8 Celsius a Fahrenheit");
                Console.WriteLine("9 Primo");
                Console.WriteLine("10 Lista nombres");
                Console.WriteLine("11 Nombres sin repetir");
                Console.WriteLine("12 Numeros especiales");
                Console.WriteLine("13 Suma productos");
                Console.WriteLine("14 Formulario");
                Console.WriteLine("15 Digitos");
                Console.WriteLine("16 Piedra papel tijera");
                Console.WriteLine("17 Mayores a 50");
                Console.WriteLine("18 Promedio alumnos");
                Console.WriteLine("19 Abecedario inverso");
                Console.WriteLine("0. Volver al menu principal");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Adivinar(); break;
                    case 2: Divisores(); break;
                    case 3: Fibonacci(); break;
                    case 4: Calculadora(); break;
                    case 5: Factorial(); break;
                    case 6: Turnos(); break;
                    case 7: Pares(); break;
                    case 8: Temperatura(); break;
                    case 9: Primo(); break;
                    case 10: Lista(); break;
                    case 11: SinRepetidos(); break;
                    case 12: Especiales(); break;
                    case 13: Productos(); break;
                    case 14: Formulario(); break;
                    case 15: Digitos(); break;
                    case 16: PiedraPapelTijera(); break;
                    case 17: Mayores50(); break;
                    case 18: Promedio(); break;
                    case 19: Abecedario(); break;
                    case 0: break;
                    default: Console.WriteLine("Opcion incorrecta"); break;
                }

            } while (opcion != 0);

            break;

        case 0:
            Console.WriteLine("Fin del programa");
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }

} while (opcionPrincipal != 0);

//BLOQUE 1
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

    if (edad >= 18)
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

//BLOQUE 2
static void Adivinar()
{
    Random random = new Random();
    int numAdivinar = random.Next(1, 11);
    int num;
    Console.WriteLine("¡Bienvenido al juego de advinar un numero");
    do
    {
        Console.WriteLine("ingrese el numero a adivinar del 1 al 10");
        num = Convert.ToInt32(Console.ReadLine());
        if (numAdivinar != num)
        {
            Console.WriteLine("numero incorrecto!");
            if (numAdivinar < num)
            {
                Console.WriteLine("pista: El numero es menor");
            }

            else
            {
                Console.WriteLine("pista: El numero es mayor");
            }
        }
    }
    while (numAdivinar != num);
    Console.WriteLine("¡Felicidades usted adivino el numero!");
}
static void Divisores()
{
    Console.WriteLine("ingrese un numero");
    int numm = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Listado de todos los divisores:");

    for (int i = 1; i <= numm; i++)
    {
        if (numm % i == 0)
        {
            Console.WriteLine(i);
        }
    }
}
static void Fibonacci()
{
    int a = 0;
    int b = 1;
    int cont = 0;
    Console.WriteLine("Listado de los primeros 20 numeros de la secuencia Fibonacci");

    while (cont < 20)
    {
        Console.WriteLine(a);

        int n_siguiente = a + b;
        a = b;
        b = n_siguiente;

        cont++;
    }
}
static void Calculadora()
{
    Console.WriteLine("Elija una opcion:");
    Console.WriteLine("1-sumar");
    Console.WriteLine("2-restar");
    Console.WriteLine("3-multiplicar");
    Console.WriteLine("4-dividir");

    int opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el primer numero:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero:");
    int num2 = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            Console.WriteLine("resultado: " + (num1 + num2));
            break;

        case 2:
            Console.WriteLine("resultado: " + (num1 - num2));
            break;

        case 3:
            Console.WriteLine("resultado: " + (num1 * num2));
            break;

        case 4:
            if (num2 != 0)
                Console.WriteLine("resultado: " + (num1 / num2));
            else
                Console.WriteLine("no se puede dividir por 0");
            break;

        default:
            Console.WriteLine("ingrese una opcion correcta");
            break;
    }
}
static void Factorial()
{
    int resultado = 1;

    Console.WriteLine("Ingrese un numero");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        resultado = resultado * i;
    }

    Console.WriteLine("Factorial: " + resultado);
}
static void Turnos()
{
    int turno = 1;

    Console.WriteLine("ingrese nombres y escriba 'terminar' para terminar");
    string nombre = Console.ReadLine();

    while (nombre != "terminar")
    {
        Console.WriteLine("Turno " + turno + ": " + nombre);

        turno++;

        nombre = Console.ReadLine();
    }
}
static void Pares()
{
    int contator = 0;
    for (int i = 1; i <= 100; i++)
    {
        if (i % 2 == 0)
        {

            contator++;
        }
    }

    Console.WriteLine("entre el 1 y el 100 hay " + contator + " numero pares");
}
static void Temperatura()
{
    int opcion2;
    do
    {
        Console.WriteLine("elija una opcion");
        Console.WriteLine("1 - convertir grados celsius a fahrenheit");
        Console.WriteLine("0 - salir");
        opcion2 = Convert.ToInt32(Console.ReadLine());

        switch (opcion2)
        {
            case 0:
                Console.WriteLine("saliendo...");
                break;

            case 1:
                Console.Write("Ingrese la temperatura en Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double fahrenheit = (celsius * 9.0 / 5.0) + 32;

                Console.WriteLine("La temperatura en Fahrenheit: " + fahrenheit);
                break;

            default:
                Console.WriteLine("Ingrese una opción correcta.");
                break;
        }

    } while (opcion2 != 0);
}
static void Primo()
{
    int cont2 = 0;

    Console.WriteLine("Ingrese un número:");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= numero2; i++)
    {
        if (numero2 % i == 0)
        {
            cont2++;
        }
    }

    if (cont2 == 2)
    {
        Console.WriteLine("Es primo");
    }
    else
    {
        Console.WriteLine("No es primo");
    }
}
static void Lista()
{
    string[] nombres2 = new string[1000];
    string nombre2;
    int contador2 = 0;

    do
    {
        Console.WriteLine("Ingrese nombres y escriba 'fin' para terminar");
        nombre2 = Console.ReadLine();

        if (nombre2 != "fin")
        {
            nombres2[contador2] = nombre2;
            contador2++;
        }

    } while (nombre2 != "fin");

    for (int i = 0; i < contador2; i++)
    {
        Console.WriteLine("Hola " + nombres2[i] + "!");
    }
}
static void SinRepetidos()
{
    string nombre3;
    int cont3 = 0;
    string[] nombres3 = new string[1000];
    bool repetido = false;
    do
    {
        Console.WriteLine("ingrese nombres");
        nombre3 = Console.ReadLine();

        for (int i = 0; i < cont3; i++)
        {
            if (nombres3[i] == nombre3)
            {
                repetido = true;
                break;
            }
        }
        if (!repetido)
        {
            nombres3[cont3] = nombre3;
            cont3++;
        }
    }
    while (!repetido);

    Console.WriteLine("usted ingreso " + cont3 + " nombres antes de que alguno se repita");
}
static void Especiales()
{
    for (int i = 100; i < 200; i++)
    {
        if (i % 7 == 0 && i % 10 == 3)
        {
            Console.WriteLine(i);
        }
    }
}
static void Productos()
{
    int precio = 0;
    int acum = 0;
    int contador4 = 0;

    while (acum < 1000)
    {
        Console.WriteLine("ingrese el precio del producto");
        precio = Convert.ToInt32(Console.ReadLine());
        acum += precio;
        contador4++;
    }
    Console.WriteLine("se supero el monto de $1000 y se cargaron " + contador4 + " productos");
}
static void Formulario()
{
    Console.WriteLine("bienvenido al programa");
    Console.WriteLine("a continuacion complete el siguiente cuestionario");
    Console.WriteLine("ingrese su nombre");
    string nombre4 = Console.ReadLine();
    int edad3 = 0;
    try
    {
        Console.WriteLine("ingrese su edad");
        edad3 = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("ingrese un numero en la edad");
        return;
    }
    Console.WriteLine("ingrese su correo electronico");
    string correo = Console.ReadLine();

    if (!correo.Contains('@'))
    {
        Console.WriteLine("el correo no tiene @");
    }

    Console.WriteLine("datos cargados");
    Console.WriteLine(nombre4);
    Console.WriteLine(edad3);
    Console.WriteLine(correo);
}
static void Digitos()
{
    Console.WriteLine("ingrese un numero");
    string numeros = Console.ReadLine();
    foreach (char f in numeros)
    {
        Console.WriteLine(f);
    }
}
static void PiedraPapelTijera()
{
    Random random2 = new Random();

    int puntosUsuario = 0;
    int puntosComputadora = 0;

    for (int ronda = 1; ronda <= 3; ronda++)
    {
        Console.WriteLine("ronda " + ronda);
        Console.WriteLine("1 - piedra");
        Console.WriteLine("2 - papel");
        Console.WriteLine("3 - tijera");

        int usuario = Convert.ToInt32(Console.ReadLine());
        int computadora = random2.Next(1, 4);

        Console.WriteLine("La computadora eligio: " + computadora);

        if ((usuario == 1 && computadora == 3) ||
            (usuario == 2 && computadora == 1) ||
            (usuario == 3 && computadora == 2))
        {
            Console.WriteLine("ganaste la ronda");
            puntosUsuario++;
        }
        else if (usuario == computadora)
        {
            Console.WriteLine("empate");
        }
        else
        {
            Console.WriteLine("gano la computadora");
            puntosComputadora++;
        }
    }

    Console.WriteLine("puntos del usuario: " + puntosUsuario);
    Console.WriteLine("puntos de la computadora: " + puntosComputadora);

    if (puntosUsuario > puntosComputadora)
    {
        Console.WriteLine("Ganaste el juego");
    }
    else if (puntosComputadora > puntosUsuario)
    {
        Console.WriteLine("Gano la computadora");
    }
    else
    {
        Console.WriteLine("El juego termino en empate");
    }
}
static void Mayores50()
{
    Random random3 = new Random();
    int contador5 = 0;
    int[] numeros2 = new int[11];
    for (int i = 0; i < 10; i++)
    {
        int numero4 = random3.Next(1, 101);
        numeros2[i] = numero4;
        if (numero4 > 50)
        {
            contador5++;
        }
    }

    Console.WriteLine("de los 10 numeros generados del 1 al 100 son mayores a 50 " + contador5 + " numeros");
}
static void Promedio()
{
    string[] nombres = new string[5];
    int[] notas = new int[5];

    int acum1 = 0;
    string malumno = "";
    int mnota = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("ingrese su nombre");
        nombres[i] = Console.ReadLine();

        Console.WriteLine("ingrese su nota");
        notas[i] = Convert.ToInt32(Console.ReadLine());

        acum1 += notas[i];

        if (notas[i] > mnota)
        {
            malumno = nombres[i];
            mnota = notas[i];
        }
    }
    int promedio = acum1 / 5;
    Console.WriteLine("el promedio general es de " + promedio + " y el alumno con la mejor nota es " + malumno + " con la nota " + mnota);
}
static void Abecedario()
{
    string abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    for (int i = abecedario.Length - 1; i >= 0; i--)
    {
        Console.Write(abecedario[i]);
    }
}