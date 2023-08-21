using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio9
    {
        //9) Crear un array de numeros con la longitud que quieras y pedir al usuario que en cada elemento inserte un numero. Muestra el contenido.
        public void Inicia()
        {
            int[] arrayNumeros = new int[5];

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine("Por favor introduce un número. ({0}/{1})", i+1, arrayNumeros.Length);
                arrayNumeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n{0}", string.Join(", ", arrayNumeros));
        }
    }
}
