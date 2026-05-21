//ejercicio 1
string[] nombres = { "ramiro", "camila", "joaquin", "valentina", "lucas", "sofia", "mateo", "martina", "elpepe", "pablo" };

string nombremaslargo = nombres[0];

foreach (string nombre in nombres)
{
    if(nombre.Length > nombremaslargo.Length)
    {
        nombremaslargo = nombre;
    }
}
Console.WriteLine("el nombre con mas letras es " + nombremaslargo);

//ejercicio 2
int contador = 0;

foreach (string nombre in nombres)
{
    foreach (char letra in nombre)
    {
        if (letra == 'a'|| letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' || letra == 'a' || letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
        {
            contador += 1;
        }
    }
}
Console.WriteLine("la cantidad de vocales que hay en las palabras son: " + contador);

//ejercicio 3
Console.WriteLine("numeros multiplicados por el factor 3");
int[] numeros = {4,6,8,9,2};
int factor = 3;
int[] resultado = new int[6];

for (int i = 0; i < numeros.Length; i++)
{
    resultado[i] = numeros[i] * factor;
    Console.WriteLine("el resultado es " + resultado[i]);
}