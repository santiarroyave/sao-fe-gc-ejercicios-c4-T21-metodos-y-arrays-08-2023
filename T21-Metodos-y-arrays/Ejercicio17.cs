using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio17
    {
        //17) Crea un array de 10 posiciones de números con valores pedidos por teclado. Muestra por consola el índice y el valor al que corresponde. Haz dos métodos, uno para rellenar valores y otro para mostrar.

        int[] numeros = new int[10];
        public void Inicia()
        {
            RellenarValores();

            MostrarValores();
        }

        private void RellenarValores()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escribe un número ({0}/{1})", i + 1, numeros.Length);
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }

        private void MostrarValores()
        {
            Console.WriteLine("\nLos valores del array son:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Índice: {0} - Número: {1}", i, numeros[i]);
            }
        }
    }
}
