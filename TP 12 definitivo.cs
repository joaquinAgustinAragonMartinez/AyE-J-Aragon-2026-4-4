void ejercicio1()
{
    Console.WriteLine("----Ejercicio 1----");
    Console.WriteLine("");
    Console.WriteLine("Ingrese alguno de los siguientes codigos y verá cuál es su categoria:");
    Console.WriteLine("Codigos: I, C, J, A");

    string codigo = Console.ReadLine().ToUpper();

    switch (codigo)
    {
        case "I":
            Console.WriteLine("Categoría: Infantiles");
            Console.WriteLine("Cuota: $800");
            break;

        case "C":
            Console.WriteLine("Categoría: Cadete");
            Console.WriteLine("Cuota: $1000");
            break;

        case "J":
            Console.WriteLine("Categoría: Juvenil");
            Console.WriteLine("Cuota: $1200");
            break;

        case "A":
            Console.WriteLine("Categoría: Adulto");
            Console.WriteLine("Cuota: $900");
            break;

        default:
            Console.WriteLine("Codigo incorrecto");
            break;
    }
}
ejercicio1();
void ejercicio2()
{
    try
    {
        Console.WriteLine("----Ejercicio 2----");
        Console.WriteLine();

        float costo = 300;
        float resTipo = 0;
        float resDestino = 0;

        Console.WriteLine("Ingrese el tipo de encomienda (S, X, E):");
        char tipo = Convert.ToChar(Console.ReadLine().ToUpper());

        Console.WriteLine("Ingrese el destino (L, N):");
        char destino = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (tipo)
        {
            case 'S':
                resTipo = 0;
                break;

            case 'X':
                resTipo = 0.20f;
                break;

            case 'E':
                resTipo = 0.40f;
                break;

            default:
                Console.WriteLine("Tipo incorrecto");
                return;
        }

        switch (destino)
        {
            case 'L':
                resDestino = 0.05f;
                break;

            case 'N':
                resDestino = 0.20f;
                break;

            default:
                Console.WriteLine("Destino incorrecto");
                return;
        }

        costo = costo + (costo * resTipo) + (costo * resDestino);

        Console.WriteLine("El costo total es: $" + costo);
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio2();
void ejercicio3()
{
    try
    {
        Console.WriteLine("----Ejercicio 3----");
        Console.WriteLine();

        double sueldoBasico;
        double porcAnt = 0;
        double antiguedad;
        double presentismo;
        double remuneracion;
        double jubilacion;
        double obraSocial;
        double descuento;
        double sueldoNeto;

        Console.Write("Ingrese su sueldo básico: ");
        sueldoBasico = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el código de antigüedad:");
        Console.WriteLine("1 = Menos de un año");
        Console.WriteLine("2 = De 1 a 3 años");
        Console.WriteLine("3 = De 3 a 5 años");
        Console.WriteLine("4 = 5 años o más");

        int codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Tiene presentismo? (S/N): ");
        char pres = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (codigo)
        {
            case 1:
                porcAnt = 0;
                break;

            case 2:
                porcAnt = 0.10;
                break;

            case 3:
                porcAnt = 0.15;
                break;

            case 4:
                porcAnt = 0.20;
                break;

            default:
                Console.WriteLine("Código incorrecto");
                return;
        }

        antiguedad = sueldoBasico * porcAnt;

        if (pres == 'S')
        {
            presentismo = sueldoBasico * 0.10;
        }
        else
        {
            presentismo = 0;
        }

        remuneracion = sueldoBasico + antiguedad + presentismo;

        jubilacion = remuneracion * 0.13;
        obraSocial = remuneracion * 0.03;

        descuento = jubilacion + obraSocial;

        sueldoNeto = remuneracion - descuento;

        Console.WriteLine("Remuneración: $" + remuneracion);
        Console.WriteLine("Descuentos: $" + descuento);
        Console.WriteLine("Sueldo neto: $" + sueldoNeto);
    }
    catch (OverflowException)
    {
        Console.WriteLine("ingresa un cifra real");
    }
    catch (FormatException)
    {
        Console.WriteLine("No se permiten letras ni caracteres inválidos.");
    }
}
ejercicio3();
void ejercicio4()
{
    Console.WriteLine("----Ejercicio 4----");
    try
    {
        Console.Write("Ingrese el día: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el año: ");
        int año = Convert.ToInt32(Console.ReadLine());

        string mes2 = "";

        switch (mes)
        {
            case 1: mes2 = "enero"; break;
            case 2: mes2 = "febrero"; break;
            case 3: mes2 = "marzo"; break;
            case 4: mes2 = "abril"; break;
            case 5: mes2 = "mayo"; break;
            case 6: mes2 = "junio"; break;
            case 7: mes2 = "julio"; break;
            case 8: mes2 = "agosto"; break;
            case 9: mes2 = "septiembre"; break;
            case 10: mes2 = "octubre"; break;
            case 11: mes2 = "noviembre"; break;
            case 12: mes2 = "diciembre"; break;
            default:
                Console.WriteLine("Mes incorrecto");
                return;
        }

        Console.WriteLine(dia + " de " + mes2 + " de " + año);
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio4();
void ejercicio5()
{
    try
    {
        Console.WriteLine("----Ejercicio 5----");

        Console.WriteLine("1- Cuadrado");
        Console.WriteLine("2- Rectángulo");
        Console.WriteLine("3- Triángulo");
        Console.WriteLine("4- Círculo");
        Console.WriteLine("5- Rombo");

        Console.Write("Elija una figura: ");
        int figura = Convert.ToInt32(Console.ReadLine());

        Console.Write("1- Perímetro  2- Superficie: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double a, b, c;

        switch (figura)
        {
            case 1:
                Console.Write("Lado: ");
                a = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                    Console.WriteLine("Perímetro: " + (a * 4));
                else
                    Console.WriteLine("Superficie: " + (a * a));
                break;

            case 2:
                Console.Write("Base: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                    Console.WriteLine("Perímetro: " + ((a + b) * 2));
                else
                    Console.WriteLine("Superficie: " + (a * b));
                break;

            case 3:
                Console.Write("Base: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado: ");
                c = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                    Console.WriteLine("Perímetro: " + (c * 3));
                else
                    Console.WriteLine("Superficie: " + ((a * b) / 2));
                break;

            case 4:
                Console.Write("Radio: ");
                a = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                    Console.WriteLine("Perímetro: " + (2 * 3.14 * a));
                else
                    Console.WriteLine("Superficie: " + (3.14 * a * a));
                break;

            case 5:
                Console.Write("Diagonal mayor: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Diagonal menor: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado: ");
                c = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                    Console.WriteLine("Perímetro: " + (c * 4));
                else
                    Console.WriteLine("Superficie: " + ((a * b) / 2));
                break;

            default:
                Console.WriteLine("Figura incorrecta");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio5();
void ejercicio6()
{
    try
    {
        Console.WriteLine("----Ejercicio 6----");

        Console.Write("Ingrese el total de la compra: $");
        double compra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Color de la bolita:");
        Console.WriteLine("B = Blanca");
        Console.WriteLine("V = Verde");
        Console.WriteLine("A = Amarilla");
        Console.WriteLine("Z = Azul");
        Console.WriteLine("R = Roja");

        char color = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (color)
        {
            case 'B':
                break;

            case 'V':
                compra = compra - (compra * 0.10);
                break;

            case 'A':
                compra = compra - (compra * 0.25);
                break;

            case 'Z':
                compra = compra - (compra * 0.50);
                break;

            case 'R':
                compra = 0;
                break;

            default:
                Console.WriteLine("Color incorrecto");
                return;
        }

        Console.WriteLine("Total a pagar: $" + compra);
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio6();
void ejercicio7()
{
    try
    {
        Console.WriteLine("----Ejercicio 7----");

        Console.Write("¿Colón descubrió América? (Si/No): ");
        string r1 = Console.ReadLine().ToLower();

        if (r1 == "si")
        {
            Console.Write("¿La independencia de México fue en 1810? (Si/No): ");
            string r2 = Console.ReadLine().ToLower();

            if (r2 == "si")
            {
                Console.Write("¿The Doors fue un grupo de rock americano? (Si/No): ");
                string r3 = Console.ReadLine().ToLower();

                if (r3 == "si")
                {
                    Console.WriteLine("¡Ganaste!");
                }
                else
                {
                    Console.WriteLine("Perdiste.");
                }
            }
            else
            {
                Console.WriteLine("Perdiste.");
            }
        }
        else
        {
            Console.WriteLine("Perdiste.");
        }
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio7();
void ejercicio8()
{
    try
    {
        Console.WriteLine("----Ejercicio 8----");

        Console.Write("Ingrese el total de la compra: $");
        double compra = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el número sorteado: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        double descuento;

        if (numero < 74)
        {
            descuento = compra * 0.15;
        }
        else
        {
            descuento = compra * 0.20;
        }

        Console.WriteLine("Descuento: $" + descuento);
        Console.WriteLine("Total a pagar: $" + (compra - descuento));
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio8();
void ejercicio9()
{
    try
    {
        Console.WriteLine("----Ejercicio 9----");

        Console.Write("Ingrese la edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el sexo (F/M): ");
        char sexo = Convert.ToChar(Console.ReadLine().ToUpper());

        double pulsaciones;

        if (sexo == 'F')
        {
            pulsaciones = (220 - edad) / 10.0;
        }
        else if (sexo == 'M')
        {
            pulsaciones = (210 - edad) / 10.0;
        }
        else
        {
            Console.WriteLine("Sexo incorrecto.");
            return;
        }

        Console.WriteLine("Número de pulsaciones: " + pulsaciones);
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio9();
void ejercicio10()
{
    try
    {
        Console.WriteLine("----Ejercicio 10----");

        string nombre1, apellido1, nombre2, apellido2, nombre3, apellido3;
        double promedio1, promedio2, promedio3;

        Console.Write("Nombre del alumno 1: ");
        nombre1 = Console.ReadLine();
        Console.Write("Apellido: ");
        apellido1 = Console.ReadLine();
        Console.Write("Promedio: ");
        promedio1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nombre del alumno 2: ");
        nombre2 = Console.ReadLine();
        Console.Write("Apellido: ");
        apellido2 = Console.ReadLine();
        Console.Write("Promedio: ");
        promedio2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nombre del alumno 3: ");
        nombre3 = Console.ReadLine();
        Console.Write("Apellido: ");
        apellido3 = Console.ReadLine();
        Console.Write("Promedio: ");
        promedio3 = Convert.ToDouble(Console.ReadLine());

        if (promedio1 >= promedio2 && promedio1 >= promedio3)
        {
            Console.WriteLine("Abanderado: " + nombre1 + " " + apellido1);

            if (promedio2 >= promedio3)
            {
                Console.WriteLine("Primer escolta: " + nombre2 + " " + apellido2);
                Console.WriteLine("Segundo escolta: " + nombre3 + " " + apellido3);
            }
            else
            {
                Console.WriteLine("Primer escolta: " + nombre3 + " " + apellido3);
                Console.WriteLine("Segundo escolta: " + nombre2 + " " + apellido2);
            }
        }
        else if (promedio2 >= promedio1 && promedio2 >= promedio3)
        {
            Console.WriteLine("Abanderado: " + nombre2 + " " + apellido2);

            if (promedio1 >= promedio3)
            {
                Console.WriteLine("Primer escolta: " + nombre1 + " " + apellido1);
                Console.WriteLine("Segundo escolta: " + nombre3 + " " + apellido3);
            }
            else
            {
                Console.WriteLine("Primer escolta: " + nombre3 + " " + apellido3);
                Console.WriteLine("Segundo escolta: " + nombre1 + " " + apellido1);
            }
        }
        else
        {
            Console.WriteLine("Abanderado: " + nombre3 + " " + apellido3);

            if (promedio1 >= promedio2)
            {
                Console.WriteLine("Primer escolta: " + nombre1 + " " + apellido1);
                Console.WriteLine("Segundo escolta: " + nombre2 + " " + apellido2);
            }
            else
            {
                Console.WriteLine("Primer escolta: " + nombre2 + " " + apellido2);
                Console.WriteLine("Segundo escolta: " + nombre1 + " " + apellido1);
            }
        }
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio10();
void ejercicio11()
{
    Console.WriteLine("----Ejercicio 11----");
    bool sigue = true;
    string numeroeningles = "";
    int numero = 0;
    while (sigue)
    {
        Console.WriteLine("Ingrese un numero entre 0-9");
        numero = int.Parse(Console.ReadLine());
        if (numero > 9 || numero < 0)
        {
            sigue = true;
        }
        else
        {
            sigue = false;
        }
    }
    switch (numero)
    {
        case 0:
            numeroeningles = "Zero";
            break;
        case 1:
            numeroeningles = "One";
            break;
        case 2:
            numeroeningles = "Two";
            break;
        case 3:
            numeroeningles = "Three";
            break;
        case 4:
            numeroeningles = "Four";
            break;
        case 5:
            numeroeningles = "Five";
            break;
        case 6:
            numeroeningles = "Six";
            break;
        case 7:
            numeroeningles = "Seven";
            break;
        case 8:
            numeroeningles = "Eight";
            break;
        case 9:
            numeroeningles = "Nine";
            break;
        default:
            Console.WriteLine("Ingrese un numero correcto");
            break;
    }
    Console.WriteLine("Su numero en ingles es " + numeroeningles);
}
ejercicio11();
void ejercicio12()
{
    try
    {
        Console.WriteLine("----Ejercicio 12----");

        Console.WriteLine("1- Triángulo");
        Console.WriteLine("2- Círculo");
        Console.WriteLine("3- Rectángulo");
        Console.WriteLine("4- Hexágono");

        Console.Write("Elija una figura: ");
        int figura = Convert.ToInt32(Console.ReadLine());

        double area = 0;

        switch (figura)
        {
            case 1:
                Console.Write("Base: ");
                double baseT = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                area = (baseT * altura) / 2;
                break;

            case 2:
                Console.Write("Radio: ");
                double radio = Convert.ToDouble(Console.ReadLine());

                area = 3.14 * radio * radio;
                break;

            case 3:
                Console.Write("Base: ");
                double baseR = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura: ");
                double alturaR = Convert.ToDouble(Console.ReadLine());

                area = baseR * alturaR;
                break;

            case 4:
                Console.Write("Lado: ");
                double lado = Convert.ToDouble(Console.ReadLine());

                area = (3 * 1.73 * lado * lado) / 2;
                break;

            default:
                Console.WriteLine("Figura incorrecta.");
                return;
        }

        Console.WriteLine("El área es: " + area);
    }
    catch
    {
        Console.WriteLine("Error al ingresar los datos.");
    }
}
ejercicio12();
void ejercicio13()
{
    Console.WriteLine("----Ejercicio 13----");

    Console.Write("Ingrese el valor de A (V/F): ");
    char A = Convert.ToChar(Console.ReadLine().ToUpper());

    if (A != 'V' && A != 'F')
    {
        Console.WriteLine("Entrada incorrecta.");
        return;
    }

    Console.Write("Ingrese el valor de B (V/F): ");
    char B = Convert.ToChar(Console.ReadLine().ToUpper());

    if (B != 'V' && B != 'F')
    {
        Console.WriteLine("Entrada incorrecta.");
        return;
    }

    if (A == 'V' && B == 'V')
        Console.WriteLine("AND = V");
    else
        Console.WriteLine("AND = F");

    if (A == 'F' && B == 'F')
        Console.WriteLine("NOR = V");
    else
        Console.WriteLine("NOR = F");
}
ejercicio13();
void ejercicio14()
{
    Console.WriteLine("----Ejercicio 14----");

    Console.Write("Ingrese la cantidad de camisas compradas: ");
    int camisas = Convert.ToInt32(Console.ReadLine());

    if (camisas <= 0)
    {
        Console.WriteLine("Cantidad incorrecta.");
        return;
    }

    Console.Write("Ingrese el precio total: ");
    double total = Convert.ToDouble(Console.ReadLine());

    double descuento;

    if (camisas <= 4)
        descuento = total * 0.125;
    else if (camisas <= 8)
        descuento = total * 0.20;
    else
        descuento = total * 0.315;

    Console.WriteLine("Compra sin descuento: $" + total);
    Console.WriteLine("Descuento: $" + descuento);
    Console.WriteLine("Compra con descuento: $" + (total - descuento));
}
ejercicio14();
void ejercicio15()
{
    Console.WriteLine("----Ejercicio 15----");
    Console.WriteLine("Ingrese un número del 1 al 10");
    int numero = int.Parse(Console.ReadLine());

    if (numero < 1 || numero > 10)
    {
        Console.WriteLine("Número incorrecto.");
    }
    else if (numero == 1 || numero == 4 || numero == 6 || numero == 8 || numero == 9 || numero == 10)
    {
        Console.WriteLine("Su número no es primo porque tiene más divisores que 1 y él mismo.");
    }
    else
    {
        Console.WriteLine("Su número es primo.");
    }
}
ejercicio15();
void ejercicio16()
{
    Console.WriteLine("----Ejercicio 16----");

    Console.Write("Hora: ");
    int hora = Convert.ToInt32(Console.ReadLine());

    Console.Write("Minutos: ");
    int minutos = Convert.ToInt32(Console.ReadLine());

    Console.Write("Segundos: ");
    int segundos = Convert.ToInt32(Console.ReadLine());

    Console.Write("AM o PM: ");
    string turno = Console.ReadLine().ToUpper();

    segundos += 10;

    if (segundos >= 60)
    {
        segundos -= 60;
        minutos++;
    }

    if (minutos >= 60)
    {
        minutos = 0;
        hora++;
    }

    if (hora > 12)
    {
        hora = 1;
    }

    if (hora == 12 && minutos == 0 && segundos == 0)
    {
        if (turno == "AM")
            turno = "PM";
        else
            turno = "AM";
    }

    Console.WriteLine("La hora luego de 10 segundos es: " + hora + ":" + minutos + ":" + segundos + " " + turno);
}
ejercicio16();
void ejercicio17()
{
    Console.WriteLine("----Ejercicio 17----");

    Console.Write("Ingrese A: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese B: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese C: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double delta = (b * b) - (4 * a * c);

    if (a == 0)
    {
        Console.WriteLine("No es una ecuación de segundo grado.");
    }
    else if (delta < 0)
    {
        Console.WriteLine("No tiene soluciones reales.");
    }
    else
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("X1 = " + x1);
        Console.WriteLine("X2 = " + x2);
    }
}
ejercicio17();
void ejercicio18()
{
    Console.WriteLine("----Ejercicio 18----");

    Console.WriteLine("1- Metros a Pies");
    Console.WriteLine("2- Pies a Metros");
    Console.WriteLine("3- Centímetros a Pulgadas");
    Console.WriteLine("4- Pulgadas a Centímetros");

    Console.Write("Elija una opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el valor: ");
    double valor = Convert.ToDouble(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Resultado: " + (valor * 3.28));
            break;

        case 2:
            Console.WriteLine("Resultado: " + (valor / 3.28));
            break;

        case 3:
            Console.WriteLine("Resultado: " + (valor / 2.54));
            break;

        case 4:
            Console.WriteLine("Resultado: " + (valor * 2.54));
            break;

        default:
            Console.WriteLine("Opción incorrecta.");
            break;
    }
}
ejercicio18();
void ejercicio19()
{
    Console.WriteLine("----Ejercicio 19----");
    Console.WriteLine("Ingrese un número del 1 al 10:");
    int numero = int.Parse(Console.ReadLine());

    if (numero == 1)
        Console.WriteLine("I");
    else if (numero == 2)
        Console.WriteLine("II");
    else if (numero == 3)
        Console.WriteLine("III");
    else if (numero == 4)
        Console.WriteLine("IV");
    else if (numero == 5)
        Console.WriteLine("V");
    else if (numero == 6)
        Console.WriteLine("VI");
    else if (numero == 7)
        Console.WriteLine("VII");
    else if (numero == 8)
        Console.WriteLine("VIII");
    else if (numero == 9)
        Console.WriteLine("IX");
    else if (numero == 10)
        Console.WriteLine("X");
    else
        Console.WriteLine("Número fuera de rango.");
}
ejercicio19();
void ejercicio20()
{
    Console.WriteLine("----Ejercicio 20----");
    Console.Write("Estado del interruptor 1 (0 o 1): ");
    int i1 = int.Parse(Console.ReadLine());

    Console.Write("Estado del interruptor 2 (0 o 1): ");
    int i2 = int.Parse(Console.ReadLine());

    Console.Write("Estado del interruptor 3 (0 o 1): ");
    int i3 = int.Parse(Console.ReadLine());

    int cerrados = i1 + i2 + i3;

    if (cerrados >= 2)
    {
        Console.WriteLine("El equipo funcionará.");
    }
    else
    {
        Console.WriteLine("El equipo NO funcionará.");
    }


}
ejercicio20();
void ejercicio21()
{
    Console.WriteLine("----Ejercicio 21----");
    int[] conjunto1 = new int[3];
    int[] conjunto2 = new int[3];
    bool hayInterseccion = false;

    Console.WriteLine("Ingrese los números del primer conjunto:");

    for (int i = 0; i < 3; i++)
    {
        conjunto1[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Ingrese los números del segundo conjunto:");

    for (int i = 0; i < 3; i++)
    {
        conjunto2[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Los números que están en ambos conjuntos son:");

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (conjunto1[i] == conjunto2[j])
            {
                Console.WriteLine(conjunto1[i]);
                hayInterseccion = true;
            }
        }
    }

    if (hayInterseccion == false)
    {
        Console.WriteLine("No hay números en común.");
    }
}
ejercicio21();
void ejercicio22()
{
    Console.Write("Ingrese el lado A");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el lado B");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el lado C");
    double c = Convert.ToDouble(Console.ReadLine());

    if (a == b && b == c)
    {
        Console.WriteLine("equilatero");
    }
    else if (a == b || b == c || a == c)
    {
        Console.WriteLine("isosceles");
    }
    else
    {
        Console.WriteLine("escaleno");
    }
}
ejercicio22();