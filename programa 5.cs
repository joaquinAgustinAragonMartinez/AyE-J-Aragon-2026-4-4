string[] nombre = new string[100];
string[] numeros = new string[100];

string[] caso1(string[] listadenombres)
{
    Console.WriteLine("¿Cuantos contactos desea añadir?");
    int cantidadcont = int.Parse(Console.ReadLine());
    for (int i = 0; i < cantidadcont; i++)
    {
        listadenombres[i] = Console.ReadLine();
    }
    return listadenombres;
}
string[] caso2(string[] listadenumeros)
{
    Console.WriteLine("¿Cuantos contactos desea añadir?");
    int cantidadcont = int.Parse(Console.ReadLine());
    for (int i = 0; i < cantidadcont; i++)
    {
        listadenumeros[i] = Console.ReadLine();
    }
    return listadenumeros;
}
string[] caso3()
{
    for (int i = 0; i < nombre.Length - 1; i++)
    {
        Console.WriteLine(nombre[i]);
    }
    return nombre;
}
string[] caso4()
{
    Console.WriteLine("Ingrese el nombre a buscar");
    string buscar = Console.ReadLine();
    for (int i = 0; i < nombre.Length; i++)
    {
        if (buscar == nombre[i])
        {
            Console.WriteLine("el nombre fue encontrado: " + nombre[i]);
        }
    }
    return nombre;
}
bool seguimos = true;
while (seguimos == true)
{
    Console.WriteLine("");
    Console.WriteLine("ingrese un numero");
    Console.WriteLine("0 = salir, 1 = añadir nombre a los contactos , 2 = añadir numero a los contactos 3 = mostrar todos los contactos, 4 = buscar un contacto");

    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (x)
    {
        case 0:
            seguimos = false;
            Console.WriteLine("saliendo del programa...");
            break;
        case 1:
            caso1(nombre);
            break;
        case 2:
            caso2(numeros);
            break;
        case 3:
            caso3();
            break;
        case 4:
            caso4();
            break;
        default:
            Console.WriteLine("no seleccionaste ninguno de los numeros");
            break;
    }
}