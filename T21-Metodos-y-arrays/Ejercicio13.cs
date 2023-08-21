using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio13
    {
        //13) Rellenar un array de longitud pedida por el usuario con números aleatorios entre 1 y 10.

        public void Inicia()
        {
            Console.WriteLine("Por favor indica el tamaño del array");
            int tamaño = int.Parse(Console.ReadLine());
            int min = 1;
            int max = 10;


            int[] listaNumeros = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                listaNumeros[i] = Generador(min, max);
            }

            Console.WriteLine(string.Join(", ", listaNumeros));
        }

        private int Generador(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
