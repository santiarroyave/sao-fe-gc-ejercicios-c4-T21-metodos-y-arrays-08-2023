using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio11
    {
        //11) Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y sacar la suma total.

        public void Inicia()
        {
            int[] numeros = { 1, 4, 6, 2, 6, 3, 7, 3, 1, 4};
            int temp = 0;

            Console.WriteLine(string.Join(", ", numeros));

            for (int i = 0; i < numeros.Length; i++)
            {
                temp += numeros[i];
            }

            Console.WriteLine("Suma total: {0}", temp);
        }
    }
}
