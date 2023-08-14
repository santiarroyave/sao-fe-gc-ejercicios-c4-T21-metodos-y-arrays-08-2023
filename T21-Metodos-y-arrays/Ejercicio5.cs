using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio5
    {
        //5) Crea una aplicación de consola que nos convierta un número en base decimal a binario. Esto lo realizara un método al que le pasaremos el numero como parámetro, devolverá un String con el numero convertido a binario. Para convertir un numero decimal a binario, debemos dividir entre 2 el numero y el resultado de esa división se divide entre 2 de nuevo hasta que no se pueda dividir mas, el resto que obtengamos de cada división formara el numero binario, de abajo a arriba.

        public void Inicia()
        {
            Console.WriteLine("¿Qué número quieres convertir a binario?");
            int numero = int.Parse(Console.ReadLine());

            ConvierteABinario(numero);
        }

        private void ConvierteABinario(int numero)
        {
            List<int> binario = new List<int>();
            
            while (numero > 0)
            {
                binario.Add(numero % 2);
                numero = numero / 2;
            }

            binario.Reverse();
            Console.WriteLine("\nNúmero binario: {0}", string.Join("", binario));
        }
    }
}
