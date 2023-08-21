using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio12
    {
        //12) Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y sacar la media.

        public void Inicia()
        {
            int[] numeros = { 1, 4, 6, 2, 6, 3, 7, 3, 1, 4 };
            int temp = 0;
            double media;

            Console.WriteLine(string.Join(", ", numeros));

            for (int i = 0; i < numeros.Length; i++)
            {
                temp += numeros[i];
            }

            media = (double)temp / numeros.Length;
            Console.WriteLine("Media: {0}", media);
        }
    }
}
