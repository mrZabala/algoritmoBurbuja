using System;

namespace algoritmoBurbuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 64, 34, 25, 12, 22, 11, 90 };

            //Total de elementos en el array
            Console.WriteLine($"Numero total de elementos en el arreglo: {arreglo.Length}");

            //Console.WriteLine(arreglo.length);

            int sumaPares = 0;

            //Numeros pares en el array
            Console.WriteLine("\nNumeros pares en el array");
            foreach (int num in arreglo)
            {
                if (EsPar(num))
                {
                    Console.Write(num + " ");
                    sumaPares += num;
                }
            }

            //llamada de la funcion que ordena el arreglo
            Burbuja(arreglo);

            Console.WriteLine();

            //Suma de los numeros pares
            Console.WriteLine($"\nLa suma de los números pares es: {ConvertirNumeroALetras(sumaPares)}.");

            //Orden del arreglo
            Console.WriteLine("\nArreglo ordenado: ");
            ImprimirArreglo(arreglo);
        }
        static void Burbuja(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    //Compara los elementos del array
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        //Intercambia los elementos que esten en el orden incorrecto
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
        }
        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
        static string ConvertirNumeroALetras(int numero)
        {
            return numero.ToString();
        }
        static void ImprimirArreglo(int[] arreglo)
        {
            foreach (var elemento in arreglo)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
    }
}


