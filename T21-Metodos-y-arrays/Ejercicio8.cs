using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio8
    {
        //8) Crear un array de números con la longitud que quieras e introducir en cada elemento el valor su posición. Muestra el contenido.

        public void Inicia()
        {
            int[] arrayNumeros = new int[20];

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = i;
            }

            Console.WriteLine(string.Join(", ", arrayNumeros));
        }

    }
}
