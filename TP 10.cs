//ejercicio 1
Console.WriteLine("ingrese un numero de 2 cifras");
int numero = Convert.ToInt32(Console.ReadLine());
int unidades;
int decenas;

unidades = numero % 10;
decenas = numero / 10;

Console.WriteLine("el numero ingresado tiene " + unidades + " unidades y " + decenas +  " decenas");

//ejercicio 2
int numero2;
int central;
Console.WriteLine("ingrese un numero de 3 cifras");
numero2 = Convert.ToInt32(Console.ReadLine());

central = (numero2 / 10) % 10;

Console.WriteLine("el valor es " + numero2);
Console.WriteLine("la cifra central es " + central);

//ejercicio 3
int precio_lista;
int descuento;
int preciofinal;

Console.WriteLine("ingrese el precio de lista");
precio_lista = Convert.ToInt32(Console.ReadLine());

descuento = (precio_lista * 18) / 100;

preciofinal = precio_lista - descuento;

Console.WriteLine("el precio de lista es $" + precio_lista);
Console.WriteLine("el descuento es 18 % sobre el precio de lista");
Console.WriteLine("el precio con descuentyo es "+ preciofinal );

//ejercicio 4
int numero3;
int unidades2;
int decenas2;
int permutado;

Console.WriteLine("ingrese un numeor de 2 cifras");
numero3 = Convert.ToInt32(Console.ReadLine());

unidades2 = numero3 % 10;
decenas2 = numero3 / 10;

permutado = (unidades * 10) + decenas;

Console.WriteLine("el valor es " + numero3);
Console.WriteLine("el valor permutado es " + permutado);

//ejercicio 5
int fecha;
int mes;

Console.WriteLine("ingrese una fecha como un entero de 6 digitos");
fecha = Convert.ToInt32(Console.ReadLine());

mes = (fecha / 100) % 2;

Console.WriteLine("la fecha es "+ fecha);
Console.WriteLine("el mes es "+ mes);

//ejercicio 6
int lado;
int perimetro;
int superficie;

Console.WriteLine("ingrese el valor del lado del cuadrado");
lado = Convert.ToInt32(Console.ReadLine());

perimetro = lado * 4;
superficie = lado * lado;

Console.WriteLine("el perimetro es " + perimetro);
Console.WriteLine("la superficie es " + superficie);

//ejercicio 7
int valorHora;
int horasTrabajadas;
int sueldoBruto;

Console.WriteLine("ingrese el valor de una hora de trabajo");
valorHora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingrese la cantidad de horas trabajadas");
horasTrabajadas = Convert.ToInt32(Console.ReadLine());

sueldoBruto = valorHora * horasTrabajadas;

Console.WriteLine("el sueldo bruto es " + sueldoBruto);

//ejercicio 8
int fahrenheit;
int centigrados;

Console.WriteLine("ingrese la temperatura en grados fahrenheit");
fahrenheit = Convert.ToInt32(Console.ReadLine());

centigrados = (fahrenheit - 32) * 5 / 9;

Console.WriteLine("la temperatura engrados centigrados es " + centigrados);

//ejercicio 9
int h1;
int m1;
int s1;
int h2;
int m2;
int s2;
int total1;
int total2;
int intervalo;

Console.WriteLine("ingrese la hora del primer instante");
h1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese los minutos del primer instante");
m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese los segundos del primer instante");
s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingrese la hora del segundo instante");
h2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese los minutos del segundo instante");
m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese los segundos del segundo instante");
s2 = Convert.ToInt32(Console.ReadLine());

total1 = (h1 * 3600) + (m1 * 60) + s1;
total2 = (h2 * 3600) + (m2 * 60) + s2;

intervalo = total2 - total1;

Console.WriteLine("la cantidad de segundos del intervalo es " + intervalo);

//ejercicio 10
int numero4;
int unidades4;
int decenas4;
int centenas4;

Console.WriteLine("ingrese un numero entero de 3 digitos");
numero4 = Convert.ToInt32(Console.ReadLine());

unidades4 = numero4 % 10;
decenas4 = (numero4 / 10) % 10;
centenas4 = numero4 / 100;

Console.WriteLine("el valor ingresado es " + numero);
Console.WriteLine("unidades: " + unidades4);
Console.WriteLine("decenas: " + decenas4);
Console.WriteLine("centenas: " + centenas4);