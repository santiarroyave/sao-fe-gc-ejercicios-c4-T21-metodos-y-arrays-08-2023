using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio21
    {
        //21) Crea un array de números de un tamaño pasado por teclado, el array contendrá números aleatorios entre 1 y 300 y mostrar aquellos números que acaben en un dígito que nosotros le indiquemos por teclado (debes controlar que se introduce un numero correcto), estos deben guardarse en un nuevo array.
        //Por ejemplo, en un array de 10 posiciones e indicamos mostrar los números acabados en 5, podría salir 155, 25, etc.

        //ATRIBUTOS
        int min = 0;
        int max = 300;
        int[] numeros;
        int[] arrayFiltrado;

        //CONSTRUCTORES
        public Ejercicio21()
        {
            Console.WriteLine("Por favor indica el tamaño del array");
            int tamaño = int.Parse(Console.ReadLine());

            numeros = new int[tamaño];

            // Rellenar array
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Generador(min, max);
            }

            // Pide el digito de filtro
            int filtro = PedirDigitoFiltro();
            // Obtiene el nuevo array filtrado
            arrayFiltrado = ObtenerArrayFiltrado(numeros, filtro);

            // Muestra datos
            Console.WriteLine("\nEl primer array: \n{0}", string.Join(", ", numeros));
            Console.WriteLine("\nLos números acabados en {0} son: \n{1}", filtro, string.Join(", ", arrayFiltrado));
        }

        //MÉTODOS
        private int Generador(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private int PedirDigitoFiltro()
        {
            Console.WriteLine("\nEscribe un digito para filtrar los numeros");
            while (true)
            {
                try
                {
                    int digito = int.Parse(Console.ReadLine());

                    if (digito >= 0 && digito <= 9)
                    {
                        return digito;
                    }
                    else
                    {
                        Console.WriteLine("\nEl dígito está fuera del rango. (0-9)");
                    }
                }
                catch
                {
                    Console.WriteLine("\nPor favor ingresa un dígito válido entre 0 y 9:");
                }
            }
        }

        private int[] ObtenerArrayFiltrado(int[] numeros, int filtro)
        {
            int[] arrayFiltrado = new int[numeros.Length];
            int contador = 0;

            foreach (var numero in numeros)
            {
                if (numero % 10 == filtro)
                {
                    arrayFiltrado[contador] = numero;
                    contador++;
                }
            }

            Array.Resize(ref arrayFiltrado, contador);
            return arrayFiltrado;
        }
    }
}
