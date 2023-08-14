using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio3
    {
        //3) Crea una aplicación de consola que nos pida un número por teclado y con un método se lo pasamos por parámetro para que nos indique si es o no un número primo, debe devolver true si es primo sino false. Un número primo es aquel solo puede dividirse entre 1 y si mismo. Por ejemplo: 25 no es primo, ya que 25 es divisible entre 5, sin embargo, 17 si es primo.

        public void Inicia()
        {
            Console.WriteLine("Por favor escribe un numero para saber si es primo o no");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + EsPrimo(numero));
        }

        private Boolean EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            else if(numero == 2)
            {
                return true;
            }
            else if(numero % 2 == 0) 
            {
                return false;
            }
            else
            {
                // Busca si tiene algun divisor impar
                // La función Math.Sqrt(numero) calcula la raiz cuadrada y se usa para optimizar el proceso ya que seria redundante si se siguiesen calculando numeros a partir de ese punto.
                for (int i = 3; i <= Math.Sqrt(numero); i += 2)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
