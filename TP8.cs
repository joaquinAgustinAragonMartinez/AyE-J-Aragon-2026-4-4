//Ejercicio 1: Vocales
using System.Transactions;

Console.WriteLine("ingrese un frase");
string frase = Console.ReadLine();
string vocales = ("aeiouAEIOU");
int contador = 0;

foreach (char f in frase)
{
    foreach (char v in vocales)
    {
        if (f == v)
        {
            contador++;
            break;
        }
    }
}
Console.WriteLine(contador);

//Ejercicio 2: Invertir
Console.WriteLine("ingrese un palabra");
string palabra = Console.ReadLine();

for (int i = palabra.Length - 1; i >= 0; i--)
{
    Console.Write(palabra[i]);
}

//Ejercicio 3: Suma de dígitos
int a = 0;
int b = 0;

Console.WriteLine("");
Console.WriteLine("ingrese un numero entero");
string numero = Console.ReadLine();

foreach (char n in numero)
{
    b = Convert.ToInt32("" + n);
    a = b + a;
}
Console.WriteLine(a);

//Ejercicio 4: El Censor de Palabras:
Console.WriteLine("Este es un texto largo en el que tiene que ingresar una palabra prohibida y una palabra de reemplazo para usar dentro de este texto");
string texto = ("Este es un texto largo en el que tiene que ingresar una palabra prohibida y una palabra de reemplazo para usar dentro de este texto");

Console.WriteLine("ingrese una palabra prohibida");
string pprohibida = Console.ReadLine();
Console.WriteLine("ingrese una palabra de reemplazo");
string preemplazo = Console.ReadLine();

string pnueva = texto.Replace(pprohibida, preemplazo);

Console.WriteLine("esta es la nueva frase");
Console.WriteLine(pnueva);

//Ejercicio 5: Analizador de Nombres
Console.WriteLine("ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("ingrese su apellido");
string apellido = Console.ReadLine();

Console.WriteLine("sus iniciales son " + nombre[0]+ "." + apellido[0]+ "." +" y su nombre completo es " + nombre +" "+ apellido);

//Ejercicio 6:  ¿Es un Palíndromo?
Console.WriteLine("ingrese una palabra");
string palabra2 = Console.ReadLine();
string palabralrevez = "";

for (int i = palabra2.Length - 1; i >= 0; i--)
{
    palabralrevez = palabralrevez + palabra2[i];
}
if (palabra2 == palabralrevez)
{
    Console.WriteLine("la palabra es un palindromo");
}
else
{
    Console.WriteLine("la palabra no es un palindromo");
}