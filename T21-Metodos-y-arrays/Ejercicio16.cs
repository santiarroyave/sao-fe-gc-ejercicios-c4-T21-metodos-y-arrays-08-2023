using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio16
    {
        //16) Indicar si un array de números es capicua. Es capicua cuando coincide el primero y el ultimo elemento, el segundo y el penúltimo y así sucesivamente.

        public void Inicia()
        {
            Console.WriteLine("Por favor escribe un número para saber si es capicúa o no");
            string numero = Console.ReadLine();

            // Muestra el mensaje después de llamar al método
            if (EsCapicua(numero) == true)
            {
                Console.WriteLine("\nSi es capicúa.");
            }
            else
            {
                Console.WriteLine("\nNo es capicúa.");
            }
        }

        private bool EsCapicua(string numero)
        {
            int[] digitos = new int[numero.Length];

            // Pasando el numero a un array de digitos
            for (int i = 0; i < numero.Length; i++)
            {
                digitos[i] = int.Parse(numero[i].ToString());
            }

            // Comprobando si es capicua
            for (int i = 0; i < (digitos.Length / 2); i++)
            {
                if (digitos[i] != digitos[digitos.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
