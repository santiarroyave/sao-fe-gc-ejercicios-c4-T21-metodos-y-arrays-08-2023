using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio6
    {
        //6) Crea una aplicación de consola que nos cuente el número de cifras de un número entero positivo (hay que controlarlo) pedido por teclado. Crea un método que realice esta acción, pasando el número por parámetro, devolverá el número de cifras.

        public void Inicia()
        {
            Console.WriteLine("Escribe un número para contar sus cifras");
            if (int.TryParse(Console.ReadLine(), out int cifras))
            {
                Console.WriteLine(ContarCifras(cifras));
            }
            else
            {
                Console.WriteLine("No has introducido un valor válido");
            }
        }

        private int ContarCifras(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }

            int cifras = 0;

            while (numero != 0)
            {
                cifras++;
                numero /= 10;
            }
            return cifras;
        }
    }
}
