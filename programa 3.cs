string palabraS = "holanda";

char letra = ' ';
string progreso = "";

Console.WriteLine("JUEGO DEL AHORCADO");
Console.WriteLine("");

for (int i = 0; i < palabraS.Length; i++)
{
    progreso += "_";
}

int intentos = 7;
bool gano = false;

while (intentos > 0 && !gano)
{
    Console.WriteLine("");
    Console.WriteLine("Palabra: " + progreso);
    Console.WriteLine("intentos restantes: " + intentos);
    Console.WriteLine("ingrese una letra");

    try
    {
        letra = Convert.ToChar(Console.ReadLine());
    }
    catch (System.FormatException)
    {
        Console.WriteLine("el caracter que pusiste no es valido");
    }
    string nuevo = "";
    bool encontro = false;


    for (int i = 0; i < palabraS.Length; i++)
    {
        if (letra == palabraS[i])
        {
            nuevo += letra;
            encontro = true;
        }
        else
        {
            nuevo += progreso[i];
        }
    }

    progreso = nuevo;

    if (encontro == false)
    {
        Console.WriteLine("letra incorrecta");
        intentos--;
    }
    else
    {
        Console.WriteLine("¡letra correcta!");
        Console.WriteLine(progreso);
    }

    if (palabraS == progreso)
    {
        gano = true;
        Console.WriteLine("¡Felicidades adivinaste la palabra " + palabraS + "!");
        break;
    }
    if (intentos == 0)
    {
        Console.WriteLine("Se han agotado sus intentos la palabra era: " + palabraS);
        break;
    }
}