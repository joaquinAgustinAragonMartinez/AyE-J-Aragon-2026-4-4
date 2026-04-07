//Ejercicio 1: Contraseña secreta
using System.Globalization;
using System.Timers;
Console.WriteLine("ingrese una contraseña");
string contraseña = Console.ReadLine();

while (contraseña != "hola123")
{
    Console.WriteLine("la contraseña ingresada es incorrecta");
    contraseña = Console.ReadLine();
}
Console.WriteLine("entrando...");
Console.WriteLine("");

//Ejercicio 2: Despegue!
Console.WriteLine("empezando cuenta regresiva desde 5 hasta 1");
for (int x = 5; x >= 1; x--)
{  
        Console.WriteLine(x);
 }
Console.WriteLine("¡Listo para despegar!");
Console.WriteLine("¡Despegue!");
Console.WriteLine("");

//Ejercicio 3: Numero Secreto
int num;
    Console.WriteLine("ingrese un numero");
    num = Convert.ToInt32(Console.ReadLine());
while (num != 7){
    
    Console.WriteLine("numero ingresado es incorrecto");
    Console.WriteLine("ingrese otro numero");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("adivinaste el numero!");
Console.WriteLine("");

//Ejercicio 4: Muchas sumas!
Console.WriteLine("ingrese numeros y escriba 0 para finalizar");
int acum = 0;
int num1 = Convert.ToInt32(Console.ReadLine());
while (num1 != 0){
    acum = acum + num1;
    num1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("la suma total es de");
Console.WriteLine(acum);