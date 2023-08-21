using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_Metodos_y_arrays
{
    internal class Ejercicio14
    {
        //14) Dado el anterior array, pedir al usuario un numero e indicarle si existe en el array.
        public void Inicia()
        {
            // Replica el ejercicio anterior
            Console.WriteLine("Por favor indica el tamaño del array");
            int tamaño = int.Parse(Console.ReadLine());
            int min = 1;
            int max = 10;


            int[] listaNumeros = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                listaNumeros[i] = Generador(min, max);
            }

            Console.WriteLine(string.Join(", ", listaNumeros));

            // Código ejercicio14
            Console.WriteLine("\nPor favor indica el número que deseas buscar.");
            int numBuscar = int.Parse(Console.ReadLine());
            bool existe = false;

            // Comprueba si existe alguna coincidencia
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (listaNumeros[i] == numBuscar)
                {
                    existe = true;
                    break;
                }
            }

            // Muestra el mensaje
            if (existe == true)
            {
                    Console.WriteLine("\nEl número si está dentro del array.");
            }
            else
            {
                    Console.WriteLine("\nNo se ha encontrado el número.");
            }
        }

        private int Generador(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
