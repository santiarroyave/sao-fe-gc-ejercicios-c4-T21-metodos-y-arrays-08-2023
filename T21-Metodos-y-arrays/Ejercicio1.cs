using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio1
    {
        //1) Crea una aplicación de consola que nos calcule el área de un circulo, cuadrado o triangulo. Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área. Crea un método por cada figura para calcular cada área, este devolverá un número real. Muestra el resultado por pantalla.
        //    Aquí te mostramos que necesita cada figura:
        //    • Circulo: (radio ^ 2) * PI
        //    • Triangulo: (base * altura) / 2
        //    • Cuadrado: lado* lado

        string figura;

        public void Inicia()
        {
            Console.WriteLine("Para calcular el area primero elige la figura");
            Console.WriteLine("Circulo | Cuadrado | Triangulo");

            Boolean seleccionado = false;
            while (seleccionado == false)
            {
                this.figura = Console.ReadLine().ToLower();
                switch (figura)
                {
                    case "circulo":
                        Console.WriteLine("El área del circulo es: {0}", Circulo());
                        seleccionado = true;
                        break;
                    case "cuadrado":
                        Console.WriteLine("El área del cuadrado es: {0}", Cuadrado());
                        seleccionado = true;
                        break;
                    case "triangulo":
                        Console.WriteLine("El área del triangulo es: {0}", Triangulo());
                        seleccionado = true;
                        break;
                    default:
                        Console.WriteLine("\nPrueba otra vez");
                        break;
                }
            }
            Console.WriteLine("\nHas salido del bucle");
        }

        private double Circulo()
        {
            Console.WriteLine("\nPor favor indique el radio del círculo");
            double radio = double.Parse(Console.ReadLine());
            return Math.PI * Math.Pow(radio, 2);
        }

        private double Cuadrado()
        {
            Console.WriteLine("\nPor favor indique la base del cuadrado");
            double baseCuadrado = double.Parse(Console.ReadLine());
            return Math.Pow(baseCuadrado, 2);
        }

        private double Triangulo()
        {
            Console.WriteLine("\nPor favor indique la base del triangulo");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora indique la altura del triangulo");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }

    
}
