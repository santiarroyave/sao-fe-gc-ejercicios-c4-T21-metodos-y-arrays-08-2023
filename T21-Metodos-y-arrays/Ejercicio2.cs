using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio2
    {
        //2) Crea una aplicación de consola que nos genere una cantidad de números enteros aleatorios que nosotros le pasaremos por teclado. Crea un método donde pasamos como parámetros entre que números queremos que los genere, podemos pedirlas por teclado antes de generar los números. Este método devolverá un número entero aleatorio. Muestra estos números por pantalla.

        public void Inicia()
        {
            Console.WriteLine("¿Cuántos números aleatorios quieres?");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Indica el valor minimo");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora indica el valor máximo");
            int max = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                list.Add(Generador(min,max));
            }

            Console.WriteLine("\nLista de números aleatorios:\n{0}", string.Join(", ", list));
        }

        private int Generador(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
