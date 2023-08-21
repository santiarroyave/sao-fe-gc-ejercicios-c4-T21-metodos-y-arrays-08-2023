using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio19
    {
        //19) Crea un array de números de un tamaño pasado por teclado, el array contendrá números aleatorios primos entre los números deseados, por último nos indicar cual es el mayor de todos. Haz un método para comprobar que el número aleatorio es primo, puedes hacer todos lo métodos que necesites.

        //ATRIBUTOS
        int[] numeros;
        int min = 0;
        int max = 99;

        //CONSTRUCTORES
        public Ejercicio19()
        {
            Console.WriteLine("Por favor indica el tamaño del array");
            int tamaño = int.Parse(Console.ReadLine());
            numeros = new int[tamaño];

            Console.WriteLine("\nLos numeros aleatorios primos se generaran entre estos rangos:");
            Console.WriteLine("Min: {0}, Max: {1}", min, max);

            RellenarValores(min, max);
            MostrarValores();
            MostrarMayor();
        }

        // MÉTODOS
        private int GeneradorPrimos(int min, int max)
        {
            while (true)
            {
                Random random = new Random();
                int numRandom = random.Next(min, max + 1);

                if (EsPrimo(numRandom))
                {
                    return numRandom;
                }
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            else if (numero == 2)
            {
                return true;
            }
            else if (numero % 2 == 0)
            {
                return false;
            }
            else
            {
                // Busca si tiene algun divisor impar
                // La función Math.Sqrt(numero) calcula la raiz cuadrada y se usa para optimizar el proceso ya que seria redundante si se siguiesen calculando numeros a partir de ese punto.
                for (int i = 3; i <= Math.Sqrt(numero); i += 2)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void RellenarValores(int min, int max)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = GeneradorPrimos(min, max);
            }
        }

        private void MostrarValores()
        {
            Console.WriteLine("\nLos valores primos del array son:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Índice: {0} - Número: {1}", i, numeros[i]);
            }
        }

        private void MostrarMayor()
        {
            int temp = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > temp)
                {
                    temp = numeros[i];
                }
            }

            Console.WriteLine("\nEl número más grande es {0}", temp);
        }
    }
}
