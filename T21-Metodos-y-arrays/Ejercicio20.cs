using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio20
    {
        //20) Crea dos arrays de números con una posición pasado por teclado.
        //Uno de ellos estará rellenado con números aleatorios y el otro apuntara al array anterior
        //Después crea un nuevo array con el primer array (usa de nuevo new con el primer array) con el mismo tamaño que se ha pasado por teclado, rellenalo de nuevo con números aleatorios.
        //Después, crea un método que tenga como parámetros, los dos arrays y devuelva uno nuevo con la multiplicación de la posición 0 del array1 con el del array2 y así sucesivamente. Por último, muestra el contenido de cada array.

        //ATRIBUTOS
        int[] primerArray;
        int[] segundoArray;
        int min = 0;
        int max = 20;

        //CONSTRUCTORES
        public Ejercicio20()
        {
            Console.WriteLine("Por favor indica el tamaño del array");
            int tamaño = int.Parse(Console.ReadLine());

            primerArray = new int[tamaño];
            segundoArray = new int[tamaño];

            // Rellena el primer array y el segundo array apunta al primero
            RellenarPrimerArray();
            segundoArray = primerArray;

            // Crea el nuevo array con el primer array y lo vuelve a rellenar
            primerArray = new int[tamaño];
            RellenarPrimerArray();


            // Nuevo array con la multiplicacion de los otros dos
            int[] nuevoArray = NuevoArrayMultiplicado(primerArray, segundoArray);

            // Mostrando valores
            Console.WriteLine("\nPrimer Array: \n{0}", string.Join(", ", primerArray));
            Console.WriteLine("\nSegundo Array: \n{0}", string.Join(", ", segundoArray));
            Console.WriteLine("\nArray multiplicado: \n{0}", string.Join(", ", nuevoArray));
        }

        // MÉTODOS
        private int Generador(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private void RellenarPrimerArray()
        {
            for (int i = 0; i < primerArray.Length; i++)
            {
                primerArray[i] = Generador(min, max);
            }
        }

        private int[] NuevoArrayMultiplicado(int[] array1, int[] array2)
        {
            int[] nuevoArray = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                nuevoArray[i] = array1[i] * array2[i];
            }

            return nuevoArray;
        }
    }
}
