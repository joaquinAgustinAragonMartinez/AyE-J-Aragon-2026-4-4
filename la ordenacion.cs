namespace busquedas_y_ordenamientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 42, 17, 8, 31, 23, 5, 49, 14, 38, 26,
                45, 11, 29, 3, 20, 36, 12, 47, 34, 1,
                25, 40, 9, 33, 22, 16, 50, 7, 28, 44,
                19, 43, 4, 37, 13, 24, 46, 30, 2, 35,
                18, 41, 15, 6, 21, 32, 48, 10, 39, 27 };

            int[] copia = (int[])vector.Clone();

            Mostrar(vector);

            int opcion;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("BUSQUEDAS");
                Console.WriteLine("1 - Busqueda Simple");
                Console.WriteLine("2 - Busqueda Optimizada");
                Console.WriteLine("3 - Busqueda Binaria Iterativa");
                Console.WriteLine("4 - Busqueda Binaria Recursiva");
                Console.WriteLine("5 - Salir");

                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.Write("Ingrese el numero que busca: ");
                    int numero = int.Parse(Console.ReadLine());

                    int resultado = -1;

                    if (opcion == 1)
                    {
                        resultado = BusquedaSimple(copia, numero);
                    }
                    else if (opcion == 2)
                    {
                        resultado = BusquedaOptimizada(copia, numero);
                    }
                    else if (opcion == 3)
                    {
                        // Para la busqueda binaria primero hay que ordenar
                        Ordenar(copia);
                        resultado = BusquedaBinaria(copia, numero);
                    }
                    else if (opcion == 4)
                    {
                        Ordenar(copia);
                        resultado = BusquedaBinariaRecursiva(copia, numero, 0, copia.Length - 1);
                    }

                    if (resultado != -1)
                        Console.WriteLine("Numero encontrado");
                    else
                        Console.WriteLine("Numero no encontrado");
                }

            } while (opcion != 5);


            int opcion2;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("ORDENAMIENTOS");
                Console.WriteLine("1 - Burbuja Simple");
                Console.WriteLine("2 - Burbuja Optimizada");
                Console.WriteLine("3 - Seleccion");
                Console.WriteLine("4 - Insercion");
                Console.WriteLine("5 - QuickSort");
                Console.WriteLine("6 - Stanlin");
                Console.WriteLine("7 - BogoSort");
                Console.WriteLine("8 - Salir");

                opcion2 = int.Parse(Console.ReadLine());

                // Se vuelve a copiar el vector para que
                // cada ordenamiento empiece desordenado
                int[] v = (int[])vector.Clone();

                switch (opcion2)
                {
                    case 1:
                        Console.WriteLine("Burbuja Simple:");
                        Burbuja(v);
                        Mostrar(v);
                        break;

                    case 2:
                        Console.WriteLine("Burbuja Optimizada:");
                        BurbujaOptimizada(v);
                        Mostrar(v);
                        break;

                    case 3:
                        Console.WriteLine("Seleccion:");
                        Seleccion(v);
                        Mostrar(v);
                        break;

                    case 4:
                        Console.WriteLine("Insercion:");
                        Insercion(v);
                        Mostrar(v);
                        break;

                    case 5:
                        Console.WriteLine("QuickSort:");
                        QuickSort(v, 0, v.Length - 1);
                        Mostrar(v);
                        break;

                    case 6:
                        Console.WriteLine("Stanlin:");
                        int cantidad = Stanlin(v);

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.Write(v[i] + " ");
                        }

                        Console.WriteLine();
                        break;

                    case 7:
                        Console.WriteLine("BogoSort:");
                        int intentos = BogoSort(v);
                        Mostrar(v);
                        Console.WriteLine("Intentos: " + intentos);
                        break;

                    case 8:
                        Console.WriteLine("Fin del programa");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            } while (opcion2 != 8);
        }


        static void Mostrar(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.WriteLine();
        }


        // BUSQUEDAS

        static int BusquedaSimple(int[] vector, int numero)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numero)
                {
                    return i;
                }
            }

            return -1;
        }


        static int BusquedaOptimizada(int[] vector, int numero)
        {
            Ordenar(vector);

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numero)
                {
                    return i;
                }

                if (vector[i] > numero)
                {
                    return -1;
                }
            }

            return -1;
        }


        static int BusquedaBinaria(int[] vector, int numero)
        {
            int inicio = 0;
            int fin = vector.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (vector[medio] == numero)
                {
                    return medio;
                }

                if (vector[medio] < numero)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return -1;
        }


        static int BusquedaBinariaRecursiva(int[] vector, int numero, int inicio, int fin)
        {
            if (inicio > fin)
            {
                return -1;
            }

            int medio = (inicio + fin) / 2;

            if (vector[medio] == numero)
            {
                return medio;
            }

            if (vector[medio] < numero)
            {
                return BusquedaBinariaRecursiva(vector, numero, medio + 1, fin);
            }
            else
            {
                return BusquedaBinariaRecursiva(vector, numero, inicio, medio - 1);
            }
        }


        // ORDENAMIENTOS

        static void Burbuja(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }
        }


        static void BurbujaOptimizada(int[] vector)
        {
            bool cambio;

            for (int i = 0; i < vector.Length - 1; i++)
            {
                cambio = false;

                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;

                        cambio = true;
                    }
                }

                if (cambio == false)
                {
                    break;
                }
            }
        }


        static void Seleccion(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                int menor = i;

                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[j] < vector[menor])
                    {
                        menor = j;
                    }
                }

                int aux = vector[i];
                vector[i] = vector[menor];
                vector[menor] = aux;
            }
        }


        static void Insercion(int[] vector)
        {
            for (int i = 1; i < vector.Length; i++)
            {
                int numero = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > numero)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }

                vector[j + 1] = numero;
            }
        }


        static void QuickSort(int[] vector, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int posicion = Particion(vector, inicio, fin);

                QuickSort(vector, inicio, posicion - 1);
                QuickSort(vector, posicion + 1, fin);
            }
        }


        static int Particion(int[] vector, int inicio, int fin)
        {
            int pivote = vector[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (vector[j] < pivote)
                {
                    i++;

                    int aux = vector[i];
                    vector[i] = vector[j];
                    vector[j] = aux;
                }
            }

            int aux2 = vector[i + 1];
            vector[i + 1] = vector[fin];
            vector[fin] = aux2;

            return i + 1;
        }


        static int Stanlin(int[] vector)
        {
            int cantidad = vector.Length;
            int i = 0;

            while (i < cantidad - 1)
            {
                if (vector[i + 1] > vector[i])
                {
                    for (int j = i + 1; j < cantidad - 1; j++)
                    {
                        vector[j] = vector[j + 1];
                    }

                    cantidad--;
                }
                else
                {
                    i++;
                }
            }

            return cantidad;
        }


        static int BogoSort(int[] vector)
        {
            Random random = new Random();
            int intentos = 0;

            while (!EstaOrdenado(vector))
            {
                Mezclar(vector, random);
                intentos++;
            }

            return intentos;
        }


        static void Mezclar(int[] vector, Random random)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                int posicion = random.Next(vector.Length);

                int aux = vector[i];
                vector[i] = vector[posicion];
                vector[posicion] = aux;
            }
        }


        static bool EstaOrdenado(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    return false;
                }
            }

            return true;
        }


        // Ordenamiento usado para las busquedas optimizadas
        static void Ordenar(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }
        }
    }
}
