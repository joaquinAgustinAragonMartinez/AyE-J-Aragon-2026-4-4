Console.WriteLine("ingrese su nombre");
string nombre = Console.ReadLine();

Console.WriteLine("ingrese su promedio");
float promedio = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("ingrese la distancia en kilometros a la que vive");
int distancia = Convert.ToInt32(Console.ReadLine());

bool DeterminarBeca(float promedio, int distancia)
{
    if (promedio >= 8.5 || distancia > 50)
    {
        Console.WriteLine("Felicidades " +nombre+ ", tu beca ha sido aprobada");
        return true;
    }
    else
    {
        Console.WriteLine("Lo sentimos, no cumples con los requisitos mínimos");
        return false;
    }
}
DeterminarBeca(promedio, distancia);