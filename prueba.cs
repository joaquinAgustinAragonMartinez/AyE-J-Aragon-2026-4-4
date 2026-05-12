//int i = 1; 40 < horastrabajadas.Length; i++
//ejercicio 1
Console.WriteLine("ingrese cuantas horas por semana trabaja");
int horastrabajadas = Convert.ToInt32(Console.ReadLine());
int salariophora;
int salario;
int salarioextra = 20;
int salarioe;

if (horastrabajadas <= 40)
{
    salariophora = 16;
    salario = salariophora * horastrabajadas;
    Console.WriteLine("el salario semanal es " + salario + "$");
}
else
{
    salarioe = 640 + (horastrabajadas * salarioextra);
    Console.WriteLine("el salario semanal es " + salarioe + "$");
}

//ejercicio 2
int num = Convert.ToInt32("");
bool num0 = false;
int acum = 0;
while (num != 0)
{
    Console.WriteLine("ingrese numero");
    num = Convert.ToInt32(Console.ReadLine());
    if (num == 0)
    {
        Console.WriteLine("ha ingresado un 0");
        break;
    }
    else
    {
        acum = acum + num;
    }

}
Console.WriteLine("la suma de todos los numeros que ingreso es: " + acum);

//ejercicio 3
string vocales = "aeiouAEIOU";
int contador = 0;
string palabra = "";

Console.WriteLine("ingrese una palabra");
palabra = Console.ReadLine();

for (int i = 1; i <= palabra.Length; i++)
{
    for (int j = 1; j <= vocales.Length; j++)
    {
        if (palabra[i] == vocales[j])
        {
            contador++;
        }
    }
}
Console.WriteLine("la palabra tiene " + contador + " vocales");

//ejercicio 4
bool palindromio = false;
string palabraalrevez = "";

while (!palindromio)
{
    Console.WriteLine("ingrese una palabra");
    string palabra2 = Console.ReadLine();

    for (int k = 1; k < palabra2.Length; k--)
    {
        if (palabra2 == )
        {
            palindromio = true;
        }
        else
        {
            Console.WriteLine("la palabra no es un palindromio");
            palindromio = false;
        }
    }
}
Console.WriteLine("la palabra es un palindromio");