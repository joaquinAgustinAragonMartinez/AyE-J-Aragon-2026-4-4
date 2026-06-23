bool seguimos = true;
int opcion = 0;
int cantidad;
int carta_descartada;
string palo, numero;
bool cartas_repartidas = false;

Random random = new Random();

string[] posibles_palos = ["Picas", "Corazones", "Treboles", "Diamantes"];
string[] posibles_numeros = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"];

string[] carta1 = new string[2];
string[] carta2 = new string[2];
string[] carta3 = new string[2];
string[] carta4 = new string[2];
string[] carta5 = new string[2];
string[] carta6 = new string[2];
string[] carta7 = new string[2];
string[] carta8 = new string[2];

while (seguimos)
{
    Console.WriteLine("1- Pedir cartas");
    Console.WriteLine("2- Descartar cartas");
    Console.WriteLine("3- Salir");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            repartir_cartas();
            cartas_repartidas = true;
            Console.WriteLine("Cartas entregadas:");
            mostrar_cartas();
            break;

        case 2:
            if (cartas_repartidas)
            {
                descartar();
            }
            else
            {
                Console.WriteLine("Primero debes pedir cartas");
            }
            break;

        case 3:
            Console.WriteLine("Fin del juego");
            seguimos = false;
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
}

void repartir_cartas()
{
    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta1 = [palo, numero];

    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta2 = [palo, numero];

    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta3 = [palo, numero];

    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta4 = [palo, numero];

    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta5 = [palo, numero];

    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta6 = [palo, numero];

    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta7 = [palo, numero];

    palo = posibles_palos[random.Next(0, 4)];
    numero = posibles_numeros[random.Next(0, 13)];
    carta8 = [palo, numero];
}

void descartar()
{
    Console.WriteLine("¿Cuantas cartas quiere descartar?");
    cantidad = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine("Ingrese el numero de carta a descartar");
        carta_descartada = Convert.ToInt32(Console.ReadLine());

        palo = posibles_palos[random.Next(0, 4)];
        numero = posibles_numeros[random.Next(0, 13)];

        switch (carta_descartada)
        {
            case 1:
                carta1 = [palo, numero];
                break;
            case 2:
                carta2 = [palo, numero];
                break;
            case 3:
                carta3 = [palo, numero];
                break;
            case 4:
                carta4 = [palo, numero];
                break;
            case 5:
                carta5 = [palo, numero];
                break;
            case 6:
                carta6 = [palo, numero];
                break;
            case 7:
                carta7 = [palo, numero];
                break;
            case 8:
                carta8 = [palo, numero];
                break;
            default:
                Console.WriteLine("Ingrese una carta correcta");
                break;
        }
    }

    Console.WriteLine("Tus cartas actuales son:");
    mostrar_cartas();
}

void mostrar_cartas()
{
    Console.WriteLine("1 " + carta1[1] + " de " + carta1[0]);
    Console.WriteLine("2 " + carta2[1] + " de " + carta2[0]);
    Console.WriteLine("3 " + carta3[1] + " de " + carta3[0]);
    Console.WriteLine("4 " + carta4[1] + " de " + carta4[0]);
    Console.WriteLine("5 " + carta5[1] + " de " + carta5[0]);
    Console.WriteLine("6 " + carta6[1] + " de " + carta6[0]);
    Console.WriteLine("7 " + carta7[1] + " de " + carta7[0]);
    Console.WriteLine("8 " + carta8[1] + " de " + carta8[0]);
}
