Console.WriteLine("ingrese que operacion realizara");
bool seguimos = true;

string abecedario = "abcdefghijklmnñopqrstuvwxyz ";

while (seguimos == true)
{
    Console.WriteLine("");
    Console.WriteLine("cifrado cesar");
    Console.WriteLine("0. Salir");
    Console.WriteLine("1. cifrar/descifrar");

    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (x)
    {
        case 0:
            seguimos = false;
            break;

        case 1:
            string mensaje = funcion1();
            string resultado = funcion2(mensaje);
            Console.WriteLine("resultado: " + resultado);
            break;
    }
}

string funcion1()
{
    string mensaje = "";
    bool EsValido = false;

    while (!EsValido)
    {
        Console.WriteLine("ingrese el mensaje a cifrar/descifrar");
        mensaje = Console.ReadLine();
        mensaje = mensaje.ToLower();

        bool ContieneError = false;

        for (int i = 0; i < mensaje.Length; i++)
        {
            char caracterUsuario = mensaje[i];
            bool encontrado = false;

            for (int j = 0; j < abecedario.Length; j++)
            {
                if (caracterUsuario == abecedario[j])
                {
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                ContieneError = true;
                Console.WriteLine("el mensaje contiene caracteres especiales");
                break;
            }
        }

        if (!ContieneError)
        {
            EsValido = true;
        }
    }

    return mensaje;
}

string funcion2(string mensaje)
{
    Console.WriteLine("ingrese si quiere cifrar o descifrar");
    Console.WriteLine("1 - cifrar, 2 - descifrar");

    int opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ingrese la clave");
    int clave = Convert.ToInt32(Console.ReadLine());

    string resultado = "";

    for (int i = 0; i < mensaje.Length; i++)
    {
        char letra = mensaje[i];
        int posicion = -1;

        for (int j = 0; j < abecedario.Length; j++)
        {
            if (letra == abecedario[j])
            {
                posicion = j;
                break;
            }
        }

        int nuevaPosicion;

        if (opcion == 1)
        {
            nuevaPosicion = posicion + clave;
        }
        else
        {
            nuevaPosicion = posicion - clave;
        }

        while (nuevaPosicion >= abecedario.Length)
        {
            nuevaPosicion -= abecedario.Length;
        }

        while (nuevaPosicion < 0)
        {
            nuevaPosicion += abecedario.Length;
        }

        resultado += abecedario[nuevaPosicion];
    }

    return resultado;
}