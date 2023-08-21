using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio10
    {
        //10) Hacer la tabla de un numero pedido por teclado hasta el 10. (5*0, 5*1 … 5*10). Muestra el contenido.

        public void Inicia()
        {
            Console.WriteLine("Escribe un número.");
            int num = int.Parse(Console.ReadLine());

            tabla(num);
        }

        private void tabla(int num)
        {
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }
}
