using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio15
    {
        //15) Invertir los valores de un array y meterlos en otro array.

        public void Inicia()
        {
            int[] numeros = { 1, 4, 6, 2, 6, 3, 7, 3, 1, 4 };
            Console.WriteLine("Valores iniciales: \n{0}" ,string.Join(", ", numeros));

            int[] nuevoArray = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                nuevoArray[i] = numeros[numeros.Length - 1 - i];
            }

            Console.WriteLine("\nNuevo array invertido: \n{0}", string.Join(", ", nuevoArray));
        }
    }
}
