using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio4
    {
        //4) Crea una aplicación de consola que nos calcule el factorial de un número pedido por teclado, lo realizara mediante un método al que le pasamos el número como parámetro.
        //Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno. Por ejemplo, si introducimos un 5, realizara esta operación 5*4*3*2*1=120.

        public void Inicia()
        {
            Console.WriteLine("Escribe el numero del cual quieres calcular su factorial");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl factorial es: {0}", CalcularFactorial(numero));
        }

        private int CalcularFactorial(int numero)
        {
            int total = 1;

            for (int i = 1; i <= numero; i++)
            {
                total *= i;
            }

            return total;
        }
    }
}
