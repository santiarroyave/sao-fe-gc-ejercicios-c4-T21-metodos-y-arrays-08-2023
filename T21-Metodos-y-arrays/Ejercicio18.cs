using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio18
    {
        //18) Crea un array de números donde le indicamos por teclado el tamaño del array, rellenaremos el array con números aleatorios entre 0 y 9, al final muestra por pantalla el valor de cada posición y la suma de todos los valores. Haz un método para rellenar el array (que tenga como parámetros los números entre los que tenga que generar), para mostrar el contenido y la suma del array y un método privado para generar número aleatorio (lo puedes usar para otros ejercicios).

        //ATRIBUTOS
        int[] numeros;

        //CONSTRUCTORES
        public Ejercicio18() 
        {
            Console.WriteLine("Por favor indica el tamaño del array");
            int tamaño = int.Parse(Console.ReadLine());
            numeros = new int[tamaño];

            int min = 0;
            int max = 9;

            RellenarValores(min ,max);
            MostrarValores();
            MostrarSuma();
        }

        // MÉTODOS
        private int Generador(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private void RellenarValores(int min, int max)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Generador(min, max);
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

        private void MostrarSuma()
        {
            int temp = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                temp += numeros[i];
            }

            Console.WriteLine("\nLa suma total es {0}", temp);
        }
    }
}
