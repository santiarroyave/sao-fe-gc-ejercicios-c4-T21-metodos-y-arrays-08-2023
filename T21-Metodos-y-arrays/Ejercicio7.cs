using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio7
    {
        //7) Crea un aplicación de consola que nos convierta una cantidad de euros introducida por teclado a otra moneda, estas pueden ser a dolares, yenes o libras. El método tendrá como parámetros, la cantidad de euros y la moneda a pasar que sera una cadena, este no devolverá ningún valor, mostrara un mensaje indicando el cambio (void).
        //  El cambio de divisas son:
        //  • 0.86 libras es un 1 €
        //  • 1.28611 $ es un 1 €
        //  • 129.852 yenes es un 1 €

        public void Inicia()
        {
            Console.WriteLine("Por favor introduce la cantidad de euros que quieres convertir;");
            float dinero = float.Parse(Console.ReadLine());
            Console.WriteLine("\nEscribe la moneda a pasar:");
            Console.WriteLine("Dolares | Yenes | Libras");
            string monedaElegida = Console.ReadLine().ToLower();

            convertir(dinero, monedaElegida);
        }

        private void convertir(float dinero, string monedaElegida)
        {
            switch (monedaElegida)
            {
                case "dolares":
                    Console.WriteLine("\n$ {0}", dinero * 1.28611);
                    break;
                case "yenes":
                    Console.WriteLine("\n{0} yenes", dinero * 129.852);
                    break;
                case "libras":
                    Console.WriteLine("\n{0} libras", dinero * 0.86);
                    break;
                default:
                    Console.WriteLine("No has elegido una opción válida");
                    break;
            }
        }
    }
}
