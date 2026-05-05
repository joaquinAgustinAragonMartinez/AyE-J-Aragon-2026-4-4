int acum;
int intentos = 0;
string CaracteresPermitidos = "1234567890";

while (intentos < 3)
{
    Console.WriteLine("ingresa un numero entero y positivo");
    string mensaje = Console.ReadLine();

    bool contieneError = false;

    for (int i = 0; i < mensaje.Length; i++)
    {
        bool encontrado = false;

        for (int j = 0; j < CaracteresPermitidos.Length; j++)
        {
            if (mensaje[i] == CaracteresPermitidos[j])
            {
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            contieneError = true;
            break;
        }
    }

    if (contieneError)
    {
        intentos++;
        Console.WriteLine("no es valido, intentos restantes: " + (3 - intentos));
        continue;
    }

    int numero = Convert.ToInt32(mensaje);

    acum = 1;
    for (int x = numero; x >= 1; x--)
    {
        acum = acum * x;
    }

    Console.WriteLine(acum);

    intentos = 0;
}

Console.WriteLine("numero de intentos agotados");