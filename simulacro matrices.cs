//ejercicio 1
Random random = new Random();

string[] nombres = {"Juan","Pedro","Lucas","Martin","Mateo","Tomas","Franco","Agustin", "Santiago","Joaquin","Thiago","Facundo","Bruno","Nicolas","Lautaro", "Valentin","Benjamin","Enzo","Ramiro","Kevin","Alan","Ivan","Diego", "Marcos","Emiliano","Gaston","Federico","Cristian","Maximo","Lionel"};
string[] posiciones = {"Arquero", "Defensor", "Mediocampista", "Delantero"};

string[,] equipo1 = new string[23, 3];
string[,] equipo2 = new string[23, 3];

int total1 = 0;
int total2 = 0;

for (int i = 0; i < 23; i++)
{
    equipo1[i, 0] = nombres[random.Next(nombres.Length)];
    equipo1[i, 1] = posiciones[random.Next(posiciones.Length)];
    equipo1[i, 2] = random.Next(50, 101).ToString();

    total1 = total1 + int.Parse(equipo1[i, 2]);
}

for (int i = 0; i < 23; i++)
{
    equipo2[i, 0] = nombres[random.Next(nombres.Length)];
    equipo2[i, 1] = posiciones[random.Next(posiciones.Length)];
    equipo2[i, 2] = random.Next(50, 101).ToString();

    total2 = total2 + int.Parse(equipo2[i, 2]);
}

Console.WriteLine("EQUIPO 1");
for (int i = 0; i < 23; i++)
{
    Console.WriteLine(equipo1[i, 0] + " - " + equipo1[i, 1] + " - " + equipo1[i, 2]);
}

Console.WriteLine();
Console.WriteLine("la valoracion total es " + total1);

Console.WriteLine();
Console.WriteLine("EQUIPO 2");

for (int i = 0; i < 23; i++)
{
    Console.WriteLine(equipo2[i, 0] + " - " + equipo2[i, 1] + " - " + equipo2[i, 2]);
}

Console.WriteLine();
Console.WriteLine("la valoracion total es " + total2);

Console.WriteLine();

if (total1 > total2)
{
    Console.WriteLine("el Equipo 1 tiene mas chances de ganar");
}
if (total2 > total1)
{
    Console.WriteLine("el Equipo 2 tiene mas chances de ganar");
}
if (total1 == total2)
{
    Console.WriteLine("empate");
}

//ejercicio 2
Console.WriteLine("Ingrese un numero:");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la potencia:");
int potencia = int.Parse(Console.ReadLine());

int Recursiva(int numero, int potencia)
{
    if (potencia == 0)
    {
        return 1;
    }
    else
    {
        return numero * Recursiva(numero, potencia - 1);
    }
}

Console.WriteLine("Resultado: " + Recursiva(numero, potencia));