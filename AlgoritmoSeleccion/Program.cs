using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_Consola_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[100];
            Random rnd = new Random();
            int numero = rnd.Next(1, 100);
            Console.WriteLine("Numeros a ordenar");
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

           seleccion(vector);

            Console.WriteLine("Vector ordenado");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadKey();
        }

        private static void seleccion(int[] vector)
        {

            for (int i = 0; i < vector.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[min] > vector[j])
                    {
                        min = j;

                    }
                }
                int temp = vector[i];
                vector[i] = vector[min];
                vector[min] = temp;
            }
        }


    }

}
